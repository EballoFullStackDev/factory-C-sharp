using System;

namespace factory
{
    class Rocket
    {
      public string Name { get; set; }  // Add code to create a rocket
      public string Height { get; set; }
      public string FuelType { get; set; }
      public Guid Id { get; set; } = Guid.NewGuid();
    }
}