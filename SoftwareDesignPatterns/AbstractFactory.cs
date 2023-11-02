using System;

// Interfaces para las familias de objetos
interface ICar { void Drive(); }
interface IBicycle { void Ride(); }

// Fábrica abstracta para crear familias de objetos
interface IVehicleFactory
{
    ICar CreateCar();
    IBicycle CreateBicycle();
}

// Implementaciones concretas de vehículos
class Sedan : ICar
{
    public void Drive() => Console.WriteLine("Driving the sedan.");
}

class SUV : ICar
{
    public void Drive() => Console.WriteLine("Driving the SUV.");
}

class RoadBike : IBicycle
{
    public void Ride() => Console.WriteLine("Riding the road bike.");
}

class MountainBike : IBicycle
{
    public void Ride() => Console.WriteLine("Riding the mountain bike.");
}

// Fábrica concreta que crea familias específicas de objetos
class UrbanVehicleFactory : IVehicleFactory
{
    public ICar CreateCar() => new Sedan();
    public IBicycle CreateBicycle() => new RoadBike();
}

class RuralVehicleFactory : IVehicleFactory
{
    public ICar CreateCar() => new SUV();
    public IBicycle CreateBicycle() => new MountainBike();
}

// Cliente
class Client
{
    private readonly IVehicleFactory _vehicleFactory;

    public Client(IVehicleFactory factory)
    {
        _vehicleFactory = factory;
    }

    public void Build()
    {
        ICar car = _vehicleFactory.CreateCar();
        IBicycle bicycle = _vehicleFactory.CreateBicycle();

        Console.WriteLine("Built a vehicle family:");
        car.Drive();
        bicycle.Ride();
    }
}
