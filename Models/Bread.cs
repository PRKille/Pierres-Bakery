using System;
namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    public int Price { get; set; }
    public int Total { get; set; }

    public Bread(int price)
    {
      Loaves = 0;
      Price = price;
      Total = 0;
    }

    public void BreadDeal()
    {
      Total += (Loaves*Price)-(Loaves/3*Price);
    }
  }
}