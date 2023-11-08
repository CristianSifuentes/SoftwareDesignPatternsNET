using System;

namespace DecoratorPatternExample
{
    // Component (interfaz base)
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    // Concrete Component (implementación base)
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Café sencillo";
        }

        public double GetCost()
        {
            return 1.0;
        }
    }

    // Decorador abstracto
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee decoratedCoffee;

        public CoffeeDecorator(ICoffee decoratedCoffee)
        {
            this.decoratedCoffee = decoratedCoffee;
        }

        public virtual string GetDescription()
        {
            return decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedCoffee.GetCost();
        }
    }

    // Concrete Decorators (decoradores concretos)
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, con leche";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, con azúcar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }
    }

}
