using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_Cola
{
    class Colas
    {
        public float[] Cola;
        public int Max;
        public int Top;
        public int Apuntar;
        public int frente, final;

        public Colas(int Max)
        {
            this.Max = Max;
            frente = - 1;
            final = - 1;
            Cola = new float[Max];
        }

        public void Push(float elemento)
        {
            if (frente == 0 && final == Max - 1)
            {
                Console.Write("La cola esta llena");
            }
            else
            {
                if (frente == -1)
                {
                    frente = 0;
                    final = 0;
                }
                else
                {
                    final = final + 1;
                }
                Cola[final] = elemento;
            }
            Console.ReadKey();
        }
        public void Pop()
        {
            if (frente != -1)
            {
                Console.WriteLine("Elemento: " + Cola[frente] + " Sera eliminado");
                Cola[Top] = 0;
                if (frente == final)
                {
                    frente = -1;
                    final = -1;
                }
                else
                {
                    frente = frente + 1;
                }
            }
            else
            {
                Console.WriteLine("La Cola esta vacia");
            }
        }
        public void Recorrido()
        {
            if (frente != -1)
            {
                Apuntar = frente;
                while (Apuntar <= final)
                {
                    Console.WriteLine("Elemento " + Cola[Apuntar] + " Posicion:  " + Apuntar);
                    Apuntar = Apuntar + 1;
                }
            }
            else
            {
                Console.WriteLine("La Cola esta vacia");
            }
        }
        public void Busqueda(float elemento)
        {
            if (frente != -1)
            {
                Apuntar = frente;
                while (Apuntar <= final)
                {
                    if (elemento == Cola[Apuntar])
                    {
                        Console.WriteLine("Dato localizado en posicion: " + Apuntar);
                        return;
                    }
                    else
                    {
                        Apuntar = Apuntar + 1;
                    }
                }
                Console.WriteLine("El dato: " + elemento + " No esta en la Cola");
            }
            else
            {
                Console.WriteLine("La Cola esta vacia");
            }
        }
        ~Colas()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            int paracaso, Maxi = 0;
            float elemento;
            Colas c = new Colas(Maxi);
            do
            {
                Console.Clear();
                Console.WriteLine("1. Crear Cola \n2. Insertar Elemento \n3. Eliminar Elemento \n4. Recorrer la Cola \n5. Buscar elementos en la Cola \n6. Salir del programa ");
                Console.Write("Seleccionar opcion (Menu Colas): ");
                paracaso = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (paracaso)
                {
                    case 1:
                        Console.Write("Tamaño del arreglo: ");
                        Maxi = int.Parse(Console.ReadLine());
                        c = new Colas(Maxi);
                        break;
                    case 2:
                        Console.Write("Elementos para arreglar: ");
                        elemento = float.Parse(Console.ReadLine());
                        c.Push(elemento);
                        break;
                    case 3:
                        c.Pop();
                        Console.ReadKey();
                        break;
                    case 4:
                        c.Recorrido();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Elemento que desea buscar:  ");
                        float ele = float.Parse(Console.ReadLine());
                        c.Busqueda(ele);
                        Console.ReadKey();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no existe");
                        Console.WriteLine("Pulse Enter para salir al menu");
                        Console.ReadKey();
                        break;
                }
            } while (paracaso != 6);
        }
    }
}
