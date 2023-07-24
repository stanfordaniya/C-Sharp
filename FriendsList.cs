using System;
class Program
{
    public static void Main(string[] args)
    {

        int choice, index;
        string input;
        string[] name = new string[5];

        for (int i = 0; i < name.Length; i++)
        {
            name[i] = "";
        }

        Console.WriteLine("[Top 5 Friend’s List]");
        do
        {
            Console.Write("What would you like to do?\n1) Enter a friend’s name\n2) Replace a friend’s name\n3) Display your friends list\n4) Quit\nYour choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bool placed = false;
                    Console.Write("Enter a name: ");
                    input = Console.ReadLine();
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i] == "")
                        {
                            name[i] = input;
                            placed = true;
                            break;
                        }
                        else
                        {
                            if (name[i] == input)
                            {
                                placed = true;
                                Console.Write("Sorry, they’re already on the list!\n");
                                break;
                            }
                        }
                    }
                    if (placed == false)
                    {
                        Console.Write("Sorry, your friends list is full!\n");
                    }
                    break;

                case 2:
                    Console.Write("Enter a name: ");
                    string newFriend = Console.ReadLine();
                    Console.Write("Enter an index: ");
                    index = Convert.ToInt32(Console.ReadLine());
                
                if (1< index && index >5)
                {
                   Console.Write("Sorry, that’s an invalid command!\n");
                }
                else
                {
                    int actIndex = (index - 1);
                    string oldFriend = name[actIndex];
                    name[actIndex] = newFriend;
                }
                    
                    break;

                case 3:
                    Console.Write("Friend’s List: ");
                    Console.Write("\n");
                    for (int i = 0; i < name.Length; i++)
                    {
                        Console.Write((i + 1) + ") " + name[i]);
                        Console.Write("\n");
                    }
                    break;

            }

        } while (choice != 4);

    }
}
