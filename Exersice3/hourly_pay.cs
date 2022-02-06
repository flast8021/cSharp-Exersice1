using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice3
{
    public class hourly_pay
    {
        /*Write a console-based application that prompts a user for an hourly pay rate. While the user
        enters values less than $5.65 or greater than $49.99, continue to prompt the user. Before the
        program ends, display the valid pay rate.
        */
        public void pay()
        {
            Console.WriteLine("Exersice#3\tQuestion#1\nWelcome to Hourly Pay prompt Console.");
            double payRate;
            //looping in case of wrong Entry
            do
            {
                //printing and getting user input
                Console.WriteLine("Please Enter your hourly Pay Rate: ");
                payRate = double.Parse(Console.ReadLine());

                //condition to get user prompted on wrong entry
                if (payRate < 5.65 || payRate > 49.99)
                {
                    Console.WriteLine("***Sorry! There was a problem with input.***");
                }
                //condition to get user prompted on correct entry
                else if (payRate > 5.65 || payRate < 49.99)
                {
                    Console.WriteLine($"Your pay rate is: {payRate}.");
                }
                //while user input >7.50 & < 49.00 it will exit the loop.
            } while (payRate < 5.65 || payRate > 49.99);

            //on exit, considering correct Entry.
            // Console.WriteLine("Correct Entry.");
             Console.WriteLine("------------------End----------------------");
        }
    }
}
