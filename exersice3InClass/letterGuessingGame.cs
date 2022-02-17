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
        public void userGuess()
        {
            var random = new Random();
            var list =new List<string> {"Console","Germany","Continent","Zoom","Switch","Reduce","Hangman","Grade" };
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);

            char[] alphabets = "abcdefghijklmnopqrstuvwxyz".ToArray();
            
        
        }
    }
}
