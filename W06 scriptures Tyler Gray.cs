
// Class to represent a scripture reference
public class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse != -1)
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}";
    }
}

// Class to represent a scripture passage
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

public class Program
{
    public static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;

            scripture.HideWords(3); // Hide 3 random words
            Console.Clear();
        }
    }
}
