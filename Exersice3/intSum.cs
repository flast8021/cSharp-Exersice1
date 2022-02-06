using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice3
{
    /* Write a console-based application that sums the integers from 1 to 50.*/
    public class intSum
    {
        //global variables
        private int firstNum;
        private int secondNum;
        //constructors
        public intSum()
        {
            this.firstNum = _firstNum;
            this.secondNum = _secondNum;
        }
        //getter and setter
        public int _firstNum { get; set; }
        public int _secondNum { get; set; }

        //start of add method
        public void add()
        {
//First Input:
            //printing and asking for 1st number input
            Console.WriteLine("Please Enter first number:");
            _firstNum = int.Parse(Console.ReadLine());
            //looping on wrong entry
            do
            { 
                //conditions to verify input
                if (_firstNum > 0 && _firstNum <= 50)
                {
                    this.firstNum = _firstNum;
                    //breaking the loop on correct entry.
                    break;
                }
                else if (_firstNum <= 0 || _firstNum > 50)
                {
                    //printing and getting input again on wrong entry
                    Console.WriteLine("***Error! Please Enter b/w 1 and 50***\nPlease Enter first number again:");
                    _firstNum = int.Parse(Console.ReadLine());
                    //assigning it to global variable
                    this.firstNum = _firstNum;
                }
            } while (_firstNum <= 0 || _firstNum > 50);
//Second Input:
            //printing and asking for 2nd number input from user
            Console.WriteLine("Please Enter second number:");
            _secondNum = int.Parse(Console.ReadLine());
            //looping on wrong entry
            do
            {
                //conditions to verify input
                if (_secondNum > 0 && _secondNum <= 50)
                {
                    this.secondNum = _secondNum;
                    //breaking the loop on correct entry.
                    break;
                }
                else if (_secondNum <= 0 || _secondNum > 50)
                {
                    //printing and getting input again on wrong entry
                    Console.WriteLine("***Error! Please Enter b/w 1 and 50***\nPlease Enter second number again:");
                    _secondNum = int.Parse(Console.ReadLine());
                    //assigning it to global variable
                    this.secondNum = _secondNum;
                }
            } while (_secondNum <= 0 || _secondNum >50);

            //assigning 1st and 2nd input into variable
            int sum = firstNum + secondNum;
            
            //printing the sum
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine("------------------End----------------------");
        }//end of add method
    }
}
