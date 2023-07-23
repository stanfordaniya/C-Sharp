
using System;

class Program {
  public static void Main (string[] args) {
    int first;
    int second;
    int modulo;
  
    Console.Write("First number: ");
    first = Convert.ToInt32(Console.ReadLine());
 Console.Write("Second number: ");
    second = Convert.ToInt32(Console.ReadLine());
     Console.Write("Number for Modulo Operation: ");
    modulo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(first + " + " + second +" = "+ (first + second)+". "+ "The remainder if divided by "+ modulo + " is " +(first+second)%modulo+".");
    Console.WriteLine(first + " - " + second + " = "+ (first - second)+". "+ "The remainder if divided by "+ modulo + " is " +(first-second)%modulo+".");
    Console.WriteLine(first + " * " + second +" = "+ (first * second)+". "+ "The remainder if divided by "+ modulo + " is " +(first*second)%modulo+".");
    Console.WriteLine(first + " / " + second +" = "+ (first / second)+" (Approximately). "+ "The remainder if divided by "+ modulo + " is " +(first/second)%modulo+".");
    
  }
}
