namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// Class follows ISP
public class Square : IShapeWISP
{
    public void Draw()
    {
        Console.WriteLine($"{nameof(Square)}, Draw() method called.");
    }
}
