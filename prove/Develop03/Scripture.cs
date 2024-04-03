using System;
using System.Collections.Generic;

public class Scripture
{
    private readonly string[] _words;

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        _words = text.Split(' ');
    }

    public ScriptureReference Reference { get; }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", _words));
    }

    public void HideWords(int count)
    {
        Random rand = new Random();
        HashSet<int> hiddenIndices = new HashSet<int>();

        while (hiddenIndices.Count < count)
        {
            int index = rand.Next(0, _words.Length);
            if (!hiddenIndices.Contains(index))
                hiddenIndices.Add(index);
        }

        foreach (int index in hiddenIndices)
        {
            _words[index] = new string('*', _words[index].Length);
        }
    }

    public bool AllWordsHidden()
    {
        foreach (string word in _words)
        {
            if (!word.Contains("*"))
                return false;
        }
        return true;
    }
}
