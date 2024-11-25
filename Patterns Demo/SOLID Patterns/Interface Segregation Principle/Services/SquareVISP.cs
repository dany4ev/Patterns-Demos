// 4. Class violating ISP
namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

public class SquareVISP : ISquareVISP
{
    public void DrawSquare()
    {
        Console.WriteLine($"{nameof(SquareVISP)}, DrawSquare() method called.");
    }
}