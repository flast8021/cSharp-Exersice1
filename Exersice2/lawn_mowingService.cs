using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2
{
    public class lawn_mowingService
    {
        /*Write a program for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly
        fee for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more,
        but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is $50
        per week. Prompt the user for the length and width of a lawn, and then display the weekly mowing
        fee, as well as the total fee for the 20-week season.
        */
        public void lawnService()
        {
            
            Console.WriteLine("Exersice#2\tQuestion#2\nLawn Mowing Service");
        onWrongentry:
            //Getting user data.
            Console.WriteLine("Please enter length of your Garden:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter width of your Garden:");
            double width = double.Parse(Console.ReadLine());

            //formulas to perform calculation
            double area = length * width;
            
            //variables
            double pricePerWeek ;
            double twentyWeekPrice ;
            string decimalPricePerWeek;
            string decimaltwentyWeekPrice;
                //conditions According to Requirments
                if (area > 0 && area < 400.0)
                {
                    //In normal format
                    pricePerWeek = 25.00;
                    twentyWeekPrice = pricePerWeek * 20;
                    //In 2 decimal format.
                    decimalPricePerWeek = pricePerWeek.ToString("#.##");
                    decimaltwentyWeekPrice = twentyWeekPrice.ToString("#.##");
                    //printing Charges for service.
                    Console.WriteLine($"Cost of Lawn Mowing Service for given area: {area} will be as follows,");
                    Console.WriteLine($"Weekly Charges: {decimalPricePerWeek}\n20 Weeks Charges: {decimaltwentyWeekPrice}");
                }
                else if (area >= 400.0 && area < 600.0)
                {
                    pricePerWeek = 35.00;
                    twentyWeekPrice = pricePerWeek * 20;
                    //In 2 decimal format.
                    decimalPricePerWeek = pricePerWeek.ToString("#.##");
                    decimaltwentyWeekPrice = twentyWeekPrice.ToString("#.##");
                    //printing Charges for service.
                    Console.WriteLine($"Cost of Lawn Mowing Service for given area: {area} will be as follows,");
                    Console.WriteLine($"Weekly Charges: {decimalPricePerWeek}\n20 Weeks Charges: {decimaltwentyWeekPrice}");
                }
                else if (area >= 600.0)
                {
                    pricePerWeek = 50.00;
                    twentyWeekPrice = pricePerWeek * 20;
                    //In 2 decimal format.
                    decimalPricePerWeek = pricePerWeek.ToString("#.##");
                    decimaltwentyWeekPrice = twentyWeekPrice.ToString("#.##");
                    //printing Charges for service.
                    Console.WriteLine($"Cost of Lawn Mowing Service for given area: {area} will be as follows,");
                    Console.WriteLine($"Weekly Charges: {decimalPricePerWeek}\n20 Weeks Charges: {decimaltwentyWeekPrice}");
                }
                else if(area <= 0 || length <= 0 || width <= 0)
                {
                    pricePerWeek = 0;
                    twentyWeekPrice = 0;
                    Console.WriteLine("Sorry! Area/Lenght should not be \"0\"");
                    goto onWrongentry;
                }
            Console.WriteLine("------------------End----------------------");
        }
    }
}