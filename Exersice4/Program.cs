using System;

namespace exersice4
{
    class Program
    {
        static void Main(string[] args)
        {
//Answer #1
            Console.WriteLine("-----Answer# 1-----");
            // Creating an instance of integerMultiplicationTable class.
            integerMultiplicationTable intMultiply = new integerMultiplicationTable();

            Console.WriteLine("Input an integer to get answer of inputted number multiplied from 2 through 10:");
            //getting user input & Calling MultiplicationTable() method to display the appropriate results.
            intMultiply.input = int.Parse(Console.ReadLine());
            intMultiply.MultiplicationTable();
            Console.WriteLine("-----End of Answer# 1-----");

//Answer #2
            Console.WriteLine("-----Answer# 2-----");
            // Creating an instance of integerSquareAndCube class.
            integerSquareAndCube squareNdCude = new integerSquareAndCube();
            Console.WriteLine("Input an integer to get square & cube: ");
            squareNdCude._input = int.Parse(Console.ReadLine());
            Console.WriteLine(squareNdCude._input);
            squareNdCude.display();
            Console.WriteLine("-----End of Answer# 2-----");

//Answer #3
            Console.WriteLine("-----Answer# 3-----");
            // Creating an instance of integerSum class.
            integerSum addition = new integerSum();
            //calling sum method.
            addition.Sum();
            Console.WriteLine("-----End of Answer# 3-----");
        }
    }
}
