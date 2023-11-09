using System;

namespace DecoratorAdapterExample
{
    // Interface para el componente original (Target)
    public interface ITarget
    {
        void DoSomething();
    }

    // Clase concreta para el componente original (Target)
    public class OriginalComponent : ITarget
    {
        public void DoSomething()
        {
            Console.WriteLine("Realizando operación del componente original.");
        }
    }

    // Adapter
    public class Adapter : ITarget
    {
        private readonly OtherService _otherService;

        public Adapter(OtherService otherService)
        {
            _otherService = otherService;
        }

        public void DoSomething()
        {
            _otherService.DoSomethingElse();
        }
    }

    // Decorador
    public class Decorator : ITarget
    {
        private readonly ITarget _target;

        public Decorator(ITarget target)
        {
            _target = target;
        }

        public void DoSomething()
        {
            Console.WriteLine("Realizando operación adicional del decorador.");
            _target.DoSomething();
        }
    }

    // Clase que representa otro servicio con diferente interfaz
    public class OtherService
    {
        public void DoSomethingElse()
        {
            Console.WriteLine("Realizando operación en otro servicio.");
        }
    }

}
