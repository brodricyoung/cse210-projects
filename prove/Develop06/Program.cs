/*
For creativity, I added a rank system that allows a user to rank up with certain amounts 
of points, and the gap in points increases with rank. I also added another class for 
negative goals and made it similar to checklist goals but for deducting points.
*/



using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gM = new GoalManager();
        int choice = 0;
        while (choice != 6) {
            Console.WriteLine("\n");
            gM.DisplayScore();

            Console.WriteLine("\nMenu options:\n   1. Create Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    gM.CreateGoal();
                    break;
                case 2:
                    gM.ListGoals();
                    break;
                case 3:
                    gM.SaveGoals();
                    break;
                case 4:
                    gM.LoadGoals();
                    break;
                case 5:
                    gM.RecordEvent();
                    break;
            }
        }
    }
}