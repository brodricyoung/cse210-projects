using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        
        int choice = 0;
        while (choice != 5) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if (choice == 1) {
                PromptGenerator prompts = new PromptGenerator();
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = userResponse;

                journal.AddEntry(newEntry);
            }

            if (choice == 2) {
                journal.DisplayAll();
                }

            if (choice == 3) {
                journal.LoadFromFile();
            }

            if (choice == 4) {
                Console.WriteLine("Saving will overwrite any data that has not been loaded.");
                Console.WriteLine("Do you wish to continue?\n1. Yes\n2. No");
                Console.Write("> ");
                string input = Console.ReadLine();
                int proceeding = int.Parse(input);

                if (proceeding == 1) {
                journal.SaveToFile();
                }
            }
            Console.WriteLine("");
        }
    }
}