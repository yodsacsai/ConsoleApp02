using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{
    class Person
    {
        //Member 1 Field/Attribute/Data คือค่าข้อมูลของ class
        string id = "111";
        string name;
        int age;

        //Member 2 Method คือการทำงาน 
        void showWow()
        {
            Console.WriteLine("Wow Wow Wow");
        }

        void speak(string info)
        {
            Console.WriteLine("คุณคือ {0} : {1}", name, info);
        }

        static void Main(string[]args)
        {
            Person aa; //ประกาศชื่อออปเจ็กต์
            aa = new Person();//เอาชื่อออปเจ็กต์มาสร้างเป็นออปเจ็กต์
    
            Person bb = new Person();//ประกาศชื่อออปเจ็กต์ เอาชื่อออปเจ็กต์มาสร้างเป็นออปเจ็กต์

            aa.name = "Somchai";
            Console.WriteLine("Name is {0} and Age is {1}", aa.name, aa.age);

            bb.showWow();


        }

    }
}
