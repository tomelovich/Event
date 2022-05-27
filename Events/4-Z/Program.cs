using System;

namespace _4_Z
{
    class MyClass
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 34)
                {
                    onCount();
                }
            }
        }
    }
    class Handler_I
    {
        public void Message()
        {
            Console.WriteLine("i = 34!");
        }
    }
    class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("Переменная i >33, но <35");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Counter = new MyClass();
            Handler_I Handler1 = new Handler_I();
            Handler_II Handler2 = new Handler_II();
            //тут был обработчик события Handler_II
            Counter.onCount += Handler2.Message;
            Counter.Count();
        }
    }
}
