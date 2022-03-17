using System;


namespace ConsoleApp02
{
    class Test2
    {

        //Overloading Method คือ ชื่อเดียวกัน แต่พารามิตเตอร์ต้องไม่เหมือนกัน
        //ไม่เหมือนกันคือ จำนวนพารามิเตอร์ต้องไม่เท่ากัน หรือชนิดของพารามิเตอร์ต้องไม่เหมือนกัน
        static void MetA()
        {

        }

        static void MetA(int x)
        {

        }

        static void MetA(double x)
        {

        }

        static void MetA(double x, double y)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test2");
        }
    }
}
