using System.IO;
public class ReflectingActivity : Activity {
    private List<Prompt> _prompts;
    private List<Prompt> _questions;


    public ReflectingActivity(string name, string description, List<Prompt> prompts, List<Prompt> questions)
    : base(name, description) {
        _prompts = prompts;
        _questions = questions;
    }



    public void Run(int duration) {
        Console.Clear();
        Console.Write("Get Ready: ");
        ShowSpinner(3);

        Console.WriteLine("\n\nConsider the following prompt:");
        Console.WriteLine($"\n  --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountdown(5);

        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while (DateTime.Now < futureTime) {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(7);
        }
    }


    public string GetRandomPrompt() {
        List<Prompt> notShownPrompts= GetPromptsNotShownList(_prompts);

        Random r = new Random();
        int randomIndex = r.Next(notShownPrompts.Count);
        Prompt randomPrompt = notShownPrompts[randomIndex];

        randomPrompt.SetHasBeenShown(true);

        return randomPrompt.GetPromptText();
    }


    public string GetRandomQuestion() {
        List<Prompt> notShownQuestions = GetPromptsNotShownList(_questions);

        Random r = new Random();
        int randomIndex = r.Next(notShownQuestions.Count);
        Prompt randomQuestion = notShownQuestions[randomIndex];

        randomQuestion.SetHasBeenShown(true);
        
        return randomQuestion.GetPromptText();
    }


    public List<Prompt> GetPromptsNotShownList(List<Prompt> prompts) {
        List<Prompt> notShownPrompts = new List<Prompt>();
        foreach (Prompt p in prompts) {
            if (!p.HasBeenShown()) {
                notShownPrompts.Add(p);
            }
        } 
        if (notShownPrompts.Count == 0) {
            foreach (Prompt p in prompts) {
                p.SetHasBeenShown(false);
                notShownPrompts.Add(p);
            }
        }
        return notShownPrompts;
    }
}