using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "Y";
        while(keepPlaying.ToUpper() == "Y")
        {
            Console.WriteLine("Hello Prep3 World!\n");

            Random randomizer = new Random();
            int magicNumber = randomizer.Next(100);

            Console.WriteLine("Guess the magic number! It's between 0 and 100");

            int guess = -10;
            int guesses = 0;

            while(guess != magicNumber)
            {
                Console.Write("Please type your guess: ");
                guess = int.Parse(Console.ReadLine());
                if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if(guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                guesses++;
            }

            Console.WriteLine($"Congratulations! You guessed it: {guess}");
            Console.WriteLine($"You made {guesses} guesses");

            Console.Write("Would you like to play again?(Y/N) ");
            keepPlaying = Console.ReadLine();
        }


    }
}