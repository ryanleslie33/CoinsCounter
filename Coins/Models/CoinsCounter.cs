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
      int change =  Quarters +  Pennies + Nickles + Dimes;
      for(int index = 1; index <= dollars; index ++ )
      {
        if (index %25==0)
        {
          Quarters ++;
        }
        else if ( index %10==0 &&  index !=25 && index !=50)
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
      return change;
    }
  }
}
