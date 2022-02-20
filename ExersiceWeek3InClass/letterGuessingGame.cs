using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3inClass
{
    /*
    Create a game like Hangman in which a player guesses letters to try to replicate a hidden
    word. Store at least eight words in an array, and randomly select one to be the hidden word.
    Initially, display the hidden word using asterisks to represent each letter. Allow the user to
    guess letters to replace the asterisks in the hidden word until the user completes the entire
    word. If the user guesses a letter that is not in the hidden word, display an appropriate
    message. If the user guesses a letter that appears multiple times in the hidden word, make
    sure that each correct letter is placed.
    */
    public class letterGuessingGame
    {
        public letterGuessingGame()
        {
            
        }
        //start of method
        public void userGuess()
        {
            //Calling random method
            var random = new Random();
            //creating list of hidden and non hidden words.
            var list =new List<string> {"console","germany","continent","guidance","switch","reduce","hangman","scarsm" };
            var hiddenList =new List<string> {"c*n*ol*","*er*any","co*t*ne*t","gui*a*ce","s*itch","reduce","*angm*n","sc*r*m" };
            
            var userInput="";
            //generating random
            int hiddenRandomIndex = random.Next(hiddenList.Count);
            //loop to repeat user input on wrong entry
            do
            {
                //printing and asking user to guess correct word.
                Console.WriteLine($"Guess the word: {hiddenList[hiddenRandomIndex]}");
                Console.WriteLine("------------------------------");
                Console.Write("Your Guess: ");
                userInput = Console.ReadLine();
                //condition to check if user input is avaliale on our correct words list
                if (list.Contains(userInput))//on correct entry
                {
                    Console.WriteLine("Correct word.");
                    Console.WriteLine(userInput);
                }
                else//on wrong entry
                {
                    Console.WriteLine("Sorry Try Again");
                }
                
            } while (!(list.Contains(userInput)));//repeating on wrong entry.
        //end of loop
        }//end of method
    }
}
