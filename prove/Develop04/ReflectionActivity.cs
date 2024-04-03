using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
        // Add more prompts as needed
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on past experiences.");

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);

        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        Console.WriteLine(prompts[index]);

        Thread.Sleep(2000);

        Console.WriteLine("Reflect on the prompt...");
        Thread.Sleep(2000);

        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Thread.Sleep(3000);
    }
}
