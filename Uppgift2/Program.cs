using System;

namespace CircleCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Ange cirkelns radie i m: ");
        double Radius = double.Parse(Console.ReadLine());
        double Area = Math.Round(Math.PI * Math.Pow(Radius, 2),2);
        Console.WriteLine($"Arean på en cirkel med radien {Radius} är {Area}");
    }
  }
}