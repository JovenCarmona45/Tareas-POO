using System;
using System.Collections.Generic;

namespace Consola_12
{
    class Frac
    {
        private int Num;
        private int Dem;

        public Frac (int Num, int Dem)
        {
            this.Num = Num; this.Dem = Dem;
        }
        public Frac()
        {
            Num = 1;
            Dem = 1;
        }

        public static Frac operator + (Frac X, Frac Y)
        {
            return new Frac(X.Num * Y.Dem + X.Dem * Y.Num, X.Dem * Y.Dem);
        }
        public static Frac operator - (Frac X, Frac Y)
        {
            return new Frac(X.Num * Y.Dem - X.Dem * Y.Num, X.Dem * Y.Dem);
        }
        public static Frac operator * (Frac X, Frac Y)
        {
            return new Frac(X.Num * Y.Num, X.Dem * Y.Dem);
        }
        public static Frac operator /(Frac X, Frac Y)
        {
            return new Frac(X.Num * Y.Dem, X.Dem * Y.Num);
        }

        public void Imprime()
        {
            Console.WriteLine("------------\n" + "{0}/{1}\n" + "------------\n", Num, Dem);
        }

        public decimal A_decimal()
        {
            return Num / Dem;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Frac a = new Frac(1, 2);
            Frac b = new Frac(1, 3);
            Frac c = a + b;
            Frac d = a - b;
            Frac e = a * b;
            Frac f = a / b;
            a.Imprime();
            b.Imprime();
            Console.WriteLine("Suma");
            c.Imprime();
            Console.WriteLine("Resta");
            d.Imprime();
            Console.WriteLine("Multiplicación");
            e.Imprime();
            Console.WriteLine("Division");
            f.Imprime();
            Console.ReadKey();
        }
    }
}
