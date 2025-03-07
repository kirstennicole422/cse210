using System;

class Program
{
    static void Main(string[] args)
    {
        // int magicNumber;
        // string userInput;


        // Console.Write("What is the magic number? ");
        // userInput = Console.ReadLine();
        // magicNumber = int.Parse(userInput);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        string userGuess = "";
        int compareValue;
        bool isCorrect = false;

        do
        {
            Console.WriteLine("What is your guess? ");
            userGuess = Console.ReadLine();
            compareValue = int.Parse(userGuess);
            
            if (compareValue < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (compareValue > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                isCorrect = true;
            }
        } while (isCorrect == false);
    }
}