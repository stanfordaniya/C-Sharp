using System;

class Program {
  public static void Main (string[] args) {
    //Total time in seconds = ((Hours * 3600) + (Minutes * 60) + Seconds) / Playback Speed
    float time, speed;
    Console.WriteLine ("[Fast-Forward]");
    Console.Write("What is the original video time? ");
    time = float.Parse(Console.ReadLine());
    Console.Write("What is the playback speed factor? ");
    speed = float.Parse(Console.ReadLine());
    int seconds, minutes;
    minutes = (int)time;
    seconds = (int)Math.Round((time - minutes) * 100);
    int totaltime;
    int newtime;
   
    
    totaltime = (minutes*60) + seconds;
     newtime = (int)(totaltime/speed);
    Console.WriteLine("The new video time would be "+ newtime +" second(s).");
    
    Console.WriteLine("That saves you "+ (totaltime - newtime) +" second(s) from the original video speed.");

  
    
  }
}
