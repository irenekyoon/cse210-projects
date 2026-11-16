using System;

public class Song
{
    private string _title;
    private string _artist;
    private string _length;

    public Song()
    {
        _title = "not provided";
        _artist = "not provided";
        _length = "not provided";
    }

    public Song(string title, string artist)
    {
        _title = title;
        _artist = artist;
    }
    public Song(string title, string artist, string length)
    {
        _title = title;
        _artist = artist;
        _length = length;
    }

    public int GetLengthInteger()
    {
        int lengthInt = int.Parse(_length);
        return lengthInt;

    }
    public void DisplaySong()
    {
        Console.WriteLine($"{_title} by {_artist} ({_length})");
    }

}