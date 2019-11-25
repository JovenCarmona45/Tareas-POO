    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace P22_BurbujaNControl
    {
        class Burbuja
        {
            public int temp, k, L;
            public int[] A;

            public void Burbujear()
            {
                temp = 0;
                for(k = 0; k < A.Length -1; k++)
                {
                    for(L = 0; L < A.Length - 1 - k; L++)
                    { 
                        if(A[L] > A[L + 1])
                        {
                            temp = A[L];
                            A[L] = A[L + 1];
                            A[L + 1] = temp;
                        }
                    }
                }

            }

            public void Arreglar()
            {
                Random random = new Random();
                A = new int[50];
                for (int i = 0; i < 50; i++)
                {
                    A[i] = random.Next(18210000, 18210100);

                }
            }
            public void imprimir()
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("\n" + (i + 1) + " .-" + A[i]);
                }
            }
            ~Burbuja()
            {

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int paracaso;
                Burbuja b = new Burbuja();
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Generar Arreglo de numeros de control \n2. Desplegar Arreglo \n3. Ordenar Arreglo \n4. Salir del programa");
                    Console.Write("La opcion que desea(Numeros de control): ");
                    paracaso = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch(paracaso)
                    {
                        case 1:
                            b.Arreglar();
                            Console.WriteLine("Se generaron los numeros de control con exito");
                            Console.WriteLine("Presione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                        case 2:
                            b.imprimir();
                            Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                        case 3:
                            b.Burbujear();
                            Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Esa opcion no es valida");
                            Console.WriteLine("Presione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                    }

                } while (paracaso != 4);
            }
        }
    }
