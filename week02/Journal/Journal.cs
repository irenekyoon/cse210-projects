using System;
using System.Collections.Generic;
using System.IO;
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
        // List<Entry> entries = new List<Entry>();
        // string filename = file;
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._entry = parts[2];
            _entries.Add(newEntry);
        }
        // Console.WriteLine(_entries);
        DisplayEntries();
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

