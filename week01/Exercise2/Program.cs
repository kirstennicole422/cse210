using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string userGrade = Console.ReadLine();
        int userPercentage = int.Parse(userGrade);
        string letter = "";
        bool passClass = true;
        if (userPercentage >= 90)
        {
            letter = "A";
        }
        else if (userPercentage >= 80)
        {
            letter = "B";
        }
        else if (userPercentage >= 70)
        {
            letter = "C";
        }else if (userPercentage >= 60)
        {
            letter = "D";
            passClass = false;
        }
        else
        {
            letter = "F";
            passClass = false;
        }
        Console.WriteLine($"The letter grade is {letter}.");
        if (passClass)
        {
            Console.Write("You passed the class. Congratulations!");
        }
        else
        {
            Console.Write("You did not pass the class. You can do better next time!");
        }
    }
}