using System;


namespace CoinsName
{
  public   class CoinsCount
  {
    public static int ReturnCount(int dollarAmount)
    {
      int dollars = dollarAmount;
      int Quarters = 0;
      int Pennies = 0;
      int Nickles = 0;
      int Dimes = 0;
      // int Dollars = 0;
      int qchange = 0;
      for(int index = 1; index <= dollars; index ++ )
      {
        if (index %25==0)
        {
          qchange +=25;
          Quarters +=1;
        }
        else if ( index %10==0)
        {
           Dimes +=1;
        }
        else if(index %5==0 && index < 10)
        {
          Nickles +=1;
        }
        else
        {
         Pennies +=1;
      }

      }
      Console.WriteLine("your have " + Quarters + " Quarters");
      Console.WriteLine("your have " + Dimes + " Dimes");
      Console.WriteLine("your have " + Nickles + " Nickles");
      Console.WriteLine("your have " + Pennies + " Pennies");
      return Dimes;

    }
  }
}
