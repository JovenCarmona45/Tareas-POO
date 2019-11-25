        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace P26_QuicksortNcontrol
        {
            class Quicksort
            {
                public int i, j, w;
                public int[] A;
                public float x;



                public void quicksort(int L, int R)
                {
                    i = L;
                    j = R;
                    x = A[(L + R) / 2];
                    do
                    {
                        while(A[i] < x)
                        {
                            i++;
                        }
                        while(A[j] > x)
                        {
                            j--;
                        }
                        if (i <= j)
                        {
                            w = A[i];
                            A[i] = A[j];
                            A[j] = w;
                            i++;
                            j--;
                        }
                    } while (i < j);
                    if (L < j)
                    {
                        quicksort(L, j);
                    }
                    if(i < R)
                    {
                        quicksort(i, R);
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
                ~Quicksort()
                {

                }
            }


            class Program
            {
                static void Main()
                {
                    int paracaso;
                    Quicksort Q = new Quicksort();
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
                                Q.Generar();
                                Console.WriteLine("Se generaron los numeros de control con exito");
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 2:
                                Q.imprimir();
                                Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 3:
                                Q.quicksort(0, Q.A.Length - 1);
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
