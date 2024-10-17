
public class BreathingActivity : Activity {

    public BreathingActivity(string name, string description)
    : base(name, description) {

    }


    public void Run(int duration){
        Console.Clear();
        Console.Write("Get Ready: ");
        ShowSpinner(3);

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while (DateTime.Now < futureTime) {

            Console.Write($"\n\nBreathe in...");
            ShowCountdown(4);
            Console.Write("\nBreathe out...");
            ShowCountdown(6);
        }
        Console.WriteLine();
    }
}