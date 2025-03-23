using System;

class Program
{
    static void Main(string[] args)
    {
        
        class Program
        {
            static void Main(string[] args)
            {
                // Create instances of Job
                Job job1 = new Job
                {
                    JobTitle = "Software Engineer",
                    Company = "Microsoft",
                    StartYear = 2019,
                    EndYear = 2022
                };
        
                Job job2 = new Job
                {
                    JobTitle = "Software Engineer",
                    Company = "Apple",
                    StartYear = 2022,
                    EndYear = 2023
                };
        
                // Create an instance of Resume
                Resume myResume = new Resume
                {
                    Name = "Racine Yarelay",
                    Jobs = new List<Job> { job1, job2 }
                };
        
                // Display the resume
                myResume.Display();
            }
        }
    }
}