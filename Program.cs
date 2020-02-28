using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static Bread breadOrder = new Bread();
    public static Pastry pastryOrder = new Pastry();
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. Where we're more Canadian than French. Sorry!\nWe're currently running two specials:\nBuy 2 $5 loaves of bread get 1 free!\nFor Pastry Buy 1 for $2 or stock up with 3 for $5!");
      Console.Write("How many loaves of bread would you like: ");
      int breadLoaves = int.Parse(Console.ReadLine());
      breadOrder.Loaves = breadLoaves;
      breadOrder.BreadDeal();
      Console.Write("How many pastries would you like: ");
      int pastries = int.Parse(Console.ReadLine());
      pastryOrder.Pastries = pastries;
      pastryOrder.PastryDeal();
      Console.WriteLine($"Your order is {breadOrder.Loaves} loaves of bread and {pastryOrder.Pastries} pastries.\nYour total is ${pastryOrder.Price + breadOrder.Price}");
    }
  }
}