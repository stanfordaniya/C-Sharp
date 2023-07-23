
using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] firstName = { "Mark", "Amanda", "Norman", "Steven", "Jesse" };
        string[] lastName = { "Sloan", "Bentley", "Briggs", "Sloan", "Travis" };
        int[] age = { 67, 33, 47, 35, 24 };
        string[] occupation = { "Chief of Internal Medicine", "Pathologist", "Administrator", "Hospital Security", "Surgeon Intern" };
        string[] license = { "TRUE", "TRUE", "FALSE", "FALSE", "TRUE" };
        int[] id = { 0, 1, 2, 3, 4 };
        int choice, tag;

        Console.WriteLine("[Community General Hospital Directory]");
        do
        {
            Console.WriteLine("1) List all employees\n2) Search employee records by ID\n3) Search employee records by Last Name\n4) Quit");
            Console.Write("Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 3)
            {
                Console.Write("Last Name: ");
                string lName = Console.ReadLine();
              bool flag = false;
                for (int i = 0; i < 5; i++)
                {
                    if (lastName[i].Equals(lName))
                    {
                        Console.Write("\n#" + id[i] + ": " + lastName[i] + ", " + occupation[i] + ", Medical Licence:" + license[i]);
                      flag = true;
                    }
                   
                }
              if(flag == false){
                Console.Write("No Records Found!");
              }
            }
          else if (choice == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("#" + id[i] + ": " + firstName[i] + " " + lastName[i] + ", " + occupation[i] + ", Medical Licence:" + license[i]);
                  Console.Write("\n");
                }

            }


          else if (choice == 2)
            {

                Console.Write("ID: ");
                tag = Convert.ToInt32(Console.ReadLine());

                while (tag >= 4)
                {
                    Console.WriteLine("Invalid ID!");
                    Console.Write("ID: ");
                    tag = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("#" + id[tag] + ": " + firstName[tag] +" "+ lastName[tag] + ", " + occupation[tag] + ", Medical Licence:" + license[tag]);
            }




          else if (choice == 4)
            {
                Console.Write("[Closing Directory...]");
            }
          else{
            Console.Write("No option " + choice+"!");
          }
        } while (choice != 4);

    }
}
