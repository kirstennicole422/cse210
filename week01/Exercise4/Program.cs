using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int userNum;
        int sum = 0;
        int largestNum;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string userString = Console.ReadLine();
            userNum = int.Parse(userString);
            if (userNum != 0)
            {
                numberList.Add(userNum);
            }
        } while (userNum != 0);

        largestNum = numberList[0];
        foreach (int number in numberList)
        {
            sum += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {numberList.Average()}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}
