using System;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void SaveToFile(string file)
    {
        Entry e1 = new Entry();

        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._prompt}|{e._entry}");
            }
        }
    }
}

