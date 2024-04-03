using System;

// Checklist goal with rewards and a bonus upon completion
public class ChecklistGoal : Goal
{
    private int totalTimes;
    private int timesCompleted;

    public ChecklistGoal(string name, int points, int totalTimes)
    {
        Name = name;
        this.points = points;
        this.totalTimes = totalTimes;
        timesCompleted = 0;
    }

    public override void MarkComplete()
    {
        timesCompleted++;
        Console.WriteLine($"You completed the {Name} goal {timesCompleted}/{totalTimes} times!");
        if (timesCompleted == totalTimes)
        {
            Console.WriteLine($"Congratulations! You achieved the {Name} goal and earned a bonus of {points} points!");
        }
        else
        {
            Console.WriteLine($"You earned {points} points for completing the {Name} goal.");
        }
    }

    public override string Progress()
    {
        return $"Completed {timesCompleted}/{totalTimes} times";
    }
}
