using System;

namespace AdapterPatternExample
{
    // Interfaz existente (Adaptee)
    interface IAdaptee
    {
        void SpecificRequest();
    }

    // Clase existente con una interfaz incompatible (Adaptee)
    class Adaptee : IAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Datos en formato antiguo.");
        }
    }

    // Interfaz objetivo (Target)
    interface ITarget
    {
        void Request();
    }

    // Adaptador
    class Adapter : ITarget
    {
        private readonly IAdaptee _adaptee;

        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    // Consumidor
    class Client
    {
        public void ProcessRequest(ITarget target)
        {
            target.Request();
        }
    }

}
