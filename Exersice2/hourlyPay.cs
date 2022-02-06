using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2
{
    public class hourlyPay
    {
        /*Write a program that prompts the user for an hourly pay rate.If the value entered is less than $7.50
        or greater than $49.00, display an error message, otherwise display a message indicating that the
        rate is okay
        */
        public void hourly_Pay()
        {
            Console.WriteLine("Exersice#2\tQuestion#1\nWelcome to Hourly Pay prompt Console.");
            double payRate;
            //looping in case of wrong Entry
            do
            {
                //printing and getting user input
                Console.WriteLine("Please Enter your hourly Pay Rate: ");
                payRate = double.Parse(Console.ReadLine());

                //condition to get user prompted on wrong entry
                if (payRate < 7.50 || payRate > 49.00)
                {
                    Console.WriteLine("***Sorry! There was a problem with input.***");
                }
                //condition to get user prompted on correct entry
                else if (payRate > 7.50 || payRate < 49.00)
                {
                    Console.WriteLine($"The pay rate: {payRate} is ok.");
                }
                //while user input >7.50 & < 49.00 it will exit the loop.
            } while (payRate < 7.50 || payRate > 49.00);            
            
            //on exit, considering correct Entry.
           // Console.WriteLine("Correct Entry.");
            Console.WriteLine("------------------End----------------------");
        }
    }
}
