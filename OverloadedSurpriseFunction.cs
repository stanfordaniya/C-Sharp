
using System;

class Program
{
    public static void Main(string[] args)
    {
        string type;
      
     
        Console.WriteLine("[Overloaded Surprise Function]");
        Console.Write("What data type do you want to enter? ");
        type = Console.ReadLine();
    

  switch(type){

  case "string":
    string stringOne, stringTwo;
     Console.Write("Value #1: ");
        stringOne = Console.ReadLine();
        Console.Write("Value #2: ");
        stringTwo = Console.ReadLine();
     Console.WriteLine("Calling surprise_function()...");
    Console.WriteLine("The result is " + surprise_function(stringOne, stringTwo));
    break;

  case "float":
    float floatOne, floatTwo;
     Console.Write("Value #1: ");
        floatOne = float.Parse(Console.ReadLine());
        Console.Write("Value #2: ");
        floatTwo = float.Parse(Console.ReadLine());
     Console.WriteLine("Calling surprise_function()...");
    Console.WriteLine("The result is " + surprise_function(floatOne, floatTwo));
    break;

  case "char":
    char charOne, charTwo;
     Console.Write("Value #1: ");
        charOne = char.Parse(Console.ReadLine());
        Console.Write("Value #2: ");
        charTwo = char.Parse(Console.ReadLine());
     Console.WriteLine("Calling surprise_function()...");
    Console.WriteLine("The result is " + surprise_function(charOne, charTwo));
    break;

  case "double":
    double doubleOne, doubleTwo;
     Console.Write("Value #1: ");
        doubleOne = Convert.ToDouble(Console.ReadLine());
        Console.Write("Value #2: ");
        doubleTwo = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Calling surprise_function()...");
    Console.WriteLine("The result is " + surprise_function(doubleOne, doubleTwo));
    break;
    
  case "integer":
    int intOne, intTwo;
     Console.Write("Value #1: ");
        intOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Value #2: ");
        intTwo = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Calling surprise_function()...");
    Console.WriteLine("The result is " + surprise_function(intOne, intTwo));
    break;

  case "boolean":
    bool boolOne, boolTwo;
     Console.Write("Value #1: ");
        boolOne = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Value #2: ");
        boolTwo = Convert.ToBoolean(Console.ReadLine());
     Console.WriteLine("Calling surprise_function()...");
    Console.WriteLine("The result is " + surprise_function(boolOne, boolTwo));
    break;
    
  }
       
    }
 
        public static int surprise_function(int a, int b)
        {
          int sum = a + b;
          return sum;
            
           
        }
  public static string surprise_function(char a, char b)
        {
          return a + ""+ b;
            
           
        }
        public static float surprise_function(float a, float b)
        {
          return a / b;
           

        }
        public static double surprise_function(double a, double b)
        {
          return a % b;
          

        }
        public static String surprise_function(string a, string b)
        {
          return a + b;
          

        }
        public static bool surprise_function(bool a, bool b)
        {
        if (a && b)
    {
              return true;
    }
    else
    {
        return false;
    }
        }
   
}
