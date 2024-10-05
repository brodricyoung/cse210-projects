using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Added a file with doctrinal mastery scriptures and had the program choose a random one from the file
        string filename = "ScriptureLibrary.txt";
        string[] lines = File.ReadAllLines(filename);

        Random random = new Random();
        int index = random.Next(lines.Length);
        string randomLine = lines[index];

        string[] parts = randomLine.Split(">");
        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);
        int endVerse;
        string verseText;
        Reference r;

        bool haveEndVerse = int.TryParse(parts[3], out endVerse);
        if (!haveEndVerse) {
            verseText = parts[3];
            r = new Reference(book, chapter, startVerse);
        }
        else {
            verseText = parts[4];
            r = new Reference(book, chapter, startVerse, endVerse);
        }
        Word w = new Word(verseText);

        


        string userInput = "";
        bool completelyHidden = false;
        int hiddenCounter = 0;
        while (userInput == "" && !completelyHidden) {
            Console.Clear();
            Scripture s = new Scripture(r, w);
            string allText = s.GetDisplayText();
            Console.WriteLine(allText);

            s.HideRandomWords(3, w);

            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            
            if (w.IsCompletelyHidden()) {
                hiddenCounter++;
                if (hiddenCounter == 2) {
                    completelyHidden = true;
                }
            }
        }

    }
}