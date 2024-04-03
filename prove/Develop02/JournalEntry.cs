using System;

public class JournalEntry
{
    public DateTime Date { get; set; } = DateTime.Now;
    public string Prompt { get; }
    public string Response { get; }

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
    }

    public override string ToString() => $"{Date}: {Prompt}\nResponse: {Response}\n";
}
