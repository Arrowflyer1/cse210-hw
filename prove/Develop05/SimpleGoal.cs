using System;

// Simple goal with reward
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        this.points = points;
    }

    public override void MarkComplete()
    {
        Console.WriteLine($"Congratulations! You completed the {Name} goal and earned {points} points!");
    }

    public override string Progress()
    {
        return "Completed";
    }
}
