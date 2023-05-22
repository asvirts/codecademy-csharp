using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!\nPlease enter a number to convert to coins: ");
      double UserNum = Convert.ToDouble(Console.ReadLine());

      double GoldCoins = Math.Floor(UserNum / 10);
      double remainder = GoldCoins % UserNum;

      double SilverCoins = Math.Floor(remainder % 5);
      double SilverRemainder = SilverCoins % 1;

      double BronzeCoins = Math.Floor(remainder % 5);

      Console.WriteLine($"{UserNum} cents is equal to {GoldCoins} gold coins, {SilverCoins} silver coins, and {BronzeCoins} bronze coins");
    }
  }
}
