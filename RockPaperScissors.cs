using System;

class Program
{
    public static void Main(string[] args)
    {
        int user, choice;
        string attack;
        bool continueGame = true;
        RoshamboPlayer p1 = new RoshamboPlayer("R. Dorothy", 30, 40);
        RoshamboPlayer p2 = new RoshamboPlayer("Johnny 5", 40, 85);
        RoshamboPlayer opponent = null;

        Console.WriteLine("[Ro-Sham-Bo Player]");

        Console.WriteLine("Who do you want to face?");
        Console.WriteLine("1) R. Dorothy\n2) Johnny 5");
        Console.Write("Oppenent: ");
        user = Convert.ToInt32(Console.ReadLine());
        if (user == 1)
        {

            opponent = p1;
        }
        else if (user == 2)
        {

            opponent = p2;

        }
        Console.WriteLine("Your opponent is " + opponent.getName());
        while (continueGame)
        {
            Console.Write("\n1) Play a round?\n2) Quit?\n");
            Console.Write("Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {

                Console.Write("Enter an attack: ");
                attack = Console.ReadLine();
                while (!(attack == "Ro" || attack == "Sham" || attack == "Bo"))
                {
                    Console.WriteLine("Invalid Attack!");
                    Console.WriteLine("Enter an attack: ");
                    attack = Console.ReadLine();
                }

                bool playerWin = opponent.playRound(attack);
                if (playerWin)
                {
                    Console.Write(opponent.getName() + " chose " + opponent.getAttack() + " You win!");
                }
                else
                {
                    Console.Write(opponent.getName() + " chose " + opponent.getAttack() + " you lose...");
                }

            }


            else
            {
                continueGame = false;
                Console.Write("\nGame Over!");
            }
        }
    }
}


class RoshamboPlayer
{
    public string PlayerName;
    public string Attack;
    public int RoLimit;
    public int ShamBoLimit;
    public RoshamboPlayer(string PlayerName, int RoLimit, int ShamBoLimit)
    {
        this.PlayerName = PlayerName;
        this.RoLimit = RoLimit;
        this.ShamBoLimit = ShamBoLimit;
    }

    public bool playRound(string round)
    {
        Random rnd = new Random();
        int random = rnd.Next(101);
        if (random >= 0 && random <= RoLimit)
        {
            Attack = "Ro";
        }
        else if (random >= RoLimit && random <= ShamBoLimit)
        {
            Attack = "Sham";
        }
        else if (random > ShamBoLimit)
        {
            Attack = "Bo";
        }
        if(round == "Ro"&& Attack == "Bo"){
          return true;
        }
      else if(round == "Bo"&& Attack == "Sham"){
          return true;
        }
      else if(round == "Sham"&& Attack == "Ro"){
          return true;
        } else{
        return false;
        }
    }
    public string getName()
    {
        return PlayerName;
    }
    public string getAttack()
    {
        return Attack;
    }

}
