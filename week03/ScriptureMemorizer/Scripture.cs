using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3; // hide 3 per step, more challenging

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

            if (visibleWords.Count == 0)
                return;

            Word word = visibleWords[_random.Next(visibleWords.Count)];
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
