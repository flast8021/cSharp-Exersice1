using System;
namespace exersice1
{
    //------------------------------------------------------------
    //Title:-- UsmanZia24087_Exerseice#1
    //Description:--This Programe contains all 3 Solutions of Questions asked in Exersice#1.
    //------------------------------------------------------------//

    class Program
    {
        static void Main(string[] args)
        {
            //Calling Q#1 of Exersice#1
            calculator calc = new calculator();
            calc.simpleCalculator();

            //Calling Q#2 of Exersice#1
            carpetingPrice carpet = new carpetingPrice();
            carpet.Carpeting_Price();

            //Calling Q#3 of Exersice#1
            minutesToHours timeCalc = new minutesToHours();
            timeCalc.minToHour();
        }
    }
}
