using System;

class Program {
  public static void Main (string[] args) {
    float inputx, inputy;
    Console.WriteLine ("[Cretaceous Park GIS]");
    Console.Write("X Coordinate: ");
    inputx = float.Parse(Console.ReadLine());
Console.Write("Y Coordinate: ");
    inputy = float.Parse(Console.ReadLine());
    
    if(inputx > 8 || inputy < 0 || inputx < 0 || inputy > 8){
      Console.WriteLine("WARNING: You have left the boundaries of the park.\nPlease return immediately.");
    } 
    else if(inputx >= 2 && inputx <= 4 && inputy >= 2 && inputy <= 6){
      Console.WriteLine("\nYou are at the T. Rex Lake");
    }
    else if(inputx >= 5 && inputx <=8 && inputy >= 0 && inputy <= 2){
      Console.WriteLine("\nYou are at the Pterodactyl Aviary");
    }
    else if(inputx >= 6 && inputx <= 8 && inputy >= 2 && inputy <= 4){
      Console.WriteLine("\nYou are at the Visitor’s Center");
    }
    else if(inputx >= 5 && inputx <= 8 && inputy >= 5 && inputy <= 8){
      Console.WriteLine("\nYou are at the Deinonychus Pen");
    } 
    else{
      Console.WriteLine("\nYou are at the Triceratops Grasslands");
    }
  }
}
