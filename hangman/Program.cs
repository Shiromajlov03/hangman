using System.Security.Cryptography;
using System.Text;

namespace hangman
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int nbrLives = 5; //how much hp

            //wordlist
            string [] ordLista = { "game", "gamedesign", "laptop", "videogame", "hangman", "pizza", "pasta", "lasagna", "gamedev", "algorithm", "argument", "arrays", "arithmetic", "operators", "assignment", "augmented", "autonomus", "binary", "bit", "camelcase", "coding", "program", "if", "else", "forloops", "function", "increment", "decrement", "input", "java", "library", "main", "machine", "micro", "neural", "neuron", "monkey", "banana",  };
            Random slump = new Random();

            string secretWord = ordLista[slump.Next (0,ordLista.Length)]; //win condition

            StringBuilder displayWord = new StringBuilder(); //create the stringbuilder
            

            for (int i = 0; i < secretWord.Length; i++) //create the underscores that will be shown
            {
                displayWord.Append('_');
            }
            Console.WriteLine("HANGMAN");
            Console.WriteLine("Lives:" + nbrLives.ToString()); //show how many lives you have
            
            //if not dead game plays
            while (nbrLives > 0)
            {
                Console.WriteLine(nbrLives.ToString());
                Console.WriteLine(displayWord);

                string guessedWord = Console.ReadLine();
                Console.WriteLine("Guessed Word: " + guessedWord);
                char guessedLetter = guessedWord[0];
               Console.WriteLine("Guessed Letter;"+ guessedLetter);

                bool correct = false;
                for (int i = 0; i < secretWord.Length; i++) 
                {
                if (secretWord[i] == guessedLetter)
                        correct = true;
                }
             

                if (correct == true)
                {
                    Console.WriteLine("Correct");
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord[i] == guessedLetter)
                            displayWord[i] = guessedLetter;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    nbrLives--;
                    if (nbrLives == 0)
                    {
                        Console.WriteLine("YOU DIED!");
                    }
                }
                if (displayWord.ToString() == secretWord)
                {
                    Console.WriteLine("VICTORY!!!!!!!!");
                    break;
                }
                
            }

            Console.WriteLine("Bye");
        }
    }
}
