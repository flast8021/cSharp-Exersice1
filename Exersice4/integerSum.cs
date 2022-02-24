using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice4
{
    /*Create a method named Sum() that accepts any number of integer parameters and displays
    their sum. Write a Main() method that demonstrates the Sum() method works correctly
    when passed one, three, or five integers, or an array of ten integers*/
    public class integerSum
    {
        //constructrs
        public integerSum()
        {

        }
        public integerSum(int _intEntry)
        {
            intEntry = _intEntry;
        }
        //getters and setters
        public int intEntry { get; set; }
        //creating list to add numbers in collection.
        public List<integerSum> numberList = new List<integerSum>();
        //start of sum method.
        public void Sum()
        {
            //printing and getting user input about total entries.
            Console.WriteLine("Please enter number of integers you wish to add: ");
            int n = int.Parse(Console.ReadLine());
            int input=0;
            int sum=0;
        //start of for loop.
            for (int i = 1; i <= n ; i++)
            {
                //printing and getting user inputs.
                Console.WriteLine($"Please Enter your {i} integer: ");
                input = int.Parse(Console.ReadLine());
                //adding inputs to variable sum.
                sum += input;
                //adding user inputs into the list.
                numberList.Add(new integerSum(input){} );
            }//end of for loop.
            //printing total sum.
            Console.WriteLine($"Total Sum: {sum}.");
        }//end of sum method.
    }
}