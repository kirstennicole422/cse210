// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("What is your grade percent? ");
//         string userGrade = Console.ReadLine();
//         int userPercentage = int.Parse(userGrade);
//         string letter = "";
//         bool passClass = true;
//         if (userPercentage >= 90)
//         {
//             letter = "A";
//         }
//         else if (userPercentage >= 80)
//         {
//             letter = "B";
//         }
//         else if (userPercentage >= 70)
//         {
//             letter = "C";
//         }else if (userPercentage >= 60)
//         {
//             letter = "D";
//             passClass = false;
//         }

//         else
//         {
//             letter = "F";
//             passClass = false;
//         }
//         Console.WriteLine($"The letter grade is {letter}.");
//         if (passClass)
//         {
//             Console.Write("You passed the class. Congratulations!");
//         }
//         else
//         {
//             Console.Write("You did not pass the class. You can do better next time!");
//         }
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percent? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);
        string letter;
        if (gradePercent >= 90)
            letter = "A";
        else if (gradePercent >= 80)
            letter = "B";
        else if (gradePercent >= 70)
            letter = "C";
        else if (gradePercent >= 60)
            letter = "D";
        else
            letter = "F";
        Console.WriteLine(letter);

        if (gradePercent >= 70)
            Console.WriteLine($"Congrats you passed the course with a grade of {letter}");
        if (gradePercent < 70)
            Console.WriteLine("You will need to retake the class. Better luck next time!");
    }

}












