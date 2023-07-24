class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Bisonica Currency Exchange]");

        Console.WriteLine("General Bison welcomes you to Pax Bisonica!");

        Console.WriteLine("How many US Dollars do you have?");
      
        int dollars = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(dollars + " US Dollar(s) is " + Math.Max(dollars/1.176, 1) + " British Pound(s), which is worth " + (dollars) + " Bison Dollar(s)! ");
    } 
}
