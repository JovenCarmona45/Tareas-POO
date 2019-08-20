	// Ejemplo_11_03a.cs
	// Ejemplo de clase "Queue" (Cola)
	// Introducción a C#, por Nacho Cabanes

	using System;
	using System.Collections;

	public class Ejemplo_11_03a
	{
	    public static void Main()
	    {
		string palabra;

		Queue miCola = new Queue();
		miCola.Enqueue(" Hola");
		miCola.Enqueue("soy");
		miCola.Enqueue("yo");

		for (byte i = 0; i < 3; i++)
		{
		    palabra = (string)miCola.Dequeue();
		    Console.WriteLine(palabra);
		    Console.ReadKey();
		}
	    }
	}
