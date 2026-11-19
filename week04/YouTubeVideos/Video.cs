using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetNumComments()
    {
        int comNumber = -1;
        comNumber = _comments.Count;
        return comNumber;
        // for (int i = 1; i < _comments.Count + 1; i++)
        // {
        //     Console.WriteLine(i);
        //     return i;
        // }
    }

    public void DisplayVideo()
    {
        int numCom = GetNumComments();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (sec): {_length}");
        Console.WriteLine($"Comments: ({numCom})");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();

        }
    }
}