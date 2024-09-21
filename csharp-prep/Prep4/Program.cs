using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int num = 1;
        while (num != 0) {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            if (num != 0) {
                numbers.Add(num);
            }
        }

        int sum = 0;
        int max = 0;
        foreach (int number in numbers) {
            sum += number;
            if (number > max) {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {max}");

    }
}