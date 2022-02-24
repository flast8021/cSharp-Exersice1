using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice4
{
    /*Create a console-based application whose Main() method asks the user to input an integer
    and then calls a method named MultiplicationTable(), which displays the results of
    multiplying the integer by each of the numbers 2 through 10*/
    public class integerMultiplicationTable
    {
        //global variable.
        public int input;
        //constructor
        public integerMultiplicationTable()
        {
            this.input = _input;
        }
        //getter and setter
        public int _input{ get; set; }
        //start of multiplication method
        public void MultiplicationTable()
        {
            //start of for loop
            for (int i = 2; i <= 10 ; i++)
            {
                //multiplying input by i(index) to get result
                int result = input* i;
                //printing in appropriate format.
                Console.WriteLine($"{input} * {i} = {result}");
            }//end of for loop
        }//end of multiplication method.
    }
}
