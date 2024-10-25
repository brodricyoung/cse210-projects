using System.IO;
using System.Security.Cryptography;

public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private List<int> _rankThresholds = [1000, 600, 325, 175, 75, 25, 0];
    private List<string> _rankTitles = ["Transcendent", "Diamond", "Gold", "Silver", "Bronze", "Iron", "Normal"];


    public GoalManager() {}


    public void DisplayScore() {
        int i = GetCurrentRankIndex();
        double percent = Math.Round((double)_score / _rankThresholds[i-1] * 100);
        Console.WriteLine($"Rank: {_rankTitles[i].ToUpper()}");
        Console.WriteLine($"> Progress to {_rankTitles[i-1]} rank: {percent}% -- {_score}/{_rankThresholds[i-1]} points");
    }




    public void ListGoals() {
        Console.WriteLine("The goals are:");
        int goalNum = 0;
        foreach (Goal g in _goals) {
            goalNum += 1;
            string completed;
            if (g.IsComplete()) {
                completed = "[X]";
            }
            else {
                completed = "[ ]";
            }

            Console.WriteLine($" {goalNum}. {completed} {g.GetGoalDisplay()}");
        }
    }




    public void CreateGoal() {
        Console.WriteLine("\nThe types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\n   4. Negative Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with it? (use '-' for negative goals) ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1) {
            SimpleGoal sG = new SimpleGoal(name, description, points);
            _goals.Add(sG);
        }

        if (goalType == 2) {
            EternalGoal eG = new EternalGoal(name, description, points);
            _goals.Add(eG);
        }

        if (goalType == 3) {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal cG = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(cG);
        }

        if (goalType == 4) {
            Console.Write("How many times does this negative goal need to be done for a malus? ");
            int negativeTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the malus for doing it that many times? ");
            int malus = int.Parse(Console.ReadLine());

            ChecklistGoal nCG = new ChecklistGoal(name, description, points, negativeTarget, malus);
            _goals.Add(nCG);
        }
    }




    public void RecordEvent() {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int indexPlus1 = int.Parse(Console.ReadLine());
        Goal goal = _goals[indexPlus1 - 1];
        int points = goal.RecordEvent();

        if (points > 0) {
            Console.WriteLine($"Congradulations! You have earned {points} points!");
        }
        else {
            Console.WriteLine($"Sorry, you have lost {-1 * points} points");
        }

        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }




    public void SaveGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outFile = new StreamWriter(filename)) {
            outFile.WriteLine(_score);
            foreach (Goal g in _goals) {
                outFile.WriteLine($"{g},{g.GetGoalFileDisplay()}");
            }
        }
    }




    public void LoadGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        int lineNum = 1;
        foreach (string line in lines) {

            if (lineNum == 1) {
                _score = int.Parse(line);
                lineNum = 0;
            }

            string[] parts = line.Split(",");

            if (parts[0] == "SimpleGoal") {
                SimpleGoal s = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                s.SetIsComplete(bool.Parse(parts[4]));
                _goals.Add(s);
            }

            if (parts[0] == "EternalGoal") {
                EternalGoal e = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(e);
            }

            if (parts[0] == "ChecklistGoal") {
                ChecklistGoal c = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                c.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(c);
            }
        }
        Console.WriteLine($"{filename} has been loaded.");
    }




    public int GetCurrentRankIndex() {
        int currentRankIndex = -1;

        foreach (int t in _rankThresholds) {
            currentRankIndex += 1;
            if (_score > t) {
                break;
            }
        }
        return currentRankIndex;
    }
}