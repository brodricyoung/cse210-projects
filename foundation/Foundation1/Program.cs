using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "The First Video!";
        v1._author = "Brodric Young";
        v1._length = 120;

        Comment v1Com1 = new Comment();
        v1Com1._name = "Kyrsten Gallegos";
        v1Com1._text = "Thats so cool!";
        v1._comments.Add(v1Com1);

        Comment v1Com2 = new Comment();
        v1Com2._name = "Brook Young";
        v1Com2._text = "Yayy!";
        v1._comments.Add(v1Com2);

        Comment v1Com3 = new Comment();
        v1Com3._name = "Jason Young";
        v1Com3._text = "Nice";
        v1._comments.Add(v1Com3);

        videos.Add(v1);



        Video v2 = new Video();
        v2._title = "Video Number Two";
        v2._author = "Bruce Young";
        v2._length = 195;

        Comment v2Com1 = new Comment();
        v2Com1._name = "Mackenzie Gallegos";
        v2Com1._text = "Wowwwwwwww";
        v2._comments.Add(v2Com1);

        Comment v2Com2 = new Comment();
        v2Com2._name = "Rachel Young";
        v2Com2._text = "Huh thats very interesting";
        v2._comments.Add(v2Com2);

        Comment v2Com3 = new Comment();
        v2Com3._name = "Earl Young";
        v2Com3._text = "Well done";
        v2._comments.Add(v2Com3);

        videos.Add(v2);



        Video v3 = new Video();
        v3._title = "Theres a Third Video?";
        v3._author = "Brody Young";
        v3._length = 213;

        Comment v3Com1 = new Comment();
        v3Com1._name = "Kmack Gallegos";
        v3Com1._text = "Thats so cutie!";
        v3._comments.Add(v3Com1);

        Comment v3Com2 = new Comment();
        v3Com2._name = "Raquel Young";
        v3Com2._text = "lolz";
        v3._comments.Add(v3Com2);

        Comment v3Com3 = new Comment();
        v3Com3._name = "Walker Young";
        v3Com3._text = "Thats lit";
        v3._comments.Add(v3Com3);

        Comment v3Com4 = new Comment();
        v3Com4._name = "Cassie Young";
        v3Com4._text = "Neat!!";
        v3._comments.Add(v3Com4);
        
        videos.Add(v3);



        foreach (Video video in videos) {
            video.DisplayVideo();
        }
    }
}