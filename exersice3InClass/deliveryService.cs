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

        public void data()
        {
            Console.WriteLine("Please enter Zip Code to get package details:");
            string input = Console.ReadLine();

            bool zipEntry = false;
            
            string[] zipCodes = {"A001","A002","A003","A004","A005","A006","A007","A008","A009","A010"};

            for (int i = 0; i < zipCodes.Length && !zipEntry; ++i)    
            {
                if (input == zipCodes[i])
                {
                    Console.WriteLine($"Zip Code: {0}, accepted. Package not dispatched yet.");
                    zipEntry = true;
                    break;
                }
            }
            if(!zipEntry)
            {
                Console.WriteLine($"Sorry! {input} Not found...");
                //Console.ReadLine();
                return;
            }
        }
    }
}
