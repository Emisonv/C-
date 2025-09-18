// File: Bunnyclass.cs

using System;

public class Program
{
    public static void Main()
    {
        // Using the Bunny class with an object initializer
        Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };

        // Display Bunny information
        Console.WriteLine($"Bunny Name: {b1.Name}");
        Console.WriteLine($"Likes Carrots: {b1.LikesCarrots}");
        Console.WriteLine($"Likes Humans: {b1.LikesHumans}");

        // Using another constructor with optional parameters
        Bunny b2 = new Bunny("Lola", true, true);

        Console.WriteLine($"\nBunny Name: {b2.Name}");
        Console.WriteLine($"Likes Carrots: {b2.LikesCarrots}");
        Console.WriteLine($"Likes Humans: {b2.LikesHumans}");
    }
}

public class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny() { }

    public Bunny(string name, bool likesCarrots = false, bool likesHumans = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
}
