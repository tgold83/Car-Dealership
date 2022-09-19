using System;

namespace Dealership.Models {

  public class Car
  {
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    // public string MakeModel
    // {
    //   get 
    //   {
    //     return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
    //   }
    //   set 
    //   {
    //     MakeModel = value;
    //   }
    // }

    public static string MakeSound(string sound)
    {
      return "our cars sound like " + sound;
    }

    public void SetPrice(int newPrice) 
    {
      Price = newPrice;
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

    public int GetPrice()
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