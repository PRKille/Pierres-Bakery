using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static Bread levain = new Bread(7);
    public static Bread baguette = new Bread(3);
    public static Bread como = new Bread(5);
    public static Pastry pastryOrder = new Pastry();
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. Where we're more Canadian than French. Sorry!\nWe carry three types of bread:\nLevain, Como, and Baguettes.\nWe're currently running two specials:\nBuy 2 $5 loaves of bread get 1 free!\nFor Pastry Buy 1 for $2 or stock up with 3 for $5!");
      Order();
    }

    public static void Order()
    {
      Console.WriteLine("Would you like to order:\n\n[Levain] [Como] [Baguette] [Pastry]");
      string bread = Console.ReadLine().ToLower();
      if (bread == "levain")
      {
        OrderBread(levain, bread);
      }
      else if (bread == "como")
      {
        OrderBread(como, bread);
      }
      else if (bread == "baguette")
      {
        OrderBread(baguette, bread);
      }
      else if (bread == "pastry")
      {
        OrderPastry();
      }
      else
      {
        Order();
      }

    }
    public static void OrderBread(Bread bread, string type)
    {
      Console.Write($"How many loaves of {type} would you like: ");
      int breadLoaves = int.Parse(Console.ReadLine());
      bread.Loaves = breadLoaves;
      bread.BreadDeal();
      OrderMore();
     }

    public static void OrderPastry()
    {
      Console.Write("How many pastries would you like: ");
      int pastries = int.Parse(Console.ReadLine());
      pastryOrder.Pastries = pastries;
      pastryOrder.PastryDeal();
      OrderMore();
    }

    public static void OrderMore()
    {
      Console.Write("Would you like to order more Y/N: ");
      string answer = Console.ReadLine().ToLower();
      if (answer == "y" || answer == "yes")
      {
        Order();
      }
      else if (answer == "n" || answer == "no")
      {
        Console.WriteLine(Total());
      }
      else
      {
        OrderMore();
      }
    }

    public static string Total()
    {
      string orderTypes = $"Your order is:\n";
      if (levain.Loaves != 0)
      {
        orderTypes += levain.Loaves +" loaves of levain.\n";
      }
      if (baguette.Loaves != 0)
      {
        orderTypes += baguette.Loaves +" baguettes.\n";
      }
      if (como.Loaves != 0)
      {
        orderTypes += como.Loaves +" loaves of como.\n";
      }
      if (pastryOrder.Pastries != 0)
      {
        orderTypes += pastryOrder.Pastries +" pastries.";
      }
      return $"{orderTypes}\nYour total is ${pastryOrder.Price+levain.Total+baguette.Total+como.Total}";
    }
  }
}