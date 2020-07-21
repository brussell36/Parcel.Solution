namespace Shipping
{
  public class Parcel
  {
    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }

    public Parcel (int height, int length, int width, int weight)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
      int Volume = 0;
      int Cost = 0;
    }
    public int Volume ()
    {
      Volume = Height * Length * Width;
    }
    public int ShippingCalc()
    {
      int price = 0;
      for (int i = 1; i <= VolumeOfParcel; i++)
      {
        if (i <= 5)
        {
          price += 1;
        }
        else if (i >= 5)
        {
          price += 2;
        } 
      }
      return price;
    }
  }
}



  