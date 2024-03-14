using System;
using System.Threading;

// Base class for all activities
public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int duration)
    {
        durationInSeconds = duration;
    }

    public abstract void Start();
}

// Breathing activity class
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

// Reflection activity class
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

// Listing activity class
public class ListingActivity : Activity
{
    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you list positive aspects of your life.");

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);

        Console.WriteLine("Start listing...");

        // Simulate user listing items
        for (int i = 1; i <= durationInSeconds; i++)
        {
            Console.WriteLine($"Item {i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You listed {durationInSeconds} items.");
        Thread.Sleep(3000);
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness App");
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter duration (in seconds):");
        int duration = int.Parse(Console.ReadLine());

        Activity activity = null;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity(duration);
                break;
            case 2:
                activity = new ReflectionActivity(duration);
                break;
            case 3:
                activity = new ListingActivity(duration);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        if (activity != null)
        {
            activity.Start();
        }
    }
}
