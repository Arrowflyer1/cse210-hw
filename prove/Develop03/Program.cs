using System;

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
