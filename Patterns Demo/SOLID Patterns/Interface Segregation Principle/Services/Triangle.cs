namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// Class follows ISP
public class Triangle : IShapeWISP
{
    public void Draw()
    {
        Console.WriteLine($"{nameof(Triangle)}, Draw() method called.");
    }
}
