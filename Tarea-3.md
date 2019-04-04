# Herencia
## Clase Base
La Clase Base es aquella que tiene sus atributos y metodos independientes de otras clases, es decir, no depende de atributos ajenos que no sean las de la misma clase. De una manera mas concreta es la clase padre, aquella que siempre esta fija.
## Clase Derivada 
La Clase Derivada es cuando se heredan las funciones de la clase Base y se le puede agregar un atributo mas a la clase derivada.
## UML de Herencias

![imagen1](https://github.com/JovenCarmona45/Tareas-POO/blob/master/Tarea%203/Las%20figuras.png)

En la imagen anterior, la clase base es la que se llama figura, las que estan heredando de ella son la que se llaman Circulo y Rectangulo.

## Herecia simple y Herencia multiple

Esto quiere decir que las clases que vayan a heredar lo hagan de una sola, esto quiere decir herencia simple. La herencia multiple es cuando una clase puede heredar de multiples clases. De estos dos ambitos solo esta disponible en C# la herencia simple, aun no esta impleentado la herencia multiple en este lenguaje de programacion, pero existen otras alternativas a esto, asi como las interfaces.

## Programa de las figuras

    using System;
    using System.Collections.Generic;
    namespace FiguraS
    {
    class Vector2D
    {
        public int x, y;
        public Vector2D(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", x, y);
        }
    }

    class Figura
    {
        public Vector2D position;
        public string border;
        public string fill;

        public Figura() : this(new Vector2D(100, 100))
        {
        }
        public Figura(Vector2D pos)
        {
            position = pos;
            fill = "Rojo";
            border = "Black";
        }
        public virtual void Dibuja()
        {

        }

    }

    class Circulo : Figura
    {
        private int radio;
        public Circulo(Vector2D pos, int radio) : base(pos)
        {
            this.radio = radio;
        }
        public Circulo() : base()
        {
            this.radio = 10;
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en {0} de color {1} con radio de {2}", position, fill, radio);
        }
    }
    class Rectangulo : Figura
    {
        public Rectangulo(Vector2D pos) : base(pos)
        {
        }
        public Rectangulo() : base()
        {
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
        }
    }
    class Cuadrado : Figura
    {
        public Cuadrado(Vector2D pos) : base(pos)
        {
        }
        public Cuadrado() : base()
        {
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Cuadrado en {0} de color {1}", position, fill);
        }

    }
    
    class Program
    {
        static void Main()
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(200, 200)));
            figuras.Add(new Cuadrado(new Vector2D(300, 300)));
            foreach (Figura f in figuras)
            {
                f.Dibuja();
            }
            Console.ReadKey();
        }
    }
    }
