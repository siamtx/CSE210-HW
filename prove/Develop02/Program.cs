using System;

class Program
{
    static void Main(string[] args)
    {

        //**********************************************************************//
        // To show creativity I added the large format header with graphic.     //
        // I added a line telling the user 'q' is not a valid option.           //
        // It is late and I am struggling to find more ways to show creativity. //
        //**********************************************************************//

        Journal journal = new Journal();
        bool running = true;

        Console.WriteLine("*****************************************");
        Console.WriteLine("**                                     **");
        Console.WriteLine("**       WELCOME TO YOUR JOURNAL       **");
        Console.WriteLine("**                                     **");
        Console.WriteLine("*****************************************\n");

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("  1 - Write a new entry");
            Console.WriteLine("  2 - Display all entries");
            Console.WriteLine("  3 - Save journal to file");
            Console.WriteLine("  4 - Load journal from file");
            Console.WriteLine("  5 - Quit");
            Console.Write("\nChoose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    journal.Entry();
                    break;
                case "2":
                    journal.ShowJournal();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid option. q is not a valid option.\n");
                    Console.WriteLine("Please choose 1–5.\n");
                    break;
            }
        }
    }
}