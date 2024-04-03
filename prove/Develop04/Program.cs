using System;

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
