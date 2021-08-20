using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaToppings
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      List<Pizza> pizzaCollection = new List<Pizza>();
      var jsonFile = File.ReadAllText(@"C:\Users\16159\source\repos\PizzaToppings\PizzaToppings\pizzas.json");

      pizzaCollection = JsonConvert.DeserializeObject<List<Pizza>>(File.ReadAllText(@"c:\Users\16159\source\repos\PizzaToppings\PizzaToppings\pizzas.json"));

      var results = pizzaCollection.GroupBy(pizza => pizza.Toppings).OrderBy()

      foreach (var uniquePizza in results)
      {
        var test = "Pizza Toppings";
        foreach (var topping in uniquePizza.Key)
        {
          test += $" {topping}";
        }
        Console.WriteLine(test);
      } 
    }
  }
}
