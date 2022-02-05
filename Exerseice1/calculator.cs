using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice1
{ 
/*
     * Build a simple calculator. 
     * Read in two integers from the user 
     * and add them together. 
     * subtract
     * multiply
     * division(display quotient and remainder separately)
     * Print the results in a nice output statement.
     * 
     * 
     * */

    public class calculator
    {
    //Calculator method
        public void simpleCalculator()
        {
            Console.WriteLine("Exersice#1\tQuestion#1\nWelcome to Calculator.");

            Console.WriteLine("Please Enter First number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            int subtract = firstNumber - secondNumber;
            int multiply = firstNumber * secondNumber;
            int divide = firstNumber / secondNumber;
            int quotient = firstNumber % secondNumber;

            Console.WriteLine($"The result of you provided number are as:\nAddition: {sum}\nSubtraction: {subtract}\nMultiplication: {multiply}\nDivision: {divide}\nRemainder: {quotient}");
            Console.WriteLine("------------------End----------------------");
        }

    }
}
