using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Linq;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Create and populate a list of numbers from user.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers;
        numbers = new List<int>();

        // Get numbers from user
        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter a number:  ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        // 1. Compute the sum of the list items
        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        // 2. Compute the average of the numbers in the list.
        int count = numbers.Count();

        // Now the average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // 3. Find the maximum or largest number in the list.
        int max = -1;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.Write($"The largest number is: {max}");



    }
}