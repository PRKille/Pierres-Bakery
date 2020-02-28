namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    public int Price { get; set; }

    public Bread()
    {
      Loaves = 0;
      Price = 0;
    }

    public void BreadDeal()
    {
      int twoForOne = (Loaves/3)*5;
      Price = Loaves*5-twoForOne;
    }
  }
}