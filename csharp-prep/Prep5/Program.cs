using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() {
            Console.WriteLine("Welcome tot he program!");
        }

        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favNum = int.Parse(userInput);
            return favNum;
        }

        static int SquareNumber(int num) {
            int squaredNum = num * num;
            return squaredNum;
        }

        static void DisplayReult(string name, int squaredNum) {
            Console.WriteLine($"{name}, the square of your number is {squaredNum}");
        }

        static void Main() {
            DisplayWelcome();
            string name = PromptUserName();
            int favNum = PromptUserNumber();
            int squaredNum = SquareNumber(favNum);
            DisplayReult(name, squaredNum);
        }

        Main();
    }
}