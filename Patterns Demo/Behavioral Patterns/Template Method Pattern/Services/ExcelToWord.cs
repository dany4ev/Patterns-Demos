using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Services;

// deferring some steps to client subclasses 
public class ExcelToWord : Etl
{
    public override void Extract()
    {
        Console.WriteLine("ExcelToWord Extracting..");
    }

    public override void Transform()
    {
        Console.WriteLine("ExcelToWord Transform..");
    }

    public override void Load()
    {
        Console.WriteLine("ExcelToWord Load..");
    }
}
