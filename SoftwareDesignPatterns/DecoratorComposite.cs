using System;
using System.Collections.Generic;

namespace DecoratorCompositeExample
{
    // Componente base (Interface)
    public interface ITarget
    {
        void DoSomething();
    }

    // Clase base concreta (Concrete Component)
    public class OriginalComponent : ITarget
    {
        public void DoSomething()
        {
            Console.WriteLine("Realizando operación del componente original.");
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

    // Composite
    public class Composite : ITarget
    {
        private readonly List<ITarget> _targets = new List<ITarget>();

        public void Add(ITarget target)
        {
            _targets.Add(target);
        }

        public void DoSomething()
        {
            foreach (var target in _targets)
            {
                target.DoSomething();
            }
        }
    }
}
