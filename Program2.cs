using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_14PilaNumeros
{
    class Pilas
    {
        public float[] Pila;
        public int Max;
        public int Top;
        public int Apuntar;

        public Pilas(int Max)
        {
            this.Max = Max;
            Top = -1;
            Pila = new float[Max];
        }

        public void Push(float elemento)
        {
            if (Top != Max -1)
            {
                Top = Top + 1;
                Pila[Top] =  elemento; 
            }
            else
            {
                Console.Write("La pila esta llena");
            }
        }
        public void Pop()
        {
            if (Top != -1)
            {
                Console.WriteLine("Elemento eliminado: " + Pila[Top]);
                Pila[Top] = 0;
                Top = Top - 1;
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
            }
        }
        public void Recorrido()
        {
            if (Top != -1)
            {
                Apuntar = Top;
                while (Apuntar != -1) 
                {
                    Console.WriteLine("Elemento " + Pila[Apuntar] + " Posicion:  " + Apuntar);
                    Apuntar = Apuntar - 1;
                } 
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
            }
        }
        public void Busqueda(float elemento)
        {
            if (Top != -1)
            {
                Apuntar = Top;
                while (Apuntar != -1) 
                {
                    if (Pila[Apuntar] == elemento)
                    {
                        Console.WriteLine("Elemento: " + elemento + " localizado posicion: " + Apuntar);
                        return; 
                    }
                    else
                    {
                        Apuntar = Apuntar - 1;
                    }
                } 
                Console.WriteLine("El dato: " + elemento + " No esta en la pila");
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
            }
        }
        ~Pilas()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            int paracaso,Maxi=0;
            float elemento;
            Pilas p = new Pilas(Maxi);
            do
            {
                Console.Clear();
                Console.WriteLine("1. Crear pila \n2. Insertar Elemento \n3. Eliminar Elemento \n4. Recorrer la pila \n5. Buscar elementos en la pila \n6. Salir del programa ");
                Console.Write("Seleccionar opcion (Menu pilas): ");
                paracaso = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (paracaso)
                {
                    case 1:
                        Console.Write("Tamaño del arreglo: ");
                        Maxi = int.Parse(Console.ReadLine());
                        p = new Pilas(Maxi);
                        break;
                    case 2:
                        Console.Write("Elementos para arreglar: ");
                        elemento = float.Parse(Console.ReadLine());
                        p.Push(elemento);
                        Console.WriteLine("\nPresione cualquier tecla para regresar");
                        Console.ReadKey();
                        break;
                    case 3:
                        p.Pop();
                        Console.ReadKey();
                        break;
                    case 4:
                        p.Recorrido();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Elemento que desea buscar:  ");
                        float ele = float.Parse(Console.ReadLine());
                        p.Busqueda(ele);
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
