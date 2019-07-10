using System;

namespace airplanes
{
  class Program
  {
    static void Main(string[] args)
    {
      var cessna = new Plane("Cessna", "72", 4);

      cessna.Fly();
    }
  }
}
