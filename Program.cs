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
/*
The goal of this lab is to create a console application to allow a business to manually run
a rocket factory.

We should be able to do this in an Object Oriented (OOP) manner.  This will mean making classes
for each of the entities we need to track as well as creating instances of those classes
in the program.

Below, you will find a standard input loop that you can use to get input from the user and take
action based on that input.

We want to be able to create new rockets, destroy rockets, show all of the rockets that have been created
and change an existing rocket.

Stretch goals:

Add the functionality to delete a rocket by id (instead of last rocket)
Create an interact method where a user can interact with an rocket and launch it to space.

 */
