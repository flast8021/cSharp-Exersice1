using System;

namespace exersice2
{
    class Program
    {
        //------------------------------------------------------------
        //Title:-- UsmanZia24087_Exerseice#2
        //Description:--This Programe contains all 3 Solutions of Questions asked in Exersice#2.
        //------------------------------------------------------------//
        static void Main(string[] args)
        {
            //Calling Q#1 of Exersice#2
            hourlyPay pay = new hourlyPay();
            pay.hourly_Pay();
            
            //Calling Q#1 of Exersice#2
            lawn_mowingService lawn = new lawn_mowingService();
            lawn.lawnService();

            //Calling Q#3 of Exersice#2
            randonNumberGuess rand = new randonNumberGuess();
            rand.randomNumberGame();
        }
    }
}
