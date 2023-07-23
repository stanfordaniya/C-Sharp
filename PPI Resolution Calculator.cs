using System;


class Assignment1A
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the width (in pixels): ");
        int width = Convert.ToInt32(Console.ReadLine());
        //Convert.ToInt32 helps convert an inputed intger
        Console.WriteLine("Enter the height (in pixels): ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the resolution (PPI): ");
        int resolution = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("At " + resolution + " PPI the image is " + ((double)width / resolution) + '"' + " wide by " + ((double)height / resolution) + '"' + " high");
    }
}
