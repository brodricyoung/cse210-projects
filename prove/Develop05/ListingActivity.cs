
public class ListingActivity : Activity {
    private List<Prompt> _prompts;


    public ListingActivity(string name, string description, List<Prompt> prompts) 
    : base(name, description){
        _prompts = prompts;
    }



    public void Run(int duration){
        Console.Clear();
        Console.Write("Get Ready: ");
        ShowSpinner(3);

        Console.WriteLine("\n\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"  --- {GetRandomPrompt()} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> usersList = GetListFromUser(duration);

        Console.WriteLine($"\nYou Listed {usersList.Count} items!");
        ShowSpinner(2);
    }



    public List<string> GetListFromUser(int duration){
        List<string> usersList = new List<string>();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while (DateTime.Now < futureTime) {
            Console.Write("> ");
            usersList.Add(Console.ReadLine());
        }
        return usersList;
    }



    public string GetRandomPrompt() {
        List<Prompt> notShownPrompts = GetPromptsNotShownList(_prompts);

        Random r = new Random();
        int randomIndex = r.Next(notShownPrompts.Count);
        Prompt randomPrompt = notShownPrompts[randomIndex];

        randomPrompt.SetHasBeenShown(true);

        return randomPrompt.GetPromptText();
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