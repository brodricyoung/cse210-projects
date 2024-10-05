using System.Security.Cryptography.X509Certificates;

public class Scripture {
    private string _referenceText;
    private string _versesText;

    public Scripture(Reference Reference, Word word) {
        _referenceText = Reference.GetDisplayText();
        _versesText = word.GetDisplayText();
    }



    public void HideRandomWords(int numberToHide, Word word) {
        for (int i = 1; i <= numberToHide; i++) {
            word.Hide();
        }
    }



    public string GetDisplayText() {
        string allText = $"{_referenceText} {_versesText}";
        return allText;
    }
}
