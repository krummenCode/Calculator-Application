using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            //Declare or call calc.cs, name it (in this case "m"), use keyword new and use calc method
            calc m = new calc();


            //Welcome and enter first number
            Console.WriteLine("Welcome to my Calculator App! Please enter your first number...");
            //Take firstNumber from the console. (Must convert readline from string to decimal)
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());


            //Pick your opperation 
            Console.WriteLine("Pick an operation ( + , - , * , / )");
            //Take opperation
            string Operation = Console.ReadLine();
       

            //Enter Second Number
            Console.WriteLine("Enter Second Number");
            //Take secondNumber from console. (Must convert readline from string to decimal)
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());


            //Operation switch case
            switch (Operation)
            {
                case "+" :
                    Console.WriteLine("= " + m.Addition(firstNumber, secondNumber));
                    break;

                case "-":
                    Console.WriteLine("= " + m.Subtraction(firstNumber, secondNumber));
                    break;

                case "*":
                    Console.WriteLine("= " + m.Multiplication(firstNumber, secondNumber));
                    break;

                case "/":
                    Console.WriteLine("= " + m.Division(firstNumber, secondNumber));
                    break;

                default:
                    Console.WriteLine("You didn't enter a valid operation method");
                    break;
            }


            //Exit Program
            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey();
        }
    }
}
