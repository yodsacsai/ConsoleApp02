using System;


namespace ConsoleApp02
{
    class MainTest1
    {
        static void Main(string[] args)
        {
            SAU ob1 = new SAU();
            SAU ob2 = new SAU();

            ob1.show1();
            ob1.b = "hello";
            ob1.Score = 20;
            Console.WriteLine(ob1.Score);

        }

    }
}
