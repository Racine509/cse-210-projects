using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startyear = 2019;
        job1._endyear = 2022;

        Job job2 = new Job();
        job2._jobtitle = "Manager";
        job2._company = "Apple";
        job2._startyear = 2022;
        job2._endyear = 2023;

        Resume myresume = new Resume();
        myresume._name = "Racine Yarelay";

        myresume._jobs = new Job[] { job1, job2 };
        myresume.Display();
    }
}

class Job
{
    public string _jobtitle;
    public string _company;
    public int _startyear;
    public int _endyear;
}

class Resume
{
    public string _name;
    public Job[] _jobs;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            Console.WriteLine($"{job._jobtitle} at {job._company} ({job._startyear}-{job._endyear})");
        }
    }
}