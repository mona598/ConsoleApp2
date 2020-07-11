using System;
using System.Security.Cryptography.X509Certificates;

namespace TestingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Employee
    {
        public int n1, n2;
        public int Add()
        {
            return n1 + n2;
        }
        public int Subtract()
        {
            return n1 - n2;
        }
        //write a function ADD(N1,N2) 
        //that adds 2 nos. which are passed as arguments & return the result
        //if any of the input number is less than zero , then return 0 as result
        public int ADD(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
                return 0;
            else
                return n1 + n2;
        }

        //write a func that takes a number as input & increments/changes its value
        public void ChangeX(ref int x)
        {
            x = x + 0;
        }
    }

    //Write a function that takes a number as input & modify its value
    //create a class student with the following 

    public class Student
    {
        public int stid, age;
        public string name;
        public void GetData()
        {
            //Console.WriteLine("Enter the id,name,age:");
            //stid = int.Parse(Console.ReadLine());
            //name = Console.ReadLine();
            //age = int.Parse(Console.ReadLine());

            stid = 10;
            name = "Monali";
            age = 22;
        }
    }
    
}
