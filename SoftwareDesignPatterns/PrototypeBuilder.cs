using System;

namespace PrototypeBuilderExample
{
    // Prototype
    interface IVehiclePrototype
    {
        IVehiclePrototype Clone();
        string Engine { get; set; }
        string Body { get; set; }
        string AdditionalFeatures { get; set; }
    }

    // Builder
    interface IVehicleBuilder
    {
        void SetEngine();
        void SetBody();
        void SetAdditionalFeatures();
        IVehiclePrototype GetVehicle();
    }

    // Concrete Prototype
    class CarPrototype : IVehiclePrototype
    {
        public string Engine { get; set; }
        public string Body { get; set; }
        public string AdditionalFeatures { get; set; }

        public IVehiclePrototype Clone()
        {
            return new CarPrototype
            {
                Engine = this.Engine,
                Body = this.Body,
                AdditionalFeatures = this.AdditionalFeatures
            };
        }
    }

    // Concrete Builder
    class CarBuilder : IVehicleBuilder
    {
        private readonly CarPrototype _prototype = new CarPrototype();

        public void SetEngine()
        {
            _prototype.Engine = "2000cc";
        }

        public void SetBody()
        {
            _prototype.Body = "SUV";
        }

        public void SetAdditionalFeatures()
        {
            _prototype.AdditionalFeatures = "Sunroof, 4WD, Tow Hitch";
        }

        public IVehiclePrototype GetVehicle()
        {
            return _prototype.Clone();
        }
    }

}
