using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // Get the first name.
        Console.Write("What is your first name? ");
        string First_Name = Console.ReadLine();

        // Get the last name.
        Console.Write("What is your last name? ");
        string Last_Name = Console.ReadLine();

        // Provide space before James Bond
        Console.WriteLine();

        // Print the name James Bond style.
        Console.WriteLine($"Your name is {Last_Name}, {First_Name} {Last_Name}.");

    }
}