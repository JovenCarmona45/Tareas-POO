        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace P21_ArbolString
        {
            class Arbol
            {
                public float info;
                Arbol izq, der;

                public Arbol()
                {
                    info = 0;
                    izq = null;
                    der = null;
                }
                public Arbol raiz = null;
                public void Insertar(float dato)
                {
                    int bandera = 0;
                    Arbol hoja = new Arbol();
                    hoja.info = dato;
                    if (raiz == null)
                    {
                        raiz = hoja;
                    }
                    else
                    {
                        Arbol temp = raiz;
                        while (bandera != 1)
                        {
                            if (hoja.info < temp.info)
                            {
                                if (temp.izq == null)
                                {
                                    temp.izq = hoja;
                                    bandera = 1;
                                }
                                else
                                {
                                    temp = temp.izq;
                                }
                            }
                            else
                            {
                                if (temp.der == null)
                                {
                                    temp.der = hoja;
                                    bandera = 1;
                                }
                                else
                                {
                                    temp = temp.der;
                                }
                            }
                        }
                    }
                }
                public void Preorden(Arbol temp)
                {
                    if (temp != null)
                    {
                        Console.WriteLine(temp.info);
                        if (temp.izq != null)
                        {
                            Preorden(temp.izq);
                        }
                        if (temp.der != null)
                        {
                            Preorden(temp.der);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Arbol binario vacio");
                    }
                }
                public void Inorden(Arbol temp)
                {
                    if (temp != null)
                    {
                        if (temp.izq != null)
                        {
                            Inorden(temp.izq);
                        }
                        Console.WriteLine(temp.info);
                        if (temp.der != null)
                        {
                            Inorden(temp.der);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Arbol binario vacio");
                    }
                }
                public void Posorden(Arbol temp)
                {
                    if (temp != null)
                    {
                        if (temp.izq != null)
                        {
                            Posorden(temp.izq);
                        }
                        if (temp.der != null)
                        {
                            Posorden(temp.der);
                        }
                        Console.WriteLine(temp.info);
                    }
                    else
                    {
                        Console.WriteLine("Arbol binario Vacio");
                    }
                }
                public void BusquedaRecursiva(float key, Arbol temp)
                {
                    if (temp == null)
                    {
                        Console.WriteLine("No esta el nodo: " + key + " en el Arbol Binario");
                    }
                    else
                    {
                        if (key == temp.info)
                        {
                            Console.WriteLine("El nodo: " + key + " si esta en el Arbol Binario");
                        }
                        else
                        {
                            if (key < temp.info)
                            {
                                BusquedaRecursiva(key, temp.izq);
                            }
                            else
                            {
                                BusquedaRecursiva(key, temp.der);
                            }
                        }
                    }
                }
                public void BusquedaIterativa(float key, Arbol temp)
                {
                    bool encontrado = false;
                    while (temp != null && encontrado == false)
                    {
                        if (key == temp.info)
                        {
                            encontrado = true;
                        }
                        else
                        {
                            if (key < temp.info)
                            {
                                temp = temp.izq;
                            }
                            else
                            {
                                temp = temp.der;
                            }
                        }
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine("El nodo: " + key + " No esta en el arbol Binario");
                    }
                    else
                    {
                        Console.WriteLine("El nodo: " + key + " Si esta en el arbol Binario");
                    }
                }
                public void Eliminar()
                {
                    Arbol p, q, v, s, t;
                    bool encontrado = false;
                    float x;
                    p = raiz;
                    q = null;
                    if (p != null)
                    {
                        Console.Write("Nodo a eliminar : ");
                        x = float.Parse(Console.ReadLine());
                        while (p != null && encontrado == false)
                        {
                            if (p.info == x)
                            {
                                encontrado = true;
                                Console.WriteLine("El nodo: " + p.info + " sera eliminado");
                            }
                            else
                            {
                                q = p;
                                if (x < p.info)
                                {
                                    p = p.izq;
                                }
                                else
                                {
                                    p = p.der;
                                }
                            }
                        }
                        if (encontrado == true)
                        {
                            if (p.izq == null)
                            {
                                v = p.der;
                            }
                            else
                            {
                                if (p.der == null)
                                {
                                    v = p.izq;
                                }
                                else
                                {
                                    t = p;
                                    v = p.der;
                                    s = v.izq;
                                    while (s != null)
                                    {
                                        t = v;
                                        v = s;
                                        s = v.izq;
                                    }
                                    if (t != p)
                                    {
                                        t.izq = v.der;
                                        v.der = p.der;
                                    }
                                    v.izq = p.izq;
                                }
                            }
                            if (q == null)
                            {
                                raiz = v;
                            }
                            else
                            {
                                if (p == q.izq)
                                {
                                    q.izq = v;
                                }
                                else
                                {
                                    q.der = v;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("El nodo: " + x + " NO esta en el Arbol Binario");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El Arbol Binario esta vacio");
                    }
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    try
                    {
                        Arbol a = new Arbol();
                        int paracaso;
                        do
                        {
                            Console.Clear();
                            Console.Write("Menu de Arbol binario \n1. Insertar nodo \n2. Eliminar nodos \n3. Recorrido Preorden \n4. Recorrido Inorden \n5. Recorrido Posorden \n6. Busqueda recursiva" +
                                " \n7. Busqueda Iterativa \n8. Salir del programa");
                            Console.Write("\nQue opcion desea: ");
                            paracaso = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (paracaso)
                            {
                                case 1:
                                    Console.Write("Nodo que desea asignar: ");
                                    float dat;
                                    dat = float.Parse(Console.ReadLine());
                                    a.Insertar(dat);
                                    Console.WriteLine("Se asigno el nodo correctamente");
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    a.Eliminar();
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    a.Preorden(a.raiz);
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    a.Inorden(a.raiz);
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    a.Posorden(a.raiz);
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.Write("Nodo que desea buscar: ");
                                    float key = float.Parse(Console.ReadLine());
                                    a.BusquedaRecursiva(key, a.raiz);
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 7:
                                    Console.Write("Nodo que desea buscar: ");
                                    float llave = float.Parse(Console.ReadLine());
                                    a.BusquedaIterativa(llave, a.raiz);
                                    Console.WriteLine("Presione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                case 8:
                                    break;
                                default:
                                    Console.WriteLine("Opcion no valida");
                                    Console.WriteLine("Presione cualquier tecla para regresar");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (paracaso != 8);
                    }
                    catch
                    {
                    }
                }
            }
        }
