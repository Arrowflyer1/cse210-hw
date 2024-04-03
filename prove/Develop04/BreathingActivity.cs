using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by guiding you through breathing exercises.");

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);

        for (int i = 0; i < durationInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Thread.Sleep(3000);
    }
}
