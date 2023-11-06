using System;

namespace AbstractFactoryBuilderExample {

  // Abstract Factory
  interface IVehicleFactory {
    IVehicleBuilder CreateBuilder();
  }

  // Builder
  interface IVehicleBuilder {
    void SetEngine();
    void SetBody();
    void SetAdditionalFeatures();
    Vehicle GetVehicle();
  }

  // Concrete Factory
  class CarFactory: IVehicleFactory {
    public IVehicleBuilder CreateBuilder() {
      return new CarBuilder();
    }
  }

  // Concrete Builder
  class CarBuilder: IVehicleBuilder {
    private readonly Vehicle _vehicle = new Vehicle();

    public void SetEngine() {
      _vehicle.Engine = "2000cc";
    }

    public void SetBody() {
      _vehicle.Body = "Sedan";
    }

    public void SetAdditionalFeatures() {
      _vehicle.AdditionalFeatures = "Sunroof, GPS, Premium Sound System";
    }

    public Vehicle GetVehicle() {
      return _vehicle;
    }
  }

  class Vehicle {
    public string Engine {
      get;
      set;
    }
    public string Body {
      get;
      set;
    }
    public string AdditionalFeatures {
      get;
      set;
    }

    public void DisplayDetails() {
      Console.WriteLine($"Engine: {Engine}");
      Console.WriteLine($"Body: {Body}");
      Console.WriteLine($"Additional Features: {AdditionalFeatures}");
    }
  }

}