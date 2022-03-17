using System;

namespace ConsoleApp02
{
    class Program
    {
        static void metA()
        {
            Console.WriteLine("AAA");
        }


        static void Main(string[] args)
        {
            metA();
            metB();
            metB();
            Console.WriteLine("Hello World!");
            metB();
        }


        static void metB()
        {
            Console.WriteLine("BBB");
        }
    }
}
