using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Superhero Adventure!");
        Console.WriteLine("You find yourself in a maze of options. Choose wisely!");
        Console.WriteLine();

        int health = 100;
        int turn = 1;
        while (turn <= 5)
        {
            Console.WriteLine($"Turn {turn}:");
            Console.WriteLine("1. Go left");
            Console.WriteLine("2. Go right");
            Console.Write("Choose your option (1 or 2): ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You chose to go left. You find a health potion and gain 10 health!");
                health += 10;
            }
            else if (input == "2")
            {
                Console.WriteLine("You chose to go right. You encounter a villain!");
                Console.WriteLine("Prepare to fight!");

                int villainHealth = 50;
                while (villainHealth > 0 && health > 0)
                {
                    Console.WriteLine($"Your health: {health}");
                    Console.WriteLine($"Villain's health: {villainHealth}");
                    Console.WriteLine("1. Punch");
                    Console.WriteLine("2. Kick");
                    Console.Write("Choose your action (1 or 2): ");
                    string action = Console.ReadLine();

                    if (action == "1")
                    {
                        Console.WriteLine("You punch the villain!");
                        villainHealth -= 20;
                        if (villainHealth <= 0)
                        {
                            Console.WriteLine("You defeated the villain!");
                            break;
                        }
                        Console.WriteLine("The villain attacks you!");
                        health -= 10;
                    }
                    else if (action == "2")
                    {
                        Console.WriteLine("You kick the villain!");
                        villainHealth -= 30;
                        if (villainHealth <= 0)
                        {
                            Console.WriteLine("You defeated the villain!");
                            break;
                        }
                        Console.WriteLine("The villain attacks you!");
                        health -= 15;
                    }
                    else
                    {
                        Console.WriteLine("Invalid action! Please choose 1 or 2.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid option! Please choose 1 or 2.");
            }

            turn++;
            Console.WriteLine();
        }

        if (health > 0)
        {
            Console.WriteLine("You have reached the final boss!");
            Console.WriteLine("Prepare to face the ultimate challenge!");
            Console.WriteLine("As you approach the final boss, you see a massive creature towering over you.");
            Console.WriteLine("Its eyes glow with an otherworldly light, and its roars shake the ground beneath your feet.");
            Console.WriteLine("This is the moment you've been training for. You must defeat the final boss to save the world!");
            Console.WriteLine();
            Console.WriteLine("1. Attack with all your might");
            Console.WriteLine("2. Gather your strength and strategize");
            Console.Write("Choose your action (1 or 2): ");
            string finalAction = Console.ReadLine();

            Random random = new Random();
            int randomNumber = random.Next(1, 3); // Generates a random number between 1 and 2

            if (finalAction == randomNumber.ToString())
            {
                Console.WriteLine("You launch a fierce assault against the final boss!");
                Console.WriteLine("Every blow strikes true, and soon the final boss falls before you.");
                Console.WriteLine("Congratulations! You have saved the world!");
            }
            else
            {
                Console.WriteLine("You hesitate, unsure of your next move.");
                Console.WriteLine("The final boss seizes the opportunity and delivers a devastating attack!");
                Console.WriteLine("You've been defeated. The world falls into darkness.");
                health = 0; // Set health to 0 to end the game
            }
        }

        if (health > 0)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Game over. Thanks for playing!");
        }
        else
        {
            Console.WriteLine("Game over. You lost all your health!");
        }
    }
}
