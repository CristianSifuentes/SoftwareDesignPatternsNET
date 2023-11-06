using System;

namespace SingletonBuilderExample {

  class SingletonBuilder {
    private static SingletonBuilder _instance;
    private readonly Vehicle _vehicle;

    private SingletonBuilder() {
      _vehicle = new Vehicle();
    }

    public static SingletonBuilder GetInstance() {
      if (_instance == null) {
        _instance = new SingletonBuilder();
      }
      return _instance;
    }

    public void SetEngine() {
      _vehicle.Engine = "1500cc";
    }

    public void SetBody() {
      _vehicle.Body = "Hatchback";
    }

    public void SetAdditionalFeatures() {
      _vehicle.AdditionalFeatures = "Sunroof, Rear Spoiler";
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