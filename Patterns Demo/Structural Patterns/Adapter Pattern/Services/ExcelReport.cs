using Patterns_Demo.Adapter_Pattern_Example.Interfaces;

namespace Patterns_Demo.Structural_Patterns.Adapter_Pattern.Services;

public class ExcelReport : IReport
{
    #region IReport implementation
    public void Export()
    {
    }
    #endregion
}