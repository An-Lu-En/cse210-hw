using System;

class Program
{
    static void Main(string[] args)
    {
        // EXTRA FEATURE: The user can choose between multiple scriptures
        Console.WriteLine("Select a scripture to memorize:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("Enter 1 or 2:");
        string choice = Console.ReadLine();

        Scripture scripture;

        if (choice == "2")
        {
            scripture = new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths.");
        }
        else
        {
            scripture = new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life.");
        }

        Console.Clear();
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (scripture.AllWordsHidden())
                break;

            scripture.HideRandomWords();
            Console.Clear();
        }

        Console.WriteLine("\nProgram ended.");
    }
}
