using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string description;
        int duration;
        int choice = 0;
        while (choice != 4) {
            Console.Clear();
            Console.WriteLine("Menu Options:\n   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listening Activity\n   4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            
            if (choice == 1) {
                name = "Breathing Activity";
                description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity ba = new BreathingActivity(name, description);
                ba.DisplayStartingMessage();
                duration = ba.GetDuration();
                ba.Run(duration);
                ba.DisplayEndingMessage();
            }


            if (choice == 2) {
                name = "Reflecting Activity";
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                List<string> prompt_texts = ["Think of a time when you stood up for someone else.",
                                             "Think of a time when you did something really difficult.",
                                             "Think of a time when you helped someone in need.",
                                             "Think of a time when you did something truly selfless."];
                List<Prompt> prompts = new List<Prompt>();
                foreach(string text in prompt_texts) {
                    Prompt p = new Prompt(text, false);
                    prompts.Add(p);
                }
                
                List<string> question_texts = ["Why was this experience meaningful to you?",
                                               "Have you ever done anything like this before?",
                                               "How did you get started?",
                                               "How did you feel when it was complete?",
                                               "What made this time different than other times when you were not as successful?",
                                               "What is your favorite thing about this experience?",
                                               "What could you learn from this experience that applies to other situations?",
                                               "What did you learn about yourself through this experience?",
                                               "How can you keep this experience in mind in the future?"];
                List<Prompt> questions = new List<Prompt>();
                foreach(string text in question_texts) {
                    Prompt q = new Prompt(text, false);
                    questions.Add(q);
                }

                ReflectingActivity ra = new ReflectingActivity(name, description, prompts, questions);
                ra.DisplayStartingMessage();
                duration = ra.GetDuration();
                ra.Run(duration);
                ra.DisplayEndingMessage();
            }


            if (choice == 3) {
                name = "Listing Activity";
                description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                List<string> prompt_texts = ["Who are people that you appreciate?",
                                             "What are personal strengths of yours?",
                                             "Who are people that you have helped this week?",
                                             "When have you felt the Holy Ghost this month?",
                                             "Who are some of your personal heroes?"];
                List<Prompt> prompts = new List<Prompt>();
                foreach(string text in prompt_texts) {
                    Prompt p = new Prompt(text, false);
                    prompts.Add(p);
                }

                ListingActivity la = new ListingActivity(name, description, prompts);
                la.DisplayStartingMessage();
                duration = la.GetDuration();
                la.Run(duration);
                la.DisplayEndingMessage();
            }
        }
    }
}