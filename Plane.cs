using System;


namespace airplanes
{
  public class Plane
  {
    public string Make { get; }
    public string Model { get; }

    public int NumberOfSeats { get; }

    public Plane(string make, string model, int numSeats)
    {
      Make = make;
      Model = model;
      NumberOfSeats = numSeats;
    }
    public void Fly()
    {
      Console.WriteLine($"I'm flying my {Make} {Model} to the Bahamas.");
    }
  }
}