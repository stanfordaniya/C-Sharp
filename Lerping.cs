using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Lerping!]");

        Console.WriteLine("Enter the X coordinate for Keyframe #1: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the X coordinate for Keyframe #2: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many frames have passed?");
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The character has to move " + (y - x) + " places in a second.");

        Console.WriteLine("At 30 FPS, their current X position would be " + (z / 60));
        Console.WriteLine("At 60 FPS, their current X position would be " + (y - z));

    }
}
