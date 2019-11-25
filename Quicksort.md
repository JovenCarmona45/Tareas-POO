*Quicksort*

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace P_24ShellNcontrol
    {
        class Shell
        {
            public int k, M, H, I, J;
            public int[] A;


            public void Shellear()
            {
                int[] V = {1, 2, 3, 5, 7, 11, 13, 17, 19, 23};
                for (M = V.Length - 1; M >= 0; M = M - 1)
                {
                    H = V[M];
                    for (J = H; J < A.Length; J = J + 1)
                    {
                        I = J - H;
                        k = A[J];
                        while(I >= 0 && k <= A[I])
                        {
                            A[I + H] = A[I];
                            I = I - H;
                        }
                        A[I + H] = k;
                    }
                }           
            }

            public void Generar()
            {
                Random random = new Random();
                A = new int[50];
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = random.Next(18210000, 18210100);

                }
            }
            public void imprimir()
            {
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("\n" + (i + 1) + " .-" + A[i]);
                }
            }
            ~Shell()
            {

            }

        }
        class Program
        {
            static void Main()
            {
                int paracaso;
                Shell s = new Shell();
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Generar Arreglo de numeros de control \n2. Desplegar Arreglo \n3. Ordenar Arreglo \n4. Salir del programa");
                    Console.Write("La opcion que desea(Numeros de control): ");
                    paracaso = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (paracaso)
                    {
                        case 1:
                            s.Generar();
                            Console.WriteLine("Se generaron los numeros de control con exito");
                            Console.WriteLine("Presione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                        case 2:
                            s.imprimir();
                            Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                        case 3:
                            s.Shellear();
                            Console.WriteLine("Se ordeno correctamente");
                            Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Presione cualquier tecla para cerrar el programa");
                            Console.ReadKey();
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
