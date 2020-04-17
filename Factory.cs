using System.Linq;
using System;
using System.Collections.Generic;

namespace factory
{
    class Factory
    {     
      private static List<Rocket> rockets = new List<Rocket>();

      static string GetInput(string prompt)
      {
        Console.WriteLine(prompt);
        return Console.ReadLine();
      }

      public void CreateRockets()
      {
        string rocketName = GetInput("What would you like to name your rocket? "); // Make sure to ask about how tall the rocket is and what type of fuel it uses
        string rocketHeight = GetInput("How tall is the rocket? ");
        string fuelType = GetInput("What kind of fuel does your rocket take? ");

        var newRocket = new Rocket { Name = rocketName, Height = rocketHeight, FuelType = fuelType };
        Console.WriteLine($"{newRocket.Name} has been created.");
        rockets.Add(newRocket);
      }

      public void DestroyRocket()
      {
        var lastRocket = rockets.Last();
        rockets.RemoveAt(rockets.Count -1); // Add code to delete last rocket
        Console.WriteLine($"{lastRocket.Name} has been destroyed");
      }

      public void GetRocketList() 
      {
        foreach(Rocket ship in rockets)
        {
          Console.WriteLine($"Rocket Name:{ship.Name}, Rocket Height:{ship.Height}, Fuel Type:{ship.FuelType}, Id: {ship.Id} ");

        }
      }
    }
}