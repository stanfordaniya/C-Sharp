using System;

class Assignment4A
{
    public static void Main(string[] args)
    {

        string[] country = { "Italy", "Costa Rica", "Pax Bisonica", "Ghana" };
        Console.WriteLine("[CCSE Study Abroad Survey]\n");
        bool done = false;
        int numOfStudent = 1;
        int numOfItaly = 0;
        int numOfCosta = 0;
        int numOfPax = 0;
        int numOfGhana = 0;

        while (done == false)
        {
            Console.WriteLine("Student #{0}: Which country should we go to for our next study abroad program?", numOfStudent);
            Console.WriteLine("Italy\nCosta Rica\nPax Bisonica\nGhana\n(Type Quit to end the survey)");
            string input = Console.ReadLine(); //this is user input

            numOfStudent++;


            if (input == "Quit")
            {  //if use inputs Quit the program Quits
                done = true;
            }
            Console.WriteLine("Thank you!\n");


            if (input == "Italy")
            {
                numOfItaly++;
            }

            else if (input == "Costa Rica")
            {
                numOfCosta++;
            }

            else if (input == "Pax Bisonica")
            {
                numOfPax++;
            }

            else if (input == "Ghana")
            {
                numOfGhana++;
            }
        }
        Console.WriteLine("[Results]");
        Console.WriteLine("Italy: " + numOfItaly);
        Console.WriteLine("Costa Rica: " + numOfCosta);
        Console.WriteLine("Pax Bisonica: " + numOfPax);
        Console.WriteLine("Ghana: " + numOfGhana);
        string winner = null;
        if (numOfItaly > numOfCosta && numOfItaly > numOfGhana && numOfItaly > numOfPax)
        {
            winner = "Italy";
        }
        else if (numOfCosta > numOfItaly && numOfCosta > numOfGhana && numOfCosta > numOfPax)
        {
            winner = "Costa Rica";
        }
        else if (numOfPax > numOfCosta && numOfPax > numOfGhana && numOfPax > numOfItaly)
        {
            winner = "Pax Bisconica";
        }
        else if (numOfGhana > numOfCosta && numOfGhana > numOfItaly && numOfGhana > numOfPax)
        {
            winner = "Ghana";
        }
        Console.Write("\nNext year's study abroad program will take place in " + winner);
    }
}
