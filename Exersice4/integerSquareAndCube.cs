using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice4
{
    /*Create a console-based program whose Main() method prompts the user for an integer
    value and, in turn, passes the value to a method that squares the number and to a method
    that cubes the number. The Cube() method should call the Square() method. The Main()
    method displays the results returned from each of the other methods*/
    public class integerSquareAndCube
    {
        //global variables.
        private int input;
        private int square;
        private int cube;
        //constructors
        public integerSquareAndCube()
        {
            this.input = _input;
        }
        //getters and setters
        public int _input { get; set; }
        //start of square method.
        public int squareNumber()
        {
            square = _input * _input;
            return square;
        }//end of square method.
        //start of cube method.
        public int cubeNumber()
        {
            //calling square method to use square variable.
            squareNumber();
            cube = square * _input;
            return cube;
        }//end of cube method.
        //start of display method.
        public void display()
        {
            //calling square() and cube() to output results.
            squareNumber();
            cubeNumber();
            Console.WriteLine($"Square of {_input} is: {square}");            
            Console.WriteLine($"Cube of {_input} is: {cube}");
        }//end of display method.
    }
}
