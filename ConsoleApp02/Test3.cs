using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{
    class Test3
    {

        static void metA()
        {
            Console.WriteLine("AAA");
        }

        void metB()
        {
            Console.WriteLine("BBB");
        }

        void metC()
        {
            metA();
            metB();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Test3");
            metA();
            //metB(); error เพราะ static ไม่สามารถเรียกที่ไม่ใช่ static ได้
        }
    }
}
