class Assignment3C
{
    public static void Main(string[] args)
    {
        Console.Write("[App Checklist]\nWhat mobile device do you have? ");
        string x = Console.ReadLine();

        if (x == "Apple")
        {
            Console.Write("What version do you have? ");
        }

        if (x == "Android")
        {
            Console.Write("What version do you have? ");
        }

        if (x == "Windows Phone")
        {
            Console.Write("I’m sorry, our app does not support your device.");
        }

        double a = Convert.ToDouble(Console.ReadLine());

        if (a == 6)
        {
            Console.Write("Does your device support Bluetooth connections? ");
        }
        if (a == 12)
        {
            Console.Write("Congratulations, you can run the app!");
        }
        if (a == 9.1)
        {
            Console.Write("Does your device support Augmented Reality? ");
        }

        string b = Console.ReadLine();
        if (b == "No")
        {
            Console.Write("I’m sorry, our app does not support your device.");
        }

        if (b == "Yes")
        {
            Console.Write("Congratulations, you can run the app!");
        }
    }
}
