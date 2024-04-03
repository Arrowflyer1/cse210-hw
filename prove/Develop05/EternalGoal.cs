using System;

// Eternal goal with ongoing rewards
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        this.points = points;
    }

    public override void MarkComplete()
    {
        Console.WriteLine($"You recorded progress for the {Name} goal and earned {points} points!");
    }

    public override string Progress()
    {
        return "Ongoing";
    }
}
