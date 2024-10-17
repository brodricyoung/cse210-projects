
public class Prompt {
    private string _text;
    private bool _hasBeenShown;

    public Prompt(string text, bool hasBeenShown) {
        _text = text;
        _hasBeenShown = hasBeenShown;
    }

    public bool HasBeenShown() {
        if (_hasBeenShown) {
            return true;
        }
        else {return false;}
    }


    public string GetPromptText() {
        return _text;
    }

    public void SetHasBeenShown(bool shown) {
        _hasBeenShown = shown;
    }
}