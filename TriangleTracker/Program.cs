using System;
using System.Collections.Generic;
using ShapeTracker.Models;



public class Program
{

  public static void Main()
  {
    
    
    Console.WriteLine("Enter a number:");
    string _side1 = Console.ReadLine();
    Console.WriteLine("Enter another number:");
    string _side2 = Console.ReadLine();
    Console.WriteLine("Enter a third number:");
    string _side3 = Console.ReadLine();
    int sideOne = int.Parse(_side1);
    int sideTwo = int.Parse(_side2);
    int sideThree = int.Parse(_side3);
    
    TriangleTracker triangle = new TriangleTracker(sideOne,sideTwo,sideThree);

    Console.WriteLine(triangle.CheckType());

  
  }
}



