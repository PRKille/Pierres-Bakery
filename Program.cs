using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    private static Bread _levain = new Bread(7);
    private static Bread _baguette = new Bread(3);
    private static Bread _como = new Bread(5);
    private static Pastry _pastryOrder = new Pastry();

    public static void Main()
    {
      Console.BackgroundColor = ConsoleColor.Green;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine(@".______    __   _______ .______      .______       _______ __     _______.   .______        ___       __  ___  _______ .______     ____    ____  __             
|   _  \  |  | |   ____||   _  \     |   _  \     |   ____(_ )   /       |   |   _  \      /   \     |  |/  / |   ____||   _  \    \   \  /   / |  | 
|  |_)  | |  | |  |__   |  |_)  |    |  |_)  |    |  |__   |/   |   (----`   |  |_)  |    /  ^  \    |  '  /  |  |__   |  |_)  |    \   \/   /  |  | 
|   ___/  |  | |   __|  |      /     |      /     |   __|        \   \       |   _  <    /  /_\  \   |    <   |   __|  |      /      \_    _/   |  | 
|  |      |  | |  |____ |  |\  \----.|  |\  \----.|  |____   .----)   |      |  |_)  |  /  _____  \  |  .  \  |  |____ |  |\  \----.   |  |     |__| 
| _|      |__| |_______|| _| `._____|| _| `._____||_______|  |_______/       |______/  /__/     \__\ |__|\__\ |_______|| _| `._____|   |__|     (__)");
      Console.ResetColor();
      Console.Write("\n\nWelcome to Pierre's Bakery. Where we're more Canadian than French. Sorry!\nWe carry three types of bread:\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write($"\nLevain, Como, and Baguettes.\n");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"\nWe're currently running two specials:\nBuy 2 loaves of the same bread get a third free!\nFor Pastry Buy 1 for $2 or stock up with 3 for $5!");
      Order();
    }

    public static void Order()
    {
      Console.WriteLine("Would you like to order:\n\n");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("[Levain] [Como] [Baguette] [Pastry] or type [View] to look at your order.");
      Console.WriteLine("You may remove items by going to thier order screen and placing '-' in front of the number to remove.")
      Console.ResetColor();
      string bread = Console.ReadLine().ToLower();
      if (bread == "levain")
      {
        OrderBread(_levain, bread);
      }
      else if (bread == "como")
      {
        OrderBread(_como, bread);
      }
      else if (bread == "baguette")
      {
        OrderBread(_baguette, bread);
      }
      else if (bread == "pastry")
      {
        OrderPastry();
      }
      else if (bread == "view")
      {
        Console.WriteLine(Total());
        Order();
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
      if ((bread.Loaves + breadLoaves) < 0 )
      {
        Console.WriteLine("We don't buy bread. Make sure you aren't taking out more than you have!");
      }
      else
      {
        bread.Loaves += breadLoaves;
      }
      OrderMore();
     }

    public static void OrderPastry()
    {
      Console.Write("How many pastries would you like: ");
      int pastries = int.Parse(Console.ReadLine());
      if ((_pastryOrder.Pastries + pastries) < 0 )
      {
        Console.WriteLine("We don't buy pastries. Make sure you aren't taking out more than you have!");
      }
      else
      {
        _pastryOrder.Pastries = pastries;
      }
      OrderMore();
    }

    public static void OrderMore()
    {
      Console.Write("Would you like to continue shopping? Y/N: ");
      string answer = Console.ReadLine().ToLower();
      if (answer == "y" || answer == "yes")
      {
        Order();
      }
      else if (answer == "n" || answer == "no")
      {
        Console.WriteLine(Total());
        Console.WriteLine("Thank you for shopping with us!");
        Environment.Exit(0);
      }
      else
      {
        OrderMore();
      }
    }

    public static string Total()
    {
      string orderTypes = $"Your order is:\n";
      if (_levain.Loaves != 0)
      {
        _levain.BreadDeal();
        orderTypes += _levain.Loaves +" loaves of levain.\n";
      }
      if (_baguette.Loaves != 0)
      {
        _baguette.BreadDeal();
        orderTypes += _baguette.Loaves +" baguettes.\n";
      }
      _como.BreadDeal();
      if (_como.Loaves != 0)
      {
        orderTypes += _como.Loaves +" loaves of como.\n";
      }
      if (_pastryOrder.Pastries != 0)
      {
        _pastryOrder.PastryDeal();
        orderTypes += _pastryOrder.Pastries +" pastries.";
      }
      int orderTotal = _pastryOrder.Price+_levain.Total+_baguette.Total+_como.Total;
      return $"{orderTypes}\nYour total is ${orderTotal}";
    }
  }
}