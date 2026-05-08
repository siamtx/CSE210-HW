using System;

class Program
{
    static void Main(string[] args)
    {

        // Create a new object for the Job class
        Job job1 = new Job();
        Job job2 = new Job();

        // Provide data for each of the elements in job1.
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2020;

        // Provide data for each of the elements in job2.
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Display job1 info
        //Console.WriteLine(job1._company);

        // Display job2 info
        //Console.WriteLine(job2._company);

        // Part 5 display method call
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        // Create a new object for the Resume class
        Resume resume = new Resume();

        // Provide data for each of the elements in resume.
        resume._name = "Allison Rose";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Display resume info
        resume.DisplayResume();



    }
}