using System;

class Program
{
    public static void Main(string[] args)
    {
      
      Console.WriteLine("Please enter a letter: ");  
     
      char a = char.Parse(Console.ReadLine());
      int i = a;
      Console.WriteLine("The next three characters after "+ a + " are "+ (char)(i+1)+ ", "+(char)(i+2)+", "+(char)(i+3)+ ".");
  }
}
