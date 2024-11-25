namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// Class follows ISP
public class Circle : IShapeWISP
{
    public void Draw()
    {
        Console.WriteLine($"{nameof(Circle)}, Draw() method called.");
    }
}