using System;

// Clase base para los productos
public abstract class Product
{
    public abstract void Display();
}

//Implementación de un tipo de producto
public class ConcreteProductA : Product
{
    public override void Display()
    {
        Console.WriteLine("Product A");
    }
}

// Implementación de otro tipo de producto
public class ConcreteProductB : Product
{
    public override void Display()
    {
        Console.WriteLine("Product B");
    }
}

// Fábrica para crear productos
public class ProductFactory
{
    private static ProductFactory _instance;

    private ProductFactory() { }

    public static ProductFactory GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ProductFactory();
        }
        return _instance;
    }

    public Product CreateProduct(string productType)
    {
        // Factory Method: crea diferentes tipos de productos
        switch (productType)
        {
            case "ProductA":
                return new ConcreteProductA();
            case "ProductB":
                return new ConcreteProductB();
            // Podrían agregarse más tipos de productos...
            default:
                throw new ArgumentException("Invalid product type");
        }
    }
}