using System;

class Program
{
    public static void Main(string[] args)
    {
        string select, select2;
        Console.WriteLine("[Cretaceous Park Dialog]");
        Console.WriteLine("Oh no, the power has gone out at Cretaceous Park!\n1) What does that mean?\n2) No, I just turned the light off.");
        select = Console.ReadLine();

        if (select == "No, I just turned the light off")
        {
            Console.WriteLine("\nOh thank goodness!");
        }
      
        if (select == "What does that mean?")
        {
            Console.WriteLine("\nThe dinosaurs will get loose... again...");
            Console.WriteLine("1) Life finds a way...\n2) What do we do?");
            select2 = Console.ReadLine();
            if (select2 == "Life finds a way...")
            {
                Console.WriteLine("\nThat’s not helpful right now!\nWe have to evacuate the park!");
            }
          else if (select2 == "What do we do?"){
                Console.WriteLine("\nWe have to evacuate the park!");
            }
        }


    }
}
