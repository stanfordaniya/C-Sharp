
using System;

class Program {
  public static void Main (string[] args) {
    int width,height,fillColor;
    int choice;
    int row, newColor, column, length;

    Console.WriteLine ("[Image Manipulation Program]");
    Console.Write("Enter an image width: ");
    width = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter an image height: ");
    height = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter the fill color: ");
    fillColor = Convert.ToInt32(Console.ReadLine());
    int [,] arr = new int[height, width];
    for(int i = 0; i < height; i++ ){
      for(int j = 0; j < width; j++){
        arr[i,j] = fillColor;
      }
    }
    do{
      Console.Write("What will you do?\n1) Fill in a pixel\n2) Fill in a line\n3) Print the image\n4) Quit");
      Console.Write("\nChoice? ");
      choice = Convert.ToInt32(Console.ReadLine());

      if(choice == 1){
        Console.Write("Row: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Column: ");
        column = Convert.ToInt32(Console.ReadLine());
        Console.Write("New Color: ");
        newColor = Convert.ToInt32(Console.ReadLine());
       arr [row,column] = newColor;
        
  }
      
      
      if(choice == 2){
        Console.Write("Row: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Column: ");
        column = Convert.ToInt32(Console.ReadLine());
        Console.Write("New Color: ");
        newColor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Legnth: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Direction: ");
       string direction = Console.ReadLine();
        if(direction == "up"){
          for (int i = 0; i < height; i++)
        {
           
            for (int j = 0; j < width; j++)
            {
                Console.Write(arr[i,j] + " ");

            }

           
            Console.WriteLine(" ");
        }
        }
      }
      
      if(choice == 3){

        Console.WriteLine("\nPBM File Contents:");
      Console.WriteLine("P1");
      Console.WriteLine(width + " " + height);
        Console.WriteLine("255");
        

        for (int i = 0; i < height; i++)
        {
           
            for (int j = 0; j < width; j++)
            {
                Console.Write(arr[i,j] + " ");

            }

           
            Console.WriteLine(" ");
        }
        
    }
      if(choice == 4){
        Console.Write("\n[Exiting KSU Image Manipulation Program]");
      }
    }while(choice != 4);
  }
}
