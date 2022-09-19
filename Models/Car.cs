using System;

namespace Dealership.Models {

  public class Car
  {
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public static string MakeSound(string sound)
    {
      return "our cars sound like " + sound;
    }

    public void SetPrice(int newPrice) 
    {
      Price = newPrice;
    }

    public void SalePrice(float saleDecimal)
    {
      Console.WriteLine(saleDecimal);
      float floatedPrice = (float)Price;
      floatedPrice = floatedPrice * saleDecimal;
      Console.WriteLine("new Price = " + floatedPrice);
      Price = (int)floatedPrice;
    }

    public void discountedPrice(int discount)
    {
      Price = Price - discount;
    }
    // Constructor
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public float GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }
    
    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}