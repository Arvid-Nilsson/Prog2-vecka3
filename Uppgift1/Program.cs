using System;

namespace AllmänaÖvningar
{
  class Program
  {
    static void Main(string[] args)
    {
      double värde1 = 3.1415;
      double värde2 = 2.7182;
      double summa = värde1 * värde2;
      Console.WriteLine(summa);
      int lokaltHögstaVärde = Math.Max(5, 10);
      Console.WriteLine(lokaltHögstaVärde);
      double högstaVärde = Math.Max(lokaltHögstaVärde, summa);
      Console.WriteLine(högstaVärde);
    }
  }
}