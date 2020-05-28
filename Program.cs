using System.Linq;
using System;
using System.Collections.Generic;

namespace factory
{
  class Program
  {
    static void Main(string[] args)
    {
      var factory = new Factory(); //Created a new factory 

      string input = "";
      while (input != "exit")
      {
        Console.WriteLine("What do you want to do? (create, destroy, print, or exit)");

        input = Console.ReadLine();
        switch (input)
        {
          case "create":
            factory.CreateRockets();
            break;

          case "destroy":
            factory.DestroyRocket();
            break;

          case "print":
          factory.GetRocketList();
            break;
        }
      }
    }
  }
}
