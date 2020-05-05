using System;
using System.Collections.Generic;

public class Car 
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Message;

  public Car(string makeModel, int price, int miles, string message)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }

  public bool WorthBuying(int maxPrice, int maxMileage)
  {
    return ((Price <= maxPrice) && (Miles <= maxMileage));
  }
}

public class Program
{
  public static void Main()
  {
    Car vwThings = new Car("1974 Volkswagen Things", 1100, 368792, "Let's relive the 70's");
    Car yugoKoral = new Car("1980 Yugo Koral", 700, 56000, "It looks very pretty");
    Car fordSquire = new Car("1988 Ford Country Squire", 1400, 239001, "Come along squire!");
    Car amcPacer = new Car("1976 AMC Pacer", 400, 198000, "Not just a movie theater!");
    Car keiTruck = new Car("1995 Suzuki Carry", 3600, 15410, "It makes you feel like you are in a Studio Ghibli film while driving!");
    Car fordPinto = new Car("1981 Ford Pinto", 200, 36000, "Wow, a good bean!");
    Car fordEdge = new Car("2008 Ford Edge", 4000, 10000, "A good car to learn to drive!");
 
    List<Car> Cars = new List<Car>() { vwThings, yugoKoral, fordSquire, amcPacer, keiTruck, fordPinto, fordEdge};

    Console.WriteLine("Enter Maximum Price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    
    Console.WriteLine("Enter Maximum Mileage: ");
    int maxMileage = int.Parse(Console.ReadLine());

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMileage))
      {
        CarsMatchingSearch.Add(automobile);
      } 
    }
    
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine("------------");
      Console.WriteLine(automobile.MakeModel + ": $" + automobile.Price);
      Console.WriteLine(automobile.Message);
    }
  }
}
