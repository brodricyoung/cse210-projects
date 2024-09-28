public class PromptGenerator {
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today what would it be?",
        "What was the best part of your day?",
        "Did anything unexpected happen today?",
        "Whats one lesson you learned from todays experiences?",
        "How did you take care of yourself today?",
        "Whats something you accomplished today no matter how small?",
        "Who did you interact with today?",
        "What challenged you today?",
        "How did todays weather affect your mood or energy?",
        "Whats one thing you noticed today that you might have overlooked before?",
        "Whats something you could have done differently today to make it better?"
    };

    public string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}