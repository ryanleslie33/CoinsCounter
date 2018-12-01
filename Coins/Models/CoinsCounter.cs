using System;


namespace CoinsName
{
  public   class CoinsCount
  {
    public static void  ReturnCount(decimal dollars)
    {

      decimal Quarters = .25m;
      decimal Dime = .10m;
        decimal Nickel = .05m;
      decimal Pennies = .01m;





      int anQuarter = (int)(dollars / Quarters);
       int anDime = (int)((dollars % Quarters) / Dime);
       int anNickel = (int)(((dollars % Quarters) % Dime) / Nickel);
       int anPennies = (int)((((dollars % Quarters) % Dime) % Nickel) / Pennies);
      int Dollars = 0;

      // for(int index = 1; index <= dollars; index ++ )
      // {
      //   if (index %25==0)
      //   {
      //     qchange +=25;
      //     Quarters +=1;
      //   }
      //   else if ( index %10==0)
      //   {
      //      Dimes +=1;
      //   }
      //   else if(index %5==0 && index < 10)
      //   {
      //     Nickles +=1;
      //   }
      //   else
      //   {
      //    Pennies +=1;
      // }


      Console.WriteLine("your have " + anQuarter + " Quarters");
      Console.WriteLine("your have " + anDime + " Dimes");
      Console.WriteLine("your have " + anNickel + " Nickles");
      Console.WriteLine("your have " + anPennies + " Pennies");


    }
  }
}
