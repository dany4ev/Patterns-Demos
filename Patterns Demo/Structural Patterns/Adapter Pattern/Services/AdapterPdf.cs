using Patterns_Demo.Adapter_Pattern_Example.Interfaces;

namespace Patterns_Demo.Structural_Patterns.Adapter_Pattern.Services;

public class AdapterPdf : IReport
{
    public void Export()
    {
        ThirdPartyPdf x = new ThirdPartyPdf();
        x.Save();
    }
}