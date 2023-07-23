using System;

class Assignment4B
{
    public static void Main(string[] args)
    {
        int choice = 0;
        Console.Write("Welcome!\n");

        Console.Write("Please input a number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        do
        {

            if (x != 0)
            {

                Console.WriteLine("\nWhat would you like to do to this number:\n" + "-1- Re-enter the number\n" +
                        "0- Get the additive inverse of the number\n" +
                        "1- Get the reciprocal of the number\n" +
                        "2- Square the number\n" +
                        "3- Cube the number\n" +
                        "4- Exit the program");
            }
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice < -1 || choice > 4)
            {
                Console.Write("Please enter a valid number between -1 and 4: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            float result = 0;

            switch (choice)
            {
                case -1:

                    Console.Write("Please input a number: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    break;

                case 0:
                    result = (-1 * x);
                    Console.WriteLine("The additive inverse of " + x + " is " + result);

                    break;

                case 1:
                    result = (1 / x);
                    Console.WriteLine("The reciprocal of " + x + " is " + result);
                    break;

                case 2:
                    result = (x * x);
                    Console.WriteLine("The square of " + x + ".0" + " is " + result + ".0");
                    break;

                case 3:
                    result = (x * x * x);
                    Console.WriteLine("The cube of " + x + ".0" + " is " + result + ".0");
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

            }

            if (x == 0)
            {
                Console.WriteLine("\nWhat would you like to do to this number:\n" + "-1- Re-enter the number\n" +
                            "0- Get the additive inverse of the number\n" +
                            "2- Square the number\n" +
                            "3- Cube the number\n" +
                            "4- Exit the program");
            }
        } while (choice != 4);

    }
}
