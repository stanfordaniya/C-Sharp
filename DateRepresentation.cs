
using System;

class Program {
  public static void Main (string[] args) {
    int day, month, year;
    string sMonth;
    Console.Write("Enter the day (number): ");
    day =  Convert.ToInt32(Console.ReadLine());
    Console.Write ("Enter the month (number): ");
    month =  Convert.ToInt32(Console.ReadLine());
    Console.Write ("Enter the month (String): ");
    sMonth = Console.ReadLine();
    Console.Write ("Enter the year (number): ");
    year =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Here are some ways to represent the date:");
    Console.WriteLine(month +"/"+ day +"/" + year);
    Console.WriteLine(year +"/"+ day +"/" + month);
    Console.WriteLine(day +"/"+ month +"/" + year);
    Console.WriteLine(sMonth + " " + month + ", " + year);
    Console.WriteLine(month + " " + sMonth + " " + year);
  }
}
