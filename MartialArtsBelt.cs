class Assignment3B
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Martial Arts Belt]\nWhat belt grade are you?");
        int belt = Convert.ToInt32(Console.ReadLine());
        switch (belt)
        {
            case 0:
                Console.Write("You have a black belt,\nwith 0 stripes!");
                break;
            case 1:
                Console.Write("You have a brown belt,\nwith 2 stripes!");
                break;
            case 2:
                Console.Write("You have a brown belt,\nwith 1 stripes!");
                break;
            case 3:
                Console.Write("You have a green belt,\nwith 2 stripes!");
                break;
            case 4:
                Console.Write("You have a green belt,\nwith 1 stripes!");
                break;
            case 5:
                Console.Write("You have a blue belt,\nwith 2 stripes!");
                break;
            case 6:
                Console.Write("You have a blue belt,\nwith 1 stripes!");
                break;
            case 7:
                Console.Write("You have a yellow belt,\nwith 2 stripes!");
                break;
            case 8:
                Console.Write("You have a yellow belt,\nwith 1 stripes!");
                break;
            case 9:
                Console.Write("You have a white belt,\nwith 1 stripes!");
                break;
            case 10:
                Console.Write("You have a white belt,\nwith 0 stripes!");
                break;
            default:
        Console.WriteLine("You have no belt...");
        break;

        }
  }
}
