using System;

class Program
{
    public static void Main(string[] args)
    {
        string sentence;
        int letters;
        Console.WriteLine("[Backspace Animation]\nPlease enter your sentence:");
        sentence = Console.ReadLine();
        //prompts the user for a sentence
        Console.WriteLine("How many letters do you want to backspace?");
        letters = Convert.ToInt32(Console.ReadLine());
        Console.Write(sentence);
        //if(sentence -= letters){
        //Pause the program for 0.5 seconds
        for (int i = 0; i < letters; i++)
        {
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b");
        }
        //Note: You may need to use “\b \b” rather than just “\b”
    }

}
