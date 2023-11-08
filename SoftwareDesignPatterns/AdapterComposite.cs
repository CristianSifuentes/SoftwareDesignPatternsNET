using System;
using System.Collections.Generic;

namespace AdapterCompositeExample
{
    // Target Interface
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

    // Composite Adapter
    class CompositeAdapter : ITarget
    {
        private readonly List<ITarget> _adapters = new List<ITarget>();

        public void Add(ITarget adapter)
        {
            _adapters.Add(adapter);
        }

        public void Request()
        {
            foreach (var adapter in _adapters)
            {
                adapter.Request();
            }
        }
    }

}
