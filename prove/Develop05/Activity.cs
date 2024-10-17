
public class Activity{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }



    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
    }

    public int GetDuration() {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }


    public void DisplayEndingMessage() {
        Console.WriteLine("\nWell done!!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds) {
        string spinner = "";
        for (int i = 1; i <= seconds; i++) {
            spinner += ".";
        }
        Console.Write(spinner);
        for (int i = 1; i <= seconds; i++) {
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void ShowCountdown(int seconds) {
        Console.Write(seconds);
        for (int i = seconds - 1; i >= 0; i--) {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (i != 0) {
                Console.Write(i);
            }

        }
    }
}