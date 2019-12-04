using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApplication
{
    //make class calc public
    public class calc
    {

        //calc.cs contains equations for math( + , - , * , / )
        // ------------------------------------------------------------------------------



        //Addition
        public decimal Addition(decimal firstNumber, decimal secondNumber)
        {
            decimal solution;

            solution = firstNumber + secondNumber;

            return solution;
        }


        //Subtraction
        public decimal Subtraction(decimal firstNumber, decimal secondNumber)
        {
            decimal solution;

            solution = firstNumber - secondNumber;

            return solution;
        }


        //Multiplication
        public decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            decimal solution;

            solution = firstNumber * secondNumber;

            return solution;
        }


        //Division
        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            decimal solution;

            solution = firstNumber / secondNumber;

            return solution;
        }

    }
}
