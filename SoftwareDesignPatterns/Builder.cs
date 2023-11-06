using System;

// Product (Producto)
class Vehicle
{
    public string BuilderEngine { get; set; }
    public string BuilderBody { get; set; }
    public string BuilderAdditionalFeatures { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"BuilderEngine: {BuilderEngine}");
        Console.WriteLine($"BuilderBody: {BuilderBody}");
        Console.WriteLine($"Additional Features: {BuilderAdditionalFeatures}");
    }
}

// Builder (Constructor)
interface IVehicleBuilder
{
    void SetBuilderEngine();
    void SetBuilderBody();
    void SetBuilderAdditionalFeatures();
    Vehicle GetVehicle();
}

// Concrete Builder (ConstructorConcreto)
class CarBuilder : IVehicleBuilder
{
    private readonly Vehicle _vehicleBuilder = new Vehicle();

    public void SetBuilderEngine()
    {
        _vehicleBuilder.BuilderEngine = "1500cc";
    }

    public void SetBuilderBody()
    {
        _vehicleBuilder.BuilderBody = "Hatchback";
    }

    public void SetBuilderAdditionalFeatures()
    {
        _vehicleBuilder.BuilderAdditionalFeatures = "Sunroof, Rear Spoiler";
    }

    public Vehicle GetVehicle()
    {
        return _vehicleBuilder;
    }
}

// Director
class VehicleManufacturer
{
    public void Construct(IVehicleBuilder builder)
    {
        builder.SetBuilderEngine();
        builder.SetBuilderBody();
        builder.SetBuilderAdditionalFeatures();
    }
}
