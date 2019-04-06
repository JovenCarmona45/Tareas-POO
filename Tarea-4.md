# Tarea 4
## 1. Considera el siguiente fragmento de programa:

        using System;

        class A
        {
            public int a;

            public A()
            {
                a = 10;
            }

            public virtual string Display()
            {
                return a.ToString();
            }
        }

        class B : A
        {
            public int b;

            public B()
            {
                b = 15;
            }
            public override string Display()
            {
                return b.ToString();
            }
        }

        class Program
        {
            public static void Main()
            {
                A objA = new A();
                B objB = new B();

                Console.WriteLine(objA.Display()); 
                Console.WriteLine(objB.Display()); 
                Console.ReadKey();
            }  
        }

## 1.1. ¿Qué valores imprimen las lineas (1) y (2)?
10 y 10 

## 1.2.  Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?
10 y 15 Respectivamente

## 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
Virtual

## 2. Considera el siguiente fragmento de programa:



## 2.1. Completa el programa.

## 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
Al punto "C" le falta la palabra clave Override

## 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
El Afina(), por que cuando se hereda de una clase abstracta siempre se implementas los metodos en las clases derivadas. 

## 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
No se ponen por que es un metodo abstracto, ya que si no lo fuera, ahi si se usarian.

## 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
No es necesario seguirn implementandolo en las clases derivadas.

## 3. Implementa el programa utilizando interfaces en lugar de herencia.
        using System;

        using System.Collections.Generic;


        interface IAfina
        {
            void Afina();
        }
          class Musico : IAfina
         {
            public string nombre;

            public Musico (string n)
            {
                 nombre = n;
            }

            public void Afina()
            {
                Console.WriteLine("Afinando");
            }

            public virtual string Display()
           { 
               return string.Format(nombre);
           }
         }

        class Bajista: Musico, IAfina
        {
            public string instrumento;

            public Bajista(string n, string i) : base(n)
            {
                instrumento = i;
            }

            public virtual new void Afina()
            {
                Console.WriteLine("Afinando el bajo");
            }

            public override string Display()
            {
                return string.Format(instrumento);
            }

        }

        class Guitarrista: Musico, IAfina
        {
            public string guitarra;


            public Guitarrista(string n, string g) : base(n)
            {
                guitarra = g;
            }
            public new void Afina()
            {
                Console.WriteLine("Afinando la guitarra");
            }

            public override string Display()
            {
                return string.Format(guitarra);
            }

        }

        class Program
        {

          public static void Main()
          {
                List<Musico> musicos = new List<Musico>();
                Musico m = new Musico("Django"); 
                Bajista b = new Bajista("Flea", "Bajo");
                Guitarrista g = new Guitarrista("Santana", "Guitarra");
                musicos.Add(b);
                musicos.Add(g);
                musicos.Add(m);

                foreach (Musico lo in musicos)
                {
                    (m as IAfina).Afina();
                    (g as IAfina).Afina();
                    (b as IAfina).Afina();
                }
                Console.ReadKey();
            }
        }
