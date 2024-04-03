    while (true)
        {
        Console.WriteLine("1. Get a random prompt and save entry");
        Console.WriteLine("2. Display journal entries");
        Console.WriteLine("3. Save journal to a file");
        Console.WriteLine("4. Load journal from a file");
        Console.WriteLine("5. Get a motivational quote");
        Console.WriteLine("6. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        GetAndSaveEntry(journal);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter filename to save: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        break;
                    case 4:
                        Console.Write("Enter filename to load: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
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
    

    static void GetAndSaveEntry(Journal journal)
    {
        string[] prompts = { "How was your day?", "What did you eat today?", "Did you workout today?", "Did you study today?", "Did you try something new today?" };
        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry(DateTime.Now, randomPrompt, response);
        journal.AddEntry(entry);
        Console.WriteLine("Entry saved!\n");
    }

    static void DisplayMotivationalQuote()
    {
        Console.WriteLine("Motivational Quote: \"You can do hard things.\"\n");
    }

