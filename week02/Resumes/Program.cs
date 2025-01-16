using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2007;
        job1._endYear = 2013;
        
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2013;
        job2._endYear = 2019;

        // Console.WriteLine(job1._jobTitle);
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume._name = "Allison Rose";

       Console.WriteLine(resume._jobs[0]._jobTitle);
       resume.DisplayResumeDetails();


    }
}