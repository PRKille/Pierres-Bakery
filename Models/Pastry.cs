namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Pastries { get; set; }
    public int Price { get; set; }

    public Pastry()
    {
      Pastries = 0;
      Price = 0;
    }

    public void PastryDeal()
    {
      Price += (Pastries/3*5)+(Pastries%3*2);
    }
  }
}