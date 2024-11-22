using Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Interfaces;

namespace Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Services;

// Implementation of null object pattern within abstract factory pattern
public class EmptyVehicle : IVehicleFactory
{
    public void Manufacture()
    {
    }
}