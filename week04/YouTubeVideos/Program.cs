using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Painting of Jesus";
        video1._author = "Gabby";
        video1._length = 60;

        Comment com1Vid1 = new Comment();
        com1Vid1._name = "David R";
        com1Vid1._text = "This helped me come closer to Jesus";

        Comment com2Vid1 = new Comment();
        com2Vid1._name = "Susan";
        com2Vid1._text = "I will buy this again as a gift!";

        Comment com3Vid1 = new Comment();
        com3Vid1._name = "Natasha";
        com3Vid1._text = "I couldn't live without this!";

        Comment com4Vid1 = new Comment();
        com4Vid1._name = "Burton";
        com4Vid1._text = "It was okay. Smaller than I expected";

        video1._comments.Add(com1Vid1);
        video1._comments.Add(com2Vid1);
        video1._comments.Add(com3Vid1);
        video1._comments.Add(com4Vid1);

        //video1.DisplayVideo();
        //Console.WriteLine();

        Video video2 = new Video();
        video2._title = "Think Celestial T-Shirt";
        video2._author = "Dave";
        video2._length = 120;

        Comment com1Vid2 = new Comment();
        com1Vid2._name = "Addy";
        com1Vid2._text = "It fit well";

        Comment com2Vid2 = new Comment();
        com2Vid2._name = "Gloria";
        com2Vid2._text = "The material is good quality!";

        Comment com3Vid2 = new Comment();
        com3Vid2._name = "Hector";
        com3Vid2._text = "I like it. I wear it all the time";

        Comment com4Vid2 = new Comment();
        com4Vid2._name = "Georgia";
        com4Vid2._text = "I bought it for my teenage son.";

        video2._comments.Add(com1Vid2);
        video2._comments.Add(com2Vid2);
        video2._comments.Add(com3Vid2);
        video2._comments.Add(com4Vid2);

        //video2.DisplayVideo();
        //Console.WriteLine();

        Video video3 = new Video();
        video3._title = "Print of Seoul Korea Temple";
        video3._author = "Soo-yeon";
        video3._length = 180;

        Comment com1Vid3 = new Comment();
        com1Vid3._name = "Minsoo";
        com1Vid3._text = "Good";

        Comment com2Vid3 = new Comment();
        com2Vid3._name = "Henry";
        com2Vid3._text = "Brings back fond memories of my mission";

        Comment com3Vid3 = new Comment();
        com3Vid3._name = "Jae Lee";
        com3Vid3._text = "I have good feeling when I look at it";

        Comment com4Vid3 = new Comment();
        com4Vid3._name = "Amanda";
        com4Vid3._text = "I love the linework! So delicate ♥";

        video3._comments.Add(com1Vid3);
        video3._comments.Add(com2Vid3);
        video3._comments.Add(com3Vid3);
        video3._comments.Add(com4Vid3);

        //video3.DisplayVideo();
        //Console.WriteLine();

        Video video4 = new Video();
        video4._title = "Temple Coloring Book App";
        video4._author = "Ruth B";
        video4._length = 240;

        Comment com1Vid4 = new Comment();
        com1Vid4._name = "Martha";
        com1Vid4._text = "My kids love it!";

        Comment com2Vid4 = new Comment();
        com2Vid4._name = "Matt";
        com2Vid4._text = "Easy to use. Highly recommend it";

        Comment com3Vid4 = new Comment();
        com3Vid4._name = "Mary G";
        com3Vid4._text = "There's a good variety of coloring pages and colors";

        Comment com4Vid4 = new Comment();
        com4Vid4._name = "Virgie";
        com4Vid4._text = "This helps me think of good things. Thank you for making it!";

        video4._comments.Add(com1Vid4);
        video4._comments.Add(com2Vid4);
        video4._comments.Add(com3Vid4);
        video4._comments.Add(com4Vid4);

        //video4.DisplayVideo();
        //Console.WriteLine();

        List<Video> youtubeVideos = new List<Video>();
        youtubeVideos.Add(video1);
        youtubeVideos.Add(video2);
        youtubeVideos.Add(video3);
        youtubeVideos.Add(video4);
        Console.WriteLine("YoutubeVideo list");
        foreach(Video v in youtubeVideos)
        {
            v.DisplayVideo();
            Console.WriteLine();
        }

    }
}