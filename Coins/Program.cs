using System;


namespace CoinsName
{

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("enter amount of pennies");
      string input = Console.ReadLine();
      int dollarAmount = int.Parse(input);

      int Count = CoinsCount.ReturnCount(dollarAmount);
      Console.WriteLine(Count);
    }
  }
}
