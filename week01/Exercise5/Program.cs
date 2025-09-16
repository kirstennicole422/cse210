using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int userNum = int.Parse(userNumber);
        return userNum;
    }

    static int SquareNumber(int numberToSquare)
    {
        return numberToSquare * numberToSquare;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        DisplayResult(userName, SquareNumber(userNumber));
    }
}