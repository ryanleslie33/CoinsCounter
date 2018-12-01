using System;


namespace CoinsName
{

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("enter amount of dollars");
      string input = Console.ReadLine();
      decimal dollarAmount = decimal.Parse(input);

     CoinsCount.ReturnCount( dollarAmount);
    
    }
  }
}
