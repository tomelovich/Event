using System;

namespace _1_Z
{
    class Program
    {
        public delegate double Dels(double x);
        static double F(double x)
        {
            double f;
            if (x <= 3)
                f = 3 * x - 9;
            else
                f = 1 / (x * x - 4);
            Console.WriteLine(f);
            return f;
        }
        static double Z(double x)
        {
            double z;
            if (x >= 8)
                z = Math.Pow(x,3) - 9;
            else
                z = x - 4;
            Console.WriteLine(z);
            return z;
           
        }
        static double N(double x)
        {
            double n;
            if (x <= 5)
                n = x;
            else
                n = Math.Sqrt(x);
            Console.WriteLine(n);
            return n;
        }
        static void Main(string[] args)
        {           
            try
            {
                Console.WriteLine("Введите X: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Dels CF = new Dels(F);
                CF += Z;
                CF += N;
                CF(x);
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибка!");
            }        
        }
    }
}
