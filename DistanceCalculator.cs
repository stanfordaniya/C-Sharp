using System;

class Program {
  public static void Main (string[] args) {
    float meters;
    float distance = 0.0000000026f;
    int crackers = 40;
    float totaldistance,totalcrackers;
    
Console.Write("[Distance Calculator]\nHow many meters? ");
     meters = float.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    totaldistance = (float)(distance * meters);
    totalcrackers = crackers * meters;
    
    Console.WriteLine(meters + " meter(s) is...");
    Console.WriteLine("..." + totaldistance +" distance from the Moon");
    Console.WriteLine("..." + totalcrackers +" Animal Crackers long");
  }
}
