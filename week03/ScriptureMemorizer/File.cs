using System;
using System.Collections.Generic;
using System.IO;

public class File
{
    private string _filename = "";

    public File(string filename)
    {
        _filename = filename;
    }
    public string loadScripture()
    {
        //string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(_filename);
        string textVerse = string.Join(" ", lines);
        //Console.WriteLine(textVerse);
        return textVerse;
    }


}