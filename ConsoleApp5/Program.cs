using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Class;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            Console.WriteLine("Welcome! Please enter your name : ");
            myCalculator.UserName = Console.ReadLine();
            var myMessage = myCalculator.Greeting();
            Console.WriteLine(myMessage);
            Console.ReadLine();
            Console.WriteLine("Please input the first number:");
            myCalculator.FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number:");
            myCalculator.SecondNumber = Convert.ToInt32(Console.ReadLine());
            var addition = myCalculator.Addiation();
            Console.WriteLine(addition);
            Console.ReadLine();
            Console.WriteLine("Please input the first number:");
            myCalculator.FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number:");
            myCalculator.SecondNumber = Convert.ToInt32(Console.ReadLine());
            var subtraction = myCalculator.Subtraction();
            Console.WriteLine(subtraction);
            Console.ReadLine();
            Console.WriteLine("Please input the first number:");
            myCalculator.FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number:");
            myCalculator.SecondNumber = Convert.ToInt32(Console.ReadLine());
            var multiplation = myCalculator.Multiplation();
            Console.WriteLine(multiplation);
            Console.ReadLine();
            Console.WriteLine("Please input the first number:");
            myCalculator.FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number:");
            myCalculator.SecondNumber = Convert.ToInt32(Console.ReadLine());
            var dividation = myCalculator.Dividation();
            Console.WriteLine(dividation);
            Console.ReadLine();
        }
    }
}
