using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{
    class Test1
    {
        static void Met1()
        {
            Console.WriteLine("11111");
        }

        static void Met2(int x, double y)
        {
            Console.WriteLine("22222");
            Console.WriteLine("x is {0}/ y is {1}", x, y);
        }

        static int Met3()
        {
            Console.WriteLine("33333");
            return 999;
        }

        static double Met4(string z, double m, int x)
        {
            Console.WriteLine("44444");
            return m * 1.5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test1");
            Met1();
            Met2(10, 55.55);
            //Met3();//call method แบบนี้ได้ แต่ไม่มีใครเขาทำกัน
            Console.WriteLine(Met3() * 10);
            double z = Met3() + Met4("SAU", 10.5, 50);

        }
    }
}
