using System;

class Program
{
    public static void Main(string[] args)
    {
        string input;
        int machine = 0;

        FSA[] machines = new FSA[3];
        Random gen = new Random();


        for (int i = 0; i < 3; i++)
        {

            machines[i] = new FSA(gen.Next(4));

        }
        Console.WriteLine("[Array of Finite State Automata]");


        for (int i = 0; i < 3; i++)
        {
            Console.Write("Machine " + i + " is starting at state " + machines[i].showCurrentState() + "\n");
        }

        Console.WriteLine("\nWhat will you do?\n-Check the current status\n-Go to next state\n-End");
        input = Console.ReadLine();
        if (input == "Check the current status")
        {
            Console.Write("What machine will you look at? ");
            machine = Convert.ToInt32(Console.ReadLine());

            if (machine == 2)
            {

                Console.WriteLine("\nMachine #2 is active and at state"+  machines[machine].showCurrentState()+"\n");
                Console.WriteLine("What will you do?\n-Check the current status\n-Go to next state\n-End");
                input = Console.ReadLine();
            }
            if (input == "Quit")
            {
                Console.WriteLine("\ninvalid command");
                Console.WriteLine("What will you do?\n-Check the current status\n-Go to next state\n-End");
                input = Console.ReadLine();
            }
            if (input == "Go to next state")
            {
                Console.WriteLine("What machine will you advance? ");
                int advance = Convert.ToInt32(Console.ReadLine());
          
               if (advance == 1)
                {
                    Console.WriteLine("Machine #" + advance + "is now at state" + machines[machine + 1].showCurrentState());

                }
               
                Console.WriteLine("What will you do?\n-Check the current status\n-Go to next state\n-End");
                input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine("What machine will you stop? ");
                    int stop = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Machine #" + stop + " is now deactivated");
                    //Console.WriteLine("invalid command");
                }
                Console.WriteLine("What will you do?\n-Check the current status\n-Go to next state\n-End");
                input = Console.ReadLine();
     if (input == "Go to next state")
     {
       Console.WriteLine("What machine will you advance?");
      int advances = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Machine #" + advances + " is" + machines[advance].Active());
     }
            }



        }
    }




class FSA
{
    bool active = false;
    int state;
    public FSA(int state)
    {
        this.state = state;
        // bool active = true;
    }
    public int goToNextState()
    {
        if (state == 0)
        {
            state = 1;
        }
        else if (state == 1)
        {
            state = 2;
        }
        else if (state == 2)
        {
            state = 3;
        }
        else if (state == 3)
        {
            state = 0;
        }
        return state;
    }
    public bool end()
    {
        if (state == 3)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    public int showCurrentState()
    {
        return state;
    }
    public bool Active()
    {
        return active;
    }

}
}
