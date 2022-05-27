using System;

namespace _2_Z
{
    class Program
    {
        delegate double Operation(double x, double y);
        static void DoOperation(double a, double b, Operation op)
        {
            Console.WriteLine(op(a, b));
        }
        static double Division(double x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введиет x и y:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            try
            {
                DoOperation(x, y, Division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
            }
        }
    }
}
