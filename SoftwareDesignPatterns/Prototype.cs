using System;

namespace PrototypePatternExample
{
    // Prototipo abstracto
    interface IVehiclePrototype
    {
        IVehiclePrototype Clone();
        void SetAdditionalFeatures(string features);
        void PrintDetails();
    }

    // Implementación concreta del prototipo
    class Car : IVehiclePrototype
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string AdditionalFeatures { get; set; }

        public IVehiclePrototype Clone()
        {
            return new Car
            {
                Model = this.Model,
                Color = this.Color,
                AdditionalFeatures = this.AdditionalFeatures
            };
        }

        public void SetAdditionalFeatures(string features)
        {
            this.AdditionalFeatures = features;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Car Model: {Model}, Color: {Color}, Additional Features: {AdditionalFeatures}");
        }
    }
}
