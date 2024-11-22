using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Services;

// deferring some steps to client subclasses 
public class ExcelToWord : Etl
{
    protected override void Extract()
    {
    }

    protected override void Transform()
    {
    }

    protected override void Load()
    {
    }
}