using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter your average lab grade: ");
    int labGrade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter your average assignment grade: ");
    int assingmentGrade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your weighted midterm exam average is: ");
    float midtermGrade = float.Parse(Console.ReadLine());
    Console.WriteLine("Your weighted final exam average is: ");
    float finalExam = float.Parse(Console.ReadLine());
  

    Console.WriteLine("Your weighted lab average is " + labGrade * .1);
    Console.WriteLine("Your weighted assignment average is " + assingmentGrade * .4);
    Console.WriteLine("Your weighted midterm exam average is " + midtermGrade * .2);
    Console.WriteLine("Your weighted final exam average is " + finalExam * .3);
    Console.WriteLine("Adding numbers...");
    Console.WriteLine("Your final grade in CSE 1321L is");
    Console.WriteLine( labGrade * .1 + assingmentGrade * .4 + midtermGrade * .2 + finalExam * .3);
     
      
    
  }
}
