
class Program
{
    public static void Main(string[] args)
    {
        string purchase, ePurchase; ;
        int many, eMany;
        double cost, eCost;
        Console.Write("What're you buying? ");
        purchase = Console.ReadLine();
        Console.Write("How many? ");
        many = Convert.ToInt32(Console.ReadLine());
        Console.Write("What do they cost? ");
        cost = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nWhat else're you buying? ");
        ePurchase = Console.ReadLine();
        Console.Write("How many? ");
        eMany = Convert.ToInt32(Console.ReadLine());
        Console.Write("What do they cost? ");
        eCost = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("\nYour list:\n----");
       Console.WriteLine(purchase +" (" + many + ")");
      Console.WriteLine("$"+cost + " ($" + cost * many + " total)");

      Console.WriteLine("\n"+ ePurchase +" (" + eMany + ")");
      Console.WriteLine("$"+eCost + " ($" + eCost * eMany + " total)");
      Console.WriteLine("\nTotal Cost: $" +  (eCost * eMany + cost * many));
      Console.WriteLine("----");
      
    }
}
