namespace Proje_4.Models;

public class Planet : CelestialBody
{
    public Planet(string name, double mass, double radius, double distance, double gravity)
    : base(name, mass, radius)
    {
        Distance = distance;
        Gravity = gravity;
    }

    public double Distance { get; set; }
     public double Gravity { get; set; }

    public override void Describe()
    {
        System.Console.WriteLine($"{Name}\n{Mass}\n{Radius}\n{Distance}\n{Gravity}");
    }
}