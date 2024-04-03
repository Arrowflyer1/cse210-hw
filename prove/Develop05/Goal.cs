using System;

// Base class for different types of goals
public abstract class Goal
{
    public string Name { get; set; }
    protected int points; // Changed to protected

    public abstract void MarkComplete();
    public abstract string Progress();
}
