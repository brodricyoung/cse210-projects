using System.Security.Cryptography.X509Certificates;

public class Word {
    private string _text;
    private bool _isHidden;

    List<Word> words = new List<Word>();


    public Word() {

    }



    public Word(string text) {
        string[] words1 = text.Split(" ");

        foreach (string word in words1) {
            Word w = new Word();
            w._text = word;
            w._isHidden = false;
            words.Add(w);
        }
        
    }



    public void Hide() {
        bool tryAgain = true;
        while (tryAgain && !IsCompletelyHidden()) {
            Random random = new Random();
            int index = random.Next(words.Count);
            Word randomWord = words[index];
            if (randomWord._isHidden == false) {
                randomWord._isHidden = true;
                tryAgain = false;
            }
        }
    }



    public bool IsCompletelyHidden() {
        bool completelyHidden;
        int counter = 0;
        foreach (Word word in words) {
            if (word._isHidden == true) {
                counter += 1;
            }
        }
        if (counter == words.Count) {
            completelyHidden = true;
        }
        else {
            completelyHidden = false;
        }
        return completelyHidden;
    }



    public string GetDisplayText() {
        string displayText = "";
        foreach (Word word in words) {
            if (word._isHidden == false) {
                displayText = $"{displayText} {word._text}";
            }
            else {
                string blankSpaces = "";
                int charNum = word._text.Length;
                for (int i = 1; i <= charNum; i++) {
                    blankSpaces = $"{blankSpaces}_";
                }
                displayText = $"{displayText} {blankSpaces}";
            }
        }
        return displayText;
    }
}