using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Services;

public class WordToExcel : Etl
{
    public override void Extract()
    {
        Console.WriteLine("WordToExcel Extracting..");
    }

    public override void Transform()
    {
        Console.WriteLine("WordToExcel Transform..");
    }

    public override void Load()
    {
        Console.WriteLine("WordToExcel Load..");
    }
}