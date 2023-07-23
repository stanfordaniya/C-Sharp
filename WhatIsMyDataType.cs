using System;

public class Program
{

    public static void Main(String[] args)
    {

        string userChoice = string.Empty;
        int userInt;
        string userStr = string.Empty;
        bool userBool = false;
        float userFloat = 0;
        char userChar;
        Console.Write("[What's my datatype?]\n" +
                "Enter an int: ");
      
        userInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a string: ");
        userStr = Console.ReadLine();
        Console.Write("Enter a float: ");
        userFloat =  float.Parse(Console.ReadLine());
        Console.Write("Enter a char: ");
        userChar = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter a boolean: ");
         userBool = Boolean.Parse(Console.ReadLine());


        Console.Write("\nWhat datatype do you want to check? ");
        userChoice = Console.ReadLine();
        Console.WriteLine();
        switch (userChoice)
        {
            case "int":
                Console.Write("'" + WhatsMyType3(userInt) + "'" + " is an int value!");
                break;
            case "string":
                Console.Write("'" + WhatsMyType4(userStr) + "'" + "  is a string value!");
                break;
            case "float":
                Console.Write("'" + WhatsMyType2(userFloat) + "'" + "  is a float value!");
                break;
            case "char":
                Console.Write("'" + WhatsMyType1(userChar) + "'" + "  is a char value!");
                break;
            case "boolean":
                Console.Write("'" + WhatsMyType(userBool) + "'" + " is a boolean value!");
                break;


        }
    }

    private static string WhatsMyType4(string str)
    {
        return str;
    }

    private static int WhatsMyType3(int num)
    {
        return num;
    }

    private static float WhatsMyType2(float floatNum)
    {
        return floatNum;
    }

    private static char WhatsMyType1(char charInput)
    {
        return charInput;
    }

    private static bool WhatsMyType(bool isTrue)
    {
        return isTrue;
    }


}
