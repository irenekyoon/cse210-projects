using System;
using System.Collections.Generic;

public class Playlist
{
    private string _playlistName = "";
    private List<Song> _songs = new List<Song>();

    public Playlist(string name)
    {
        _playlistName = name;
    }

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    private int GetTotal()
    {
        int total = 0;
        int length = 0;

        foreach (Song song in _songs)
        {
            length = song.GetLengthInteger();
            total = total + length;
        }
        return total;
    }

    private string FormatTotal(int total)
    {
        int totalsec = total;
        int totalMin = 0;
        int totalRem = 0;
        string format = "";

        totalMin = total / 60;
        totalRem = total % 60;

        if (totalRem < 10)
        {
            format = ("0" + totalRem.ToString());
        }
        else
        {
            format = $"{totalRem}";
        }
        return ($"The total length of the playlist is {totalMin}:{format}.");
    }

    public void DisplayPlaylist()
    {
        Console.WriteLine($"{_playlistName}:");

        foreach (Song song in _songs)
        {
            song.DisplaySong();
        }
        int totalTime = GetTotal();

        Console.WriteLine(FormatTotal(totalTime));
    }

}