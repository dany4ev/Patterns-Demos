namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// Class follows ISP
public class CustomShape : IShapeWISP
{
    public void Draw()
    {
        Console.WriteLine($"{nameof(CustomShape)}, Draw() method called.");
    }
}
