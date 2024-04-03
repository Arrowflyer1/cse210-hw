using System;
using System.Threading;

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
