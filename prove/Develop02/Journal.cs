using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        foreach (Entry entry in _entries) {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
        }
    }

    public void SaveToFile() {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            outputFile.WriteLine("DATE,PROMPT,ENTRY");
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile() {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            if (line == "DATE,PROMPT,ENTRY"){
                continue;
            }

            string[] parts = line.Split(",");

            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            _entries.Add(loadedEntry);
        }
    }

}