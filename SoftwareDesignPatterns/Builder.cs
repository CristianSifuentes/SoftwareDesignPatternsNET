using System;

// Product (Producto)
class Vehicle
{
    public string Engine { get; set; }
    public string Body { get; set; }
    public string AdditionalFeatures { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Body: {Body}");
        Console.WriteLine($"Additional Features: {AdditionalFeatures}");
    }
}

// Builder (Constructor)
interface IVehicleBuilder
{
    void SetEngine();
    void SetBody();
    void SetAdditionalFeatures();
    Vehicle GetVehicle();
}

// Concrete Builder (ConstructorConcreto)
class CarBuilder : IVehicleBuilder
{
    private readonly Vehicle _vehicle = new Vehicle();

    public void SetEngine()
    {
        _vehicle.Engine = "1500cc";
    }

    public void SetBody()
    {
        _vehicle.Body = "Hatchback";
    }

    public void SetAdditionalFeatures()
    {
        _vehicle.AdditionalFeatures = "Sunroof, Rear Spoiler";
    }

    public Vehicle GetVehicle()
    {
        return _vehicle;
    }
}

// Director
class VehicleManufacturer
{
    public void Construct(IVehicleBuilder builder)
    {
        builder.SetEngine();
        builder.SetBody();
        builder.SetAdditionalFeatures();
    }
}
