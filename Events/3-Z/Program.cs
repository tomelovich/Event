using System;

namespace _3_Z
{
    class MyInfo
    {
        public string name = "Александр";
        public delegate void MethodContainer();
        public event MethodContainer onCount;

        public void Count()
        {
            if (name != "Александр")
            {
                onCount();
            }
        }
    }
    class Handler_I
    {
        public void Message()
        {
            Console.WriteLine("Имя изменено!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInfo Counter = new MyInfo();
            Handler_I Handler1 = new Handler_I();
            Counter.name = "Антон";
            Counter.onCount += Handler1.Message;
            Counter.Count();
        }
    }
}
