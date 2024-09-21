using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";
        if (percent >= 90) {
            letter = "A";
        }
        else if (percent >= 80) {
            letter = "B";
        }
        else if (percent >= 70) {
            letter = "C";
        }
        else if (percent >= 60) {
            letter = "D";
        }
        else if (percent < 60) {
            letter = "F";
        }
        

        Console.WriteLine($"Your final grade: {letter}");

        if (percent >= 70) {
            Console.WriteLine("Congradulations, you passed the class.");
        }
        else { 
            Console.WriteLine("You'll do better next time.");
        }
    }
}