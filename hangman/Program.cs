using System.Text;

namespace hangman
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int nbrLives = 3; //how much hp

            string secretWord = "gamedev"; //win condition

            StringBuilder displayWord = new StringBuilder(); //create the stringbuilder

            for (int i = 0; i < secretWord.Length; i++) //create the underscores that will be shown
            {
                displayWord.Append('_');
            }
            Console.WriteLine("nbr of lives:" + nbrLives.ToString()); //show how many lives you have
            

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
                Console.WriteLine("Correct? " + correct);

                if (correct == true)
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord[i] == guessedLetter)
                            displayWord[i] = guessedLetter;
                    }
                }
                else
                {
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
                //break;
            }

            Console.WriteLine("Bye");
        }
    }
}
