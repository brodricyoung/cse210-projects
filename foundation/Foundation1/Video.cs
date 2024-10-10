using System.Transactions;

public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();




    public int GetCommentNum() {
        return _comments.Count;
    }


    public void DisplayVideo() {
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("");
        
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentNum()}");
        Console.WriteLine($"Comments:");
        foreach (Comment comment in _comments) {
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}