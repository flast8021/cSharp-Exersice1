using System;

namespace exersice3
{
    public class Program
    {
        //------------------------------------------------------------
        //Title:-- UsmanZia24087_Exerseice#3
        //Description:--This Programe contains all 3 Solutions of Questions asked in Exersice#3.
        //------------------------------------------------------------//
        static void Main(string[] args)
        {
            //Calling Q#2 of Exersice#3
            hourly_pay payRate = new hourly_pay();
            payRate.pay();

            //Calling Q#2 of Exersice#3
            intSum addition = new intSum();
            addition.add();

            //Calling Q#3 of Exersice#3
            userRandonNumerGuess rand = new userRandonNumerGuess();
            rand.randomNumberGame();
        }
    }
}
