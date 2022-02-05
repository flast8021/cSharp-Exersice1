using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice1
{
    /*
    Write a program that asks the user to enter a total amount of time in minutes only.
    Print to the console the same amount of time in hours and minutes.*/
    public class minutesToHours
    {
        public void minToHour()
        {
            Console.WriteLine("Exersice#1\tQuestion#3\nwelcome to Minutes to Hour calculator");
            //grtting user input
            Console.WriteLine("Please Enter total amount of time in minutes:");
            int totalTime = int.Parse(Console.ReadLine());
            //variables to calculte time in hourly format
            int totalHours = totalTime / 60;
            int totalMins = totalTime % 60;
            //printing on console
            Console.WriteLine($"Time in hourly format is: {totalHours} hours and {totalMins} mins.");
            Console.WriteLine("------------------End----------------------");
        }
    }
}
