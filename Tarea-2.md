# Tarea 2
## Declaración de clases: atributos, métodos, encapsulamiento.

**2.1 Clases y estructuras**

Las Class y las estructuras son dos puntos importantes en el Type System. Individualmente forman un encapsulamiento de datos y algunos comportamientos que llegan a formar la unidad lógica.

La declaracion de la Class o estuctura es como un camino que ayudad a crear varias instancias a partir de una sola, como por ejemplo se crea una clase de tipo Persona y con respecto a esa clase se pueden ir creando otras con diferetes valores en sus propiedades y campos.

Una clase es un tipo de referencia. Cuando se crea un objeto de la clase, la variable a la que se asigna el objeto contiene solo una referencia a esa memoria. Cuando la referencia de objeto se asigna a una nueva variable, la nueva variable hace referencia al objeto original. Los cambios realizados en una variable se reflejan en la otra variable porque ambas hacen referencia a los mismos datos.

Una estructura es un tipo de valor. Cuando se crea una estructura, la variable a la que se asigna la estructura contiene los datos reales de ella. Cuando la estructura se asigna a una nueva variable, se copia. Por lo tanto, la nueva variable y la variable original contienen dos copias independientes de los mismos datos. Los cambios realizados en una copia no afectan a la otra copia.

Resumiendo la clase y la estructura, son tipos de datos que operan de manera diferente pero en algunos puntos pueden ser de mucha ayuda; la clase sirve para crear o modelar datos que en un futuro se tienen planeado modificar un objeto de la misma clase. La estructura es para casos mas pequeños de datos que estos no se tenga planeado modificar a futuro.

Ejemplo de las clases y estrucuturas con el uso de un constructor y un metodo:

    using System;

    namespace ProgrammingGuide
    {
      // Class definition.
      public class CustomClass
      {
          // Class members.
          //
          // Property.
          public int Number { get; set; }

          // Method.
          public int Multiply(int num)
          {
              return num * Number;
          }   

          // Instance Constructor.
          public CustomClass()
          {
              Number = 0;
          }
      }

      // Another class definition that contains Main, the program entry point.
      class Program
      {
          static void Main(string[] args)
          {
            // Create an object of type CustomClass.
            CustomClass custClass = new CustomClass();

            // Set the value of the public property.
            custClass.Number = 27;

            // Call the public method.
            int result = custClass.Multiply(4);
            Console.WriteLine($"The result is {result}.");
          }
      }
    }
    // The example displays the following output:
    //      The result is 108. 

### Encapsulamiento

La encapsulación a veces se le conoce como el principio de la programación orientada a objetos. Por lo que se entiende de encapsulamiento, es que depende de la clase y la estructura hasta que punto se le pudede colocar los diferentes niveles de acceso para poder saber si se codifica fuera de la clase o estructura. El uso de los metodos y las variables no se prevé fuera de la clase, tambien todo esto puede estar oculto dentro del codigo para evitar errores en un futuro.

### Miembros 

Todos los métodos, campos, constantes, propiedades y eventos deben declararse dentro de un tipo; se les denomina miembros del tipo. En C#, no hay métodos ni variables globales como en otros lenguajes. Inclusive el metodo Main debe declararse en una clase o estructura. 

### Accesibilidad

Algunos métodos y propiedades están diseñados para ser invocables y accesibles desde el código fuera de la clase o la estructura, lo que se conoce como _código de cliente_. Algunos otros metodos tambien estan hechos para que se indiquen y que solo se puedan utilizar en esa clase o estructura. Cabe destacar que se debe poner limites en el codigo para que solo el codigo de cliente pueda acceder a el. Se puede utilizar diferentes tipos de acceso los cuales son, public, protected, internal, protected internal, private y private protected para especificar hasta que punto el codigo de cliente tenga acceso. La accesibilidad predeterminada es private.

### Herencia

Solo aplica para las clases, este tipo de metodo es para que una clase pueda derivar de otra y esta conserve todos los tributos y metodos de la clase Base, pero no sus constructores y finalizadores.

Las clases se pueden declarar como abstract, lo cual esto significa que uno o varios de sus metodos no estan implementados. Aunque no se pueden crear instancias de clases abstractas directamente, estas sirven como clases base para otras clases que ayudan con la implementacion que falta. Las clases también pueden declararse como sealed para evitar que otras clases hereden de ellas. 

### Interfaces

Las clases y las estructuras pueden heredar muchas interfaces. Heredar de una interfaz significa que el tipo implementa todos los métodos definidos en la interfaz.

### Tipos genéricos

Las clases y estructuras pueden definirse con uno o varios parámetros de tipo. El código de cliente proporciona el tipo cuando crea una instancia del tipo. Por ejemplo, la clase List<T> del espacio de nombres System.Collections.Generic se define con un parámetro de tipo. El código de cliente crea una instancia de List<string> o List<int> para especificar el tipo que contendrá la lista.
    
### Tipos estáticos

Las clases (pero no las estructuras) pueden declararse como static. Una clase estática puede contener solo miembros estáticos y no se puede crear una instancia de ellos con la palabra clave new. Una copia de la clase se carga en memoria cuando se carga el programa, y sus miembros son accesibles a través del nombre de clase. Las clases y estructuras pueden contener miembros estáticos.

### Tipos anidados

Una clase o estructura se puede anidar dentro de otra clase o estructura.

### Tipos parciales

Puede definir parte de una clase, estructura o método en un archivo de código y otra parte en un archivo de código independiente.

### Inicializadores de objeto

Puede crear instancias de objetos de clase o estructura y de colecciones de objetos e iniciarlizarlos, sin llamar de forma explícita a su constructor.

### Tipos anónimos
En situaciones donde no es conveniente o necesario crear una clase con nombre, por ejemplo al rellenar una lista con estructuras de datos que no tiene que conservar o pasar a otro método, utilice los tipos anónimos.

### Métodos de extensión
Puede "extender" una clase sin crear una clase derivada mediante la creación de un tipo independiente cuyos métodos pueden llamarse como si pertenecieran al tipo original.

### Variables locales con asignación implícita de tipos

Dentro de un método de clase o estructura, puede utilizar tipos implícitos para indicar al compilador que determine el tipo correcto en tiempo de compilación.

## 2.2 Instancia de una clase

### Operador new

Este tipo de operador se usa para crear objetos y tambien puede invocar a los constructores de las clases.

Algunos de sus usos son:
    - Crear instancias de diferentes tipos
    - Tambien se puede utilizar para invocar el constructor default para lo tipos de valor
    
## 2.3 Referencia l objeto actual

### This 

        using.System;
        
            class Alumno
            {
                public string nombre;
                public string numerocontrol;

                public Alumno(string nombre, string numerocontrol)
                {
                    this.nombre = nombre;
                    this.numerocontrol = numerocontrol;
                }
            }

##  2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores

### Parámetros de métodos

Los parámetros establecidos para un método sin **in, ref o out** se pasan al método llamado por _valor_.

Ese valor declarado puede ser modificado en el metodo, aunque todos los cambios hechos en el metodo se perderan al momento de ser regresados al procedimiento que lo llamo. El comportamiento puede ser modificado si se usan palabras claves de parametros para el metodo en la declaración del parametro.

A continuación se enlistarán las palabras clave que se puede usar para declarar parámetros de métodos:

    - params especifica que este parámetro puede tomar un número variable de argumentos.
    - in especifica que este parámetro se pasa por referencia, pero solo se lee mediante el método llamado.
    - ref especifica que este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.
    - out especifica que este parámetro se pasa por referencia y se escribe mediante el método llamado.
    
### Params 

Usando la palabra clave _Params_, se puede especificar un parametro un numero variable de metodos en los argumentos.
Tambien puede enviar una lista separada por comas de del tipo especificado de argumentos en las declaraciones de parametros, ademas de que puede no enviar ningún argumento. Si no envía ningún argumento, la longitud de la lista params es cero.

No se pueden poner parametros extras una vez utilizada la palabra clave, y solo se puede usar una sola vez la palabra 
Params en la declaracion del método.

El tipo declarado del parámetro params debe ser una matriz unidimensional. En caso contrario, se produce un error del compilador CS0225.

A continuación se mostrara un ejemplo de varias maneras de enviar argumentos a un parametro:

        public class MyClass
        {
            public static void UseParams(params int[] list)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
            }

            public static void UseParams2(params object[] list)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
            }

            static void Main()
            {
                // You can send a comma-separated list of arguments of the 
                // specified type.
                UseParams(1, 2, 3, 4);
                UseParams2(1, 'a', "test");

                // A params parameter accepts zero or more arguments.
                // The following calling statement displays only a blank line.
                UseParams2();

                // An array argument can be passed, as long as the array
                // type matches the parameter type of the method being called.
                int[] myIntArray = { 5, 6, 7, 8, 9 };
                UseParams(myIntArray);

                object[] myObjArray = { 2, 'b', "test", "again" };
                UseParams2(myObjArray);

                // The following call causes a compiler error because the object
                // array cannot be converted into an integer array.
                //UseParams(myObjArray);

                // The following call does not cause an error, but the entire 
                // integer array becomes the first element of the params array.
                UseParams2(myIntArray);
            }
        }
        /*
        Output:
            1 2 3 4
            1 a test
           
            5 6 7 8 9
            2 b test again
            System.Int32[]
        */
        
### Out

Esta palabra clave se puede usar para dos cosas:

La primera, modificador de parametro, en la cual se puede pasar un argumento a un metodo por medio deuna referencia en vez de mediante un valor.

La segunda, declaraciones de parametro de tipo generico, esta especifica que un parametro es de tipo covariante.

### Ref

La palabra clave ref indica un valor que se ha pasado mediante referencia. Se puede usar en cuatro situaciones diferentes:

    - En una firma del método y en una llamada al método, esta pasa un argumento al metodo por medio de una referencia.
    - En una firma del método, para poder regresar un valor al autor de quien alla hecho la llamada por medio de una refe
    -En un cuerpo de miembro, para saber que un valor de regreso de referencia se almacena de forma local como una referencia que el            autor de la llamada piense en modificar o, en general, que una variable local pueda acceder a otro valor por referencia.
    - En una declaración struct para declarar ref struct o ref readonly struct.

Cuando se usa en una lista de parámetros del método, la palabra clave ref indica que un argumento se ha pasado mediante referencia, no por valor.

Para usar un parámetro ref, la definición de método y el método de llamada deben utilizar explícitamente la palabra clave ref.

Un argumento que se pasa a un parámetro ref o in debe inicializarse antes de pasarlo. En esto difiere de los parámetros out, cuyos argumentos no tienen que inicializarse explícitamente antes de pasarlos.

La incorporación del modificador ref a una declaración struct define que las instancias de ese tipo se deben asignar a la pila. En otras palabras, las instancias de estos tipos no se pueden crear nunca en el montón como un miembro de otra clase.

## 2.5 Constructores y destructores: declaración, uso y aplicaciones

### Utilizar constructores

Los constructores son métodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado. Los constructores tienen el mismo nombre que la clase y, normalmente, inicializan los miembros de datos del nuevo objeto. 

Un constructor que no toma ningún parámetro se denomina constructor predeterminado. Los constructores predeterminados se invocan cada vez que se crea una instancia de un objeto mediante el operador new y no se proporciona ningún argumento a new.

Los constructores se pueden marcar como public, private, protected, internal o protectedinternal. Estos modificadores de acceso definen cómo los usuarios de la clase pueden construir la clase. 

## 2.6 Sobrecarga de métodos

Ver el ejercicio siguiente

## 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios

Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.

Debe de tener por lo menos las siguientes propiedades:

 - valor
 - color
 
La clase debe contar por lo menos con

 - Dos constructores sobrecargados
 - Los operadores ==, <, > sobrecargados
 - El uso de la palabra clave this
