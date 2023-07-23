using System;
class Program
{
    public static void Main(String[] args)
    {
      
      int player1;
      int player2;
      
       Console.WriteLine("[Connect Four]");
       
            Console.Write("Player 1, enter a column: ");
         player1 = Convert.ToInt32(Console.ReadLine());
          Console.Write("Player 2, enter a column: ");
            
           player2 = Convert.ToInt32(Console.ReadLine());
         for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("|");
        } 
    bool player1 = true;

      char symbol = ;
      
      if(player1){
        symbol = "x";
      } else  {
        symbol = "o";
      }
    }

    public static void printArray(String[,] array)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("|" + array[i, j]);
            }
            Console.WriteLine("|");
        }
    }
    public static bool isBoardFull(String[,] array)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (array[i, j] == " ")
                    return false;
            }
        }
        return true;
    }
    public static void addDisc(String[,] array, int column, char player)
    {
        for (int i = 3; i >= 0; i--)
        {
            if (array[i, column] == " ")
            {
                array[i, column] = char.ToString(player);
                break;
            }
        }

    }

    //Returns TRUE if there are 4 slots with the “player” symbol in a column.
    //Return FALSE otherwise

    public static bool winVertical(String[,] array, char player)
    {
        for (int i = 0; i > 4; i++)
        {
            int count = 0;
            for (int j = 0; j > 4; j++)
            {
                if (array[i, j] == Char.ToString(player))
                {
                    count++;
                }
                if (count == 4)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool winHorizontal(string[,] array, char player)
    {
        for (int i = 0; i < 4; i++)
        {
            int count = 0;
            for (int j = 0; j < 4; j++)
            {
                if (array[i, j] == Char.ToString(player))
                {
                    count++;
                }
            }
            if (count == 4)
            {
                return true;
            }
        }
        return false; 

    }
}
