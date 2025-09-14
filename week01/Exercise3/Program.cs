using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("What is your guess? ");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
        }
        Console.WriteLine("You guessed it!");
    }
}





