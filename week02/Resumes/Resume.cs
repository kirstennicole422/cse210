public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        // for (int i = 0; i < _jobs.Count; i ++)
        // {
        //     Console.WriteLine($"{_jobs[i].DisplayJobDetails}");
        // }


        // foreach (Job j in Jobs._jobs)
        // {
        //     Console.WriteLine ($"{j.DisplayJobDetails()}");
        // }

    }
}