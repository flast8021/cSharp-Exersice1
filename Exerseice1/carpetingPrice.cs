using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice1
{/*
 *Write a program that asks the user for the length and width of their room. Define a constant
 * that represents the price of carpeting per square foot. Compute and display the cost of carpeting the room.
 */
    public class carpetingPrice
    {
        public void Carpeting_Price() 
        {
            Console.WriteLine("Exersice#1\tQuestion#2\nRoom Carpeting Programme");
            //Getting user data.
            Console.WriteLine("Please enter length of your room:");
            double length = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter width of your room:");
            double width = double.Parse(Console.ReadLine());
            //formulas to perform calculation
            const double price = 5;
            double area = length * width;
            double carpetingCost = price * area;

            //To get 2 decimal place price using toString format.
            string decimalString = carpetingCost.ToString("#.##");

            //printing the results.
            Console.WriteLine($"Your input is as follows,\nLength: {length}\nWidth: {width}\nArea: {area}\n----------------------\nPrice: {decimalString}\n----------------------");
            Console.WriteLine("------------------End----------------------");
        }
    }
}
