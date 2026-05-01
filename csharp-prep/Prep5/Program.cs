using System;

class Program
{

    static void Main(string[] args)
    {

        DisplayWelcome();

        string Name = PromptUserName();
        int FavoriteNumber = PromptUserNumber();
        PromptUserBirthYear(out int BirthYear);
        int SquaredNumber = SquareNumber(FavoriteNumber);
        DisplayResult(Name, SquaredNumber, BirthYear);


        // 1. Greeting
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // 2. Prompt for user name.
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // 3. Prompt for favorite number.
        static int PromptUserNumber()
        {
            Console.Write("Enter your fabvorite number: ");
            return int.Parse(Console.ReadLine());
        }

        // 4. Prompt for user birth year.
        static void PromptUserBirthYear(out int BirthYear)
        {
            Console.Write("Please enter the year you were born: ");
            BirthYear = int.Parse(Console.ReadLine());
        }

        // 5. Square the user number.
        static int SquareNumber(int FavoriteNumber)
        {
            return (FavoriteNumber * FavoriteNumber);
        }

        // 6. Display the result
        static void DisplayResult(string Name, int SquaredNumber, int BirthYear)
        {
            int CurrentYear = DateTime.Now.Year;
            int Age = CurrentYear - BirthYear;

            Console.WriteLine($"{Name}, the square of your number is {SquaredNumber}");
            Console.WriteLine($"{Name}, you will turn {Age} this year.");
        }

    }
}