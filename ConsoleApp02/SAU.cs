using System;


namespace ConsoleApp02
{
    class SAU
    {   
        //field
        public int a = 99;
        public string b = "hi";
        private int score = 0;

        //สร้าง Property ของ score
        public int Score
        {
            get{ return score; }
            set{ score = value; }

        }

        //constructor
        public SAU(){
            Console.WriteLine("ComSci");
        } 
        //method
        public void show1()
        {
            Console.WriteLine(111);
        }
        //method
        public int show2(int x)
        {
            return x * 10;
        }
    }
}
