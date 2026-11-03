using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Zion Builds";
        job1._startYear = 2026;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "SY Designs";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2027;
        job2._endYear = 2036;

        Resume resume = new Resume();
        resume._name = "Irene";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();

    }
}