using Patterns_Demo.Adapter_Pattern_Example.Interfaces;

namespace Patterns_Demo.Structural_Patterns.Adapter_Pattern.Services;

public class WordReport : IReport
{
    #region IReport implementation
    public void Export()
    {
    }
    #endregion
}

// Adapter is just a wrapper class to encapsulate incompatible third party code
// within our system