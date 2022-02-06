using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2
{
    /*
    Write a program that generates a random number between 1 and 10. Ask a user to guess the
    random number, then display the random number and a message indicating whether the user's
    guess was too high, too low, or correct.
    */
    public class randonNumberGuess
    {
        public void randomNumberGame()
        {
           Console.WriteLine("Exersice#2\tQuestion#3\nRandom Number Guess.");
            //importing Random
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            //printing and getting user input.
            Console.WriteLine("Guess a number b/w 1 and 10:");
            int userInput = int.Parse(Console.ReadLine());

            //conditions to match user input with randomly generated number.
            if (userInput == randomNumber)
            {
                Console.WriteLine($"You'r guess is correct.\nRandom number was {randomNumber}");
            }
            else if (userInput > randomNumber)
            {
                Console.WriteLine($"You'r guess was too high.\nRandom number was {randomNumber}");
            }
            else if (userInput < randomNumber)
            {
                Console.WriteLine($"You'r guess was too low.\nRandom number was {randomNumber}");
            }
            Console.WriteLine("------------------End----------------------");
        }//End of Method.
    }
}
