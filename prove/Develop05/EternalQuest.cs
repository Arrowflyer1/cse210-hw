using System;
using System.Collections.Generic;

// Class to manage goals and track user's score
public class EternalQuest
{
    protected List<Goal> goals = new List<Goal>();
    protected int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        goals[goalIndex].MarkComplete();
        score += goals[goalIndex].points; // Accessing points field
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.Name} - {goal.Progress()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {score}");
    }
}
