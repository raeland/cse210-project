using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Please type a series of numbers. Type 0 when finished. ");

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            string userEntry = Console.ReadLine();
            userNumber = int.Parse(userEntry);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //1. compute the sum, or total, of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //2. compute the average of the numbers in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //3. find the maximum, or largest, number in the list
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number in list: {max}");
    }
}