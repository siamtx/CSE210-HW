using System;

class Program
{
    static void Main(string[] args)


    // Step 1:  magic number
    {
        /*
            // Asking user for magic number.
            Console.WriteLine("What is the magic number? ");
            string magicNum = Console.ReadLine();
            int magic = int.Parse(magicNum);

            // Asking user for a guess.
            Console.WriteLine("What is your guess? ");
            string userGuess = Console.ReadLine();
            int user = int.Parse(userGuess);

            // Conditionals to evaluate the uers guess.
            if (user > magic)
            {
                Console.Write("lower");
            }
            else if (user < magic)
            {
                Console.Write("higher");
            }
            else
            {
                Console.Write("You guessed it!");
            }

            //Console.WriteLine(magicNum);
            //Console.WriteLine(userGuess);
        */

        /*
        // Step 2 Looping until a correct guess.

        // Get the magic number from the user.
        Console.WriteLine("What is the magic number? ");
        string magicNum = Console.ReadLine();
        int num = int.Parse(magicNum);

        // Get the users guess.

        // Establish the variable.
        int guess = -1;

        while (guess != num)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!!!!");
            }
        }
        */

        /*
        // Step 3
        // Add random generator from 1 ot 100.

        Random random = new Random();
        int num = random.Next(1, 101);

        // Establish the variable.
        int guess = -1;

        while (guess != num)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!!!!");
            }
        */

        // Challenge 1
        // Add increment counter for guesses.

        Random random = new Random();
        int num = random.Next(1, 101);

        // Establish the variable.
        int guess = -1;
        int count = 0;

        while (guess != num)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // increment counter
            count++;

            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {count} guess {(count == 1 ? "" : "es")}.");

            }


        }


    }


}