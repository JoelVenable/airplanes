using System;


namespace airplanes
{
  public class Plane
  {
    public string Make { get; set; }
    public string Model { get; set; }

    public int NumberOfSeats { get; set; }

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