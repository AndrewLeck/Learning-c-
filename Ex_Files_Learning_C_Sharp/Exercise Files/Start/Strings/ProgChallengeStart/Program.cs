using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool keepGoing = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guessNum = 0;
            int guessCount = 0;

            do{
                Console.WriteLine("What is your guess");

                string theGuess = Console.ReadLine();
                
                bool result = Int32.TryParse(theGuess, out guessNum);
            
                if(!result){
                    // If the user guesses somthing other than a number
                    Console.WriteLine("That doesnt look like a number? Please try again");
                }
                else{
                    // if the users types -1 and gives up 
                    if (guessNum == -1){
                        Console.WriteLine($" Better luck next time, the number was {theNumber}");
                        keepGoing = false;
                    }
                    else {
                    // Increase the guess count
                    guessCount++;
                    
                    // If the user guess it right
                    if (guessCount == theNumber){
                        Console.WriteLine($" Congratulations you guess the number in {guessCount} guesses!");
                        keepGoing = false;
                    }
                    else {
                        Console.WriteLine("Nope {0} than that", guessNum < theNumber? "higher" : "lower");
                    }
                }
             }   

         } while (keepGoing);
            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            
        }
    }
}
