using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("1. Get a random prompt and save entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Get a motivational quote");
            Console.WriteLine("6. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        GetAndSaveEntry(journal, random);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter filename to save: ");
                        journal.SaveToFile(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Enter filename to load: ");
                        journal.LoadFromFile(Console.ReadLine());
                        break;
                    case 5:
                        DisplayMotivationalQuote();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void GetAndSaveEntry(Journal journal, Random random)
    {
        string[] prompts = { "How was your day?", "What did you eat today?", "Did you workout today?", "Did you study today?", "Did you try something new today?" };
        string randomPrompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        journal.AddEntry(new JournalEntry(randomPrompt, response));
        Console.WriteLine("Entry saved!\n");
    }

    static void DisplayMotivationalQuote() => Console.WriteLine("Motivational Quote: \"You can do hard things.\"\n");
}

