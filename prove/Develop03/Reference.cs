using System.ComponentModel.DataAnnotations;

public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public string GetDisplayText() {
        string display;
        if (_endVerse != 0) {
            display = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else {
            display = $"{_book} {_chapter}:{_verse}";
        }
        return display;
    }
}