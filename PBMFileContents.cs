
using System;

class Program
{
    public static void Main(string[] args)
    {
        int sizeSquare;
        int sizeBorder;
        int colorSquare;
        int colorBorder; 
        int TotalSize;

        Console.Write("Enter the size of the square: ");
        sizeSquare = Convert.ToInt32(Console.ReadLine());
        while (sizeSquare < 0)
        {
            Console.WriteLine("Invalid Input");
            Console.Write("Enter the size of the square: ");
            sizeSquare = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Enter the size of the border: ");
        sizeBorder = Convert.ToInt32(Console.ReadLine());
        while (sizeBorder < 0)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the size of the border: ");
            sizeBorder = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Enter the color of the square: ");
        colorSquare = Convert.ToInt32(Console.ReadLine());
        while (colorSquare != 0 && colorSquare != 1)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the color of the square: ");
            colorSquare = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Enter the color of the border: ");
        colorBorder = Convert.ToInt32(Console.ReadLine());
        while (colorBorder != 0 && colorBorder != 1)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the color of the border: ");
            colorBorder = Convert.ToInt32(Console.ReadLine());
        }

        TotalSize = sizeSquare + (2 * sizeBorder);
        Console.WriteLine("PBM File Contents:");
      Console.WriteLine("P1");
      Console.WriteLine(TotalSize + " " + TotalSize);

        if (sizeBorder != 0)
        {
            for (int i = 0; i < sizeBorder; i++)
            {
                for (int x = 0; x < TotalSize; x++)
                {
                    Console.Write("0");
                }
                Console.Write("\n");
            }
        }

        for (int i = 0; i < sizeSquare; i++)
        {
            int x = 0;
            while (x < sizeBorder)
            {

                Console.Write(colorBorder);
                x++;
            }
            for (int j = 0; j < sizeSquare; j++)
            {
                Console.Write(colorSquare);

            }

            x = 0;
            while (x < sizeBorder)
            {
                Console.Write(colorBorder);
                x++;
            }
            Console.WriteLine(" ");
        }
        if (sizeBorder != 0)
        {
            for (int i = 0; i < sizeBorder; i++)
            {
                for (int x = 0; x < TotalSize; x++)
                {
                    Console.Write("0");
                }
                Console.Write("\n");

            }
        }
    }
}
