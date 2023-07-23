using System;

class Assignment5B
{
    public static void Main(string[] args)
    {
        int Month;
        int Day;
        int row = 12;
        int column = 31;
        Console.WriteLine("[What’s your sign?]");

        Console.Write("What month were you born in? ");
        Month = Convert.ToInt32(Console.ReadLine());
        if (0 <= Month && Month >= 13)
        {
            Console.Write("That is not a valid month...");
        }

        Console.Write("And what day? ");
        Day = Convert.ToInt32(Console.ReadLine());
        if (0 <= Day && Day >= 32)
        {
            Console.Write("That is not a valid day...");
        }

        string[,] zodiac = new string[row, column];
        for (row = 0; row < 12; row++)
        {
            for (column = 0; column < 31; column++)
            {

                if (row == 2 && column >= 20 && column <= 32)
                {
                    zodiac[row, column] = "Aries";
                }
                else if (row == 3 && column >= 0 && column <= 18)
                {
                    zodiac[row, column] = "Aries";
                }
                else if (row == 3 && column >= 19 && column <= 32)
                {
                    zodiac[row, column] = "Taurus";
                }
                else if (row == 4 && column >= 0 && column <= 19)
                {
                    zodiac[row, column] = "Taurus";
                }
                else if (row == 4 && column >= 20 && column < 32)
                {
                    zodiac[row, column] = "Gemini";
                }
                else if (row == 5 && column >= 0 && column < 21)
                {
                    zodiac[row, column] = "Gemini";
                }
                else if (row == 5 && column >= 21 && column <= 32)
                {
                    zodiac[row, column] = "Cancer";
                }
                else if (row == 6 && column >= 0 && column < 22)
                {
                    zodiac[row, column] = "Cancer";
                }
                else if (row == 6 && column >= 22 && column <= 32)
                {
                    zodiac[row, column] = "Leo";
                }
                else if (row == 7 && column >= 0 && column < 22)
                {
                    zodiac[row, column] = "Leo";
                }
                else if (row == 7 && column >= 22 && column < 32)
                {
                    zodiac[row, column] = "Virgo";
                }
                else if (row == 8 && column >= 0 && column < 22)
                {
                    zodiac[row, column] = "Virgo";
                }
                else if (row == 8 && column >= 22 && column < 32)
                {
                    zodiac[row, column] = "Libra";
                }
                else if (row == 9 && column >= 0 && column < 23)
                {
                    zodiac[row, column] = "Libra";
                }
                else if (row == 9 && column >= 23 && column < 32)
                {
                    zodiac[row, column] = "Scorpius";
                }
                else if (row == 10 && column >= 0 && column < 21)
                {
                    zodiac[row, column] = "Scorpius";
                }
                else if (row == 10 && column >= 21 && column < 32)
                {
                    zodiac[row, column] = "Sagittarius";
                }
                else if (row == 11 && column >= 0 && column < 21)
                {
                    zodiac[row, column] = "Sagittarius";
                }
                else if (row == 11 && column >= 21 && column < 32)
                {
                    zodiac[row, column] = "Capricornus";
                }
                else if (row == 0 && column >= 0 && column < 19)
                {
                    zodiac[row, column] = "Capricornus";
                }
                else if (row == 0 && column >= 19 && column < 32)
                {
                    zodiac[row, column] = "Aquarius";
                }
                else if (row == 1 && column >= 0 && column < 17)
                {
                    zodiac[row, column] = "Aquarius";
                }
                else if (row == 1 && column >= 17 && column < 32)
                {
                    zodiac[row, column] = "Pisces";
                }
                else if (row == 2 && column >= 0 && column < 20)
                {
                    zodiac[row, column] = "Pisces";
                }
            }
        }

        Console.WriteLine("Your sign is " + zodiac[Month - 1, Day - 1] + "!");

    }
}
