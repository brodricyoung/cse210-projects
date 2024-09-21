using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1,101);

        int guess = 0;
        do {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > num) {
                Console.WriteLine("Lower");
            }
            if (guess < num) {
                Console.WriteLine("Higher");
            }
        }
        while (guess != num);

        Console.WriteLine("You guessed it!");

    }
}