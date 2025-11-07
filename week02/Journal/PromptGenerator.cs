using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private static List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I talked to today?",
        "What was the best part of my day?",
        "What am I grateful for today?",
        "What is something I learned today?",
        "If I could redo one thing today, what would it be?"
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
