using Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Services;

namespace Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Interfaces;

public class CarCompany
{
    public IVehicleFactory ProduceVehicle(string vehicleType)
    {
        IVehicleFactory vehicle = vehicleType switch
        {
            "TeslaCar" => new TeslaCar(),
            "TeslaBike" => new TeslaBike(),
            "TataTruck" => new TataTruck(),
            "TataCar" => new TataCar(),
            "TataBike" => new TataBike(),
            _ => new EmptyVehicle() // Implementation of null object pattern within abstract factory pattern
        };

        return vehicle;
    }
}