using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the EternalQuest program
        EternalQuest quest = new EternalQuest();

        // Add different types of goals
        quest.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        quest.AddGoal(new EternalGoal("Read Scriptures", 100));
        quest.AddGoal(new ChecklistGoal("Attend the Temple", 50, 10));

        // Record events for each goal
        quest.RecordEvent(0); // Run a Marathon
        quest.RecordEvent(1); // Read Scriptures
        quest.RecordEvent(2); // Attend the Temple

        // Display goals and score
        Console.WriteLine("Your goals:");
        quest.DisplayGoals();
        quest.DisplayScore();
    }
}
