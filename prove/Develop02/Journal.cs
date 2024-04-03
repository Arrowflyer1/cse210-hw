using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry) => entries.Add(entry);

    public void DisplayEntries() => entries.ForEach(Console.WriteLine);

    public void SaveToFile(string fileName) => File.WriteAllLines(fileName, entries.ConvertAll(entry => $"{entry.Date},{entry.Prompt},{entry.Response}"));

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        if (File.Exists(fileName))
        {
            foreach (var line in File.ReadAllLines(fileName))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                {
                    entries.Add(new JournalEntry(parts[1], parts[2]) { Date = date });
                }
            }
        }
        else
        {
            Console.WriteLine("File not found. Creating a new journal.");
        }
    }
}
