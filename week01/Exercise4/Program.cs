using System;
using System.Data;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int nextNumber;
        List<int> numbers = new List<int>();
        float sum = 0;
        int max = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            if (userInput == "0")
            {
                break;
            }
            nextNumber = int.Parse(userInput);
            numbers.Add(nextNumber);
        } while (userInput != "0");



        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            if (number > max)
            {
                max = number;
            }
            sum = sum + number;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers.Count}");
        Console.WriteLine($"The largest number is: {max}");

    }
}