using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Learning C# Language!");
            Console.WriteLine("I am Using CS");
            Console.WriteLine(3 + 3);
            String name = "John";
            Console.WriteLine(name);
           const int myNum = 50;
           double myNum1 = 40;
            Console.WriteLine(myNum);
            Console.WriteLine(myNum1);
            float price = 450.43F;
            Console.WriteLine(price);
            float syNum = 3.5e4F;
            double syNum2 = 5.3e6;
            Console.WriteLine(syNum);
            Console.WriteLine(syNum2);
            string greeting = "Hello World";
            Console.WriteLine(greeting);
            char myCar = 'M';
            Console.WriteLine(myCar);

            double myDouble = 9.78;
            int myint = (int) myDouble;
            Console.WriteLine(myint);

            Console.WriteLine("Enter userName");
            string userName = Console.ReadLine();
            Console.WriteLine("UserName is: " + userName);

            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is: " + age);
        }
    }
}
