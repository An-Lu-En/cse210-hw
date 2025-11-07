using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries yet.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            if (entry.MoodRating > 0)
            {
                Console.WriteLine($"Mood (1-5): {entry.MoodRating}");
            }
        }
        Console.WriteLine("----------------------------");
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void ReplaceEntries(List<Entry> newEntries)
    {
        _entries = newEntries;
    }
}
