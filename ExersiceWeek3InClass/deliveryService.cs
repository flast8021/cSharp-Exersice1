using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3inClass
{
    public class deliveryService
    {
        /*Write a program for a package delivery service. The program contains an array that holds the
        ten zip codes to which the company delivers packages. Prompt a user to enter a zip code and
        display a message indicating whether the zip code is one to which the company delivers*/
        
        //Start of method
        public void data()
        {
            //printing and getting user input regarding Zip Code.
            Console.WriteLine("Please enter Zip Code to get package details:");
            string input = Console.ReadLine();
            //bool variable for zip Entry.
            bool zipEntry = false;
            //array to add zip codes.
            string[] zipCodes = {"A001","A002","A003","A004","A005","A006","A007","A008","A009","A010"};
            //looping through array to see a matching zipCode.
            for (int i = 0; i < zipCodes.Length && !zipEntry; ++i)    
            {
                //condition if user input matches with zipCodes in array.
                if (input == zipCodes[i])
                {
                    //printing what user input and breaking loop on matching zip Code.
                    Console.WriteLine($"Zip Code: {input}, accepted. Package not dispatched yet.");
                    zipEntry = true;
                    break;
                }
            }//end of for loop
            //Condition if user inputted zid code doesn't match at all in loop.
            if(!zipEntry)
            {
                Console.WriteLine($"Sorry! {input} Not found...");
                return;
            }//end of condition.
        }
    }
}
