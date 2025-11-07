using System;
using System.Collections.Generic;
using System.IO;

public class FileStorage
{
    public static void SaveToFile(string filename, Journal journal)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in journal.GetEntries())
        {
            lines.Add(entry.Serialize());
        }

        File.WriteAllLines(filename, lines);
    }

    public static Journal LoadFromFile(string filename)
    {
        Journal journal = new Journal();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = Entry.Deserialize(line);
            journal.AddEntry(entry);
        }

        return journal;
    }
}
