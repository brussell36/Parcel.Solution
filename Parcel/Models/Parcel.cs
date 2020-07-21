using System.Collections.Generic;
using System;

namespace Shipping.Models
{
  public class Parcel
  {
    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }
    public int Size { get; set; }
    public int Cost { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};

    
    public Parcel (int height, int length, int width, int weight)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
      int Size = 0;
      int Cost = 0;
      _instances.Add(this);
    }
    public int Volume ()
    {
      Size = Height * Length * Width;
      return Size;
}
    public int ShippingCalc()
    {
      int price = 0;
      for (int i = 1; i <= Size; i++)
      {
        if (i <= 1200)
        {
          price += 1;
        }
        else if (i >= 1200)
        {
          price += 2;
        } 
      }
      // if (weight >= 3)
      // {

      // }
      Cost = price /100;
      return Cost;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}



  