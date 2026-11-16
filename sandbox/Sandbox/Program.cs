using System;

class Program
{
    static void Main(string[] args)
    {
        // code for the Music.cs
        Song song1 = new Song("Praise to the Man", "William Phelps", "100");
        Song song2 = new Song("The Spirit of God", "William Phelps", "200");
        Song song3 = new Song("I am a Child of God", "Naomi Ward Randall", "301");

        song2.DisplaySong();

        Playlist playlist = new Playlist("Favorite Hymns");

        playlist.AddSong(song1);
        playlist.AddSong(song2);
        playlist.AddSong(song3);
        // playlist(song2);
        // playlist(song3);
        // playlist._playlistName = "Favorite Hymns";
        // playlist.DisplayPlaylist();

        Console.WriteLine();

        playlist.DisplayPlaylist();





        // code for the Book.cs
        // Book book = new Book("Emma", "Ausen", 0);
        // Console.Write(book);



    }
}
