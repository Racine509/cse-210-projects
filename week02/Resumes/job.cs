
using System;

class Job
{
    public string _JobTitle;
    public string _Company;
    public int _StartYear;
    public int _EndYear;

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}


