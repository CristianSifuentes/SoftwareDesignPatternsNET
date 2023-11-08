using System;

namespace AdapterFactoryMethodExample
{
    // Adapter Interface
    interface ITarget
    {
        void Request();
    }

    // Adaptee
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Datos en formato antiguo.");
        }
    }

    // Adapter
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    // Factory Method for Adapter
    class AdapterFactory
    {
        public ITarget CreateAdapter()
        {
            Adaptee adaptee = new Adaptee();
            return new Adapter(adaptee);
        }
    }

}
