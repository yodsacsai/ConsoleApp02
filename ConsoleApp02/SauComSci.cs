using System;


namespace ConsoleApp02
{
    class SauComSci
    {
        private string stuName;
        private int stuAge;
        private double stuSalary;

        public string StuName
        {
            get { return stuName; }
            set{ stuName = value; }
        }

        public int StuAge
        {
            get { return stuAge; }
            set { stuAge = value; }
        }

        public double StuSalary
        {
            get { return stuSalary; }
            set { stuSalary = value; }
        }

        public SauComSci()
        {
            Console.WriteLine("Welcome to SAU");
        }

        public void register(string name)
        {
             Console.WriteLine("Hello {0}", name);
        }

    }
}
