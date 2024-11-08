using System;
public class Resume
{
    public string _personsName;
    public List<Job> _jobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personsName}");
        Console.WriteLine("Job history: ");

        foreach (Job job in _jobs)
        {
            job.DisplayNames();
        }
    }
}