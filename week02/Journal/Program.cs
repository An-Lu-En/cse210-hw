using System;

class Program
{
    // EXCEEDS REQUIREMENTS:
    // Added "Mood Rating (1–5)" for additional reflection.
    // Added PromptGenerator and FileStorage for clean code structure.
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void WriteEntry(Journal journal)
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your answer: ");
        string answer = Console.ReadLine();

        Console.Write("Mood rating (1-5, optional, press Enter to skip): ");
        string moodInput = Console.ReadLine();
        int mood = 0;

        if (int.TryParse(moodInput, out int moodValue) && moodValue >= 1 && moodValue <= 5)
        {
            mood = moodValue;
        }

        Entry newEntry = new Entry();
        newEntry.Date = DateTime.Now.ToString("yyyy-MM-dd");
        newEntry.Prompt = prompt;
        newEntry.Response = answer;
        newEntry.MoodRating = mood;

        journal.AddEntry(newEntry);
        Console.WriteLine("Entry recorded!");
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save (example: journal.txt): ");
        string file = Console.ReadLine();

        FileStorage.SaveToFile(file, journal);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load (example: journal.txt): ");
        string file = Console.ReadLine();

        Journal loaded = FileStorage.LoadFromFile(file);
        journal.ReplaceEntries(loaded.GetEntries());
        Console.WriteLine("Journal loaded.");
    }
}