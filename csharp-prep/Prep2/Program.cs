using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // Get the grade percentage.
        Console.WriteLine("Enter your grade percentage:  ");
        string userInput = Console.ReadLine();

        // Convert string to a float.
        float percent = int.Parse(userInput);

        // Compare for letter grade.
        string letter;

        if (percent >= 90)
        {
            // Requirement 1 Console.WriteLine("Your letter grade: A");
            // Requirement 3
            letter = "A";
        }

        else if (percent >= 80 && percent <= 89)
        {
            // Requirement 1 Console.WriteLine("Your letter grade: B");
            // Requirement 3
            letter = "B";
        }

        else if (percent >= 70 && percent <= 79)
        {
            // Requirement 1 Console.WriteLine("Your letter grade: C");
            // Requirement 3
            letter = "C";
        }

        else if (percent >= 60 && percent <= 69)
        {
            // Requirement 1 Console.WriteLine("Your letter grade: D");
            // Requirement 3
            letter = "D";
        }

        else
        {
            // Requirement 1 Console.WriteLine("Your letter grade: F");
            // Requirement 3
            letter = "F";
        }

        // Challenge 1
        int extra = (int)percent % 10;
        string plus;
        if (extra >= 7)
        {
            plus = "+";
        }
        else if (extra < 3)
        {
            plus = "-";
        }
        else
        {
            plus = "";
        }

        // Requirement 3
        // Console.WriteLine($"Your grade is {letter}.");
        // Challenge 1
        // Console.WriteLine($"Your grade is {letter}{plus}.");
        // Challenge 2
        if (letter == "A" && plus == "+")
        {
            Console.WriteLine($"Your grade is {letter}.");
        }
        else if (letter == "A" && plus == "-")
        {
            Console.WriteLine($"Your grade is {letter}{plus}.");
        }
        else if (letter == "B" && plus == "+" || letter == "C" && plus == "+" || letter == "D" && plus == "+")
        {
            Console.WriteLine($"Your grade is {letter}{plus}.");
        }
        else if (letter == "B" && plus == "-" || letter == "C" && plus == "-" || letter == "D" && plus == "-")
        {
            Console.WriteLine($"Your grade is {letter}{plus}.");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        // Requirement 2
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you pass the course!");
        }
        else
        {
            Console.WriteLine("Sorry!  You did not pass the course.  Better luck next time!");
        }


    }
}