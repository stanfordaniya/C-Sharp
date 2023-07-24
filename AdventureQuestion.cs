class Program
{
    public static void Main(string[] args)
    {
        Console.Write("[Epic Quest Simulator]\n");
        Console.Write("Hello stranger! Do you have time to hear my tale?\n1) Yes\n2) No\n");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 2)
        {
            Console.Write("Ah, then goodbye...");
        }
        else if (input == 1)
        {
            Console.Write("Thank you! I come from the land of Pax Bisonica. Our country has been taken over by a cruel tyrant!\n1) That’s awful!\n2) What can I do?\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Alas, it is truly terrible...");
            }

            Console.WriteLine("Please, you must journey to Pax Bisonica and free our country!\n1) Yes\n2) No");

            int selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 2)
            {
                Console.Write("Then all is lost...");
            }
            else if (selection == 1)
            {
                Console.Write("Hooray!!");
            }
        }
    }
}
