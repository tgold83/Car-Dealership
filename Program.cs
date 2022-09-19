using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, true);
      Car yugo = new Car("1980 Yugo Koral", 1000, 56000, true);
      Console.WriteLine(yugo.MakeModel);
      yugo.MakeModel = "Worst Car Ever";
      Console.WriteLine(yugo.MakeModel);


      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, false);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, false);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      //yugo.SetPrice(300);
      yugo.SalePrice(.50f);
      volkswagen.discountedPrice(200);//discounts $200 from volkswagen price (1100 -> 900)

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("Would you like a car with rally capabilities? ['Y' for yes, 'Enter' for no]");
      string answer = Console.ReadLine();
      List<Car> CarsMatchingSearch = new List<Car>(0);


      if (answer == "Y" || answer == "y")
      {
        //check to see if the price is good
        //check to see if its an offroad car
        //if both are yes then we add it to the list
        foreach (Car automobile in Cars)
        {
          if (automobile.WorthBuying(maxPrice) && automobile.GetOffroadCapabilities() == true)
          {
            CarsMatchingSearch.Add(automobile);
          }
        }
      }
      else
      {
        foreach (Car automobile in Cars)
        {
          if (automobile.WorthBuying(maxPrice))
          {
            CarsMatchingSearch.Add(automobile);
          }
        }
      }



      // foreach (Car automobile in Cars)
      // {
      //   if (automobile.GetOffroadCapabilities() == true)
      //   {
      //     CarsMatchingSearch.Add(automobile);
      //   }
      // }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}