class Program
{
    public static void Main(string[] args)
    {
        int red, green, blue;
        Console.Write("Enter a red value (0-255): ");
        red = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a green value (0-255): ");
        green = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a blue value (0-255): ");
        blue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The inverted color is red=" + (255 - red) + "," + " green=" + (255 - green) + "," + " blue=" + (255 - blue));
      
         
      Console.WriteLine ("With floating points, that would be red=" + ((255 - (float)red)/255) + "," + " green=" + ((255 - (float)green)/255) + "," + " blue=" + (255 - (float)blue)/255);
    }
}
