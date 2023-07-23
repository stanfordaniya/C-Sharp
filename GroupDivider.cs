using System;

class Assignment2A
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many people are in your group? ");
        int ppl = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many groups do you want: ");
        int grp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("If we divide " + ppl + " people in " + grp + " groups evenly, " + ppl % grp + " person/people will be left without a group.");
    }
}
