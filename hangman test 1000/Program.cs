using System;
using System.Collections.Generic;

namespace hangman_test_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsList = new()
            {
                "hello",
                "football",
                "england",
                "bitcoin",
                "bodybuilding",
                "cameron"
            };

            Console.WriteLine("\t\t\t Welcome to my Hangman game, Good luck!");

            //activating my random word
            Random rng = new();

            int rndWordIndex = rng.Next(0, wordsList.Count);   //warning! magic number ?!?!
            string guess = "";
            int guessCount = 0;

            char[] currentWord = wordsList[rndWordIndex].ToCharArray();

            char[] displayWord = new char[currentWord.Length];
            int lives = currentWord.Length + 2;

            Console.WriteLine("guess for a {0} letter word", currentWord.Length);
            Console.WriteLine("you have {0} lives", lives);
            bool correctLetter = true;

            for (int i = 0; i < currentWord.Length; i++)
            { //hides my word
                displayWord[i] = '*';
            }
            while (lives > 0) // while lives are more than 0, the code in these brackets will execute
            {

                Console.WriteLine(" Guess a letter");
                Console.WriteLine(displayWord); // displays my hidden word.
                char letterGuessed = char.Parse(Console.ReadLine());// checks to see if letter is in the array.
                for (int i = 0; i < currentWord.Length; i++)

                    if (letterGuessed == currentWord[i])
                        if (correctLetter)
                        {
                            //Console.WriteLine(displayWord[i]);
                            displayWord[i] = letterGuessed;     //if the guess is correct, set the character for the final output
                            Console.WriteLine("That is a correct guess");

                        }else
                        {
                            Console.WriteLine("Sorry that guess was incorrect");
                        }Console.WriteLine(displayWord);
            }

        }
    }

}




