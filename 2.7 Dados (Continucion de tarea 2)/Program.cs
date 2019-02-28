using System;
using System.Collections.Generic;

namespace Dados
{
    class Dados
    {
        // Aqui intente poner el random y todo bien | Random random = new Random();
        private int valor; 
        private string color;
        

        public Dados(string color, int valor)
        {
            this.valor = valor;
            this.color = color;
        }

        public Dados()
        {
            // Despues aqui le puse Valor = random.Next(1,6); | Ya que como son dados, y aparentemente bien 
            valor = 1;
        }

        public void Imprimeresultado()
        {
            Console.WriteLine("Dado ganador \n-Color: {0}\n-Valor: {1}\n" +
            "-----------------------", color, valor);
        }
        // Con esto se soluciona un error de linea 6 que aparece en verde
        public override bool Equals(object obj)
        {
            var dados = obj as Dados;
            return dados != null &&
                   valor == dados.valor &&
                   color == dados.color;
        }
        // Con esto se soluciona un error de linea 6 que aparece en verde
        public override int GetHashCode()
        {
            var hashCode = 2022781313;
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(color);
            return hashCode;
        }

        public static bool operator >(Dados X, Dados Y)
        {
            return (X.valor.CompareTo(Y.valor) > 0);
        }
        public static bool operator <(Dados X, Dados Y)
        {
            return (X.valor.CompareTo(Y.valor) < 0);
        }
        public static bool operator ==(Dados X, Dados Y)
        {
            return (X.valor.CompareTo(Y.valor) == 0);
        }
        public static bool operator !=(Dados X, Dados Y)
        {
            return (X.valor.CompareTo(Y.valor) != 0);
        }
    }
    class Program
    {
        static void Main()
        {
            // Cuando le ponia la variable en donde debe ir Valor, me dice que no existe en el contexto actual
            // Asi que lo deje con numeros estaticos, cualquier entero que ponga en los dados se compararan 
            // Y saldra el resultado
            Dados a = new Dados("Verde", 5);
            Dados b = new Dados("Amarillo", 5); 
            Dados c = new Dados("Rojo", 4);
            if (a == b && a == c)
            {
                Console.WriteLine("Los dados cayeron iguales");
            }
                else if (a > b && a > c)
                {
                    a.Imprimeresultado();
                }
                    else if (b > a && b > c)
                    {
                        b.Imprimeresultado();
                    }
                        else if (c > a && c > a)
                        {
                           c.Imprimeresultado();
                        }
                            else if (a == c && a > b)
                            {
                                a.Imprimeresultado();
                                c.Imprimeresultado();
                            }
                                else if (a == b && a > c)
                                {
                                       a.Imprimeresultado();
                                        b.Imprimeresultado();
                                }
                                    else if (b == c && b > a)
                                    {
                                        b.Imprimeresultado();
                                        c.Imprimeresultado();
                                    }
            Console.ReadKey();
        }

    }
}
