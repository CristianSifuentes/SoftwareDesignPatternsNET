﻿using System;


class Program
{
    static void Main(string[] args)
    {
        
        #region Singleton
        // Intenta obtener la instancia del Singleton.
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

        // Comprueba si las dos instancias son la misma.
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Ambas instancias son idénticas. Esto demuestra que es un Singleton.");
        }
        
        // Ejecuta la lógica de negocio en la instancia del Singleton.
        singleton1.SomeBusinessLogic();



        // Creamos varios hilos que intentarán acceder al Singleton.
        for (int i = 0; i < 5; i++)
        {
            var thread = new System.Threading.Thread(() =>
            {
                var singleton = ThreadSafeSingleton.GetInstance();
                singleton.SomeBusinessLogic();
            });
            thread.Start();
        }

        
        Lazy<List<int>> lazyList = new Lazy<List<int>>(() => 
        {
            var list = new List<int>();
            // Realizar alguna operación costosa para llenar la lista.
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
            return list;
        });

       // En algún otro lugar del código, cuando se necesita la lista:
        List<int> lista = lazyList.Value; // La lista se inicializa en este momento, si aún no se ha hecho.

       #endregion 
       
        #region  FactoryMethod

        /*
        Esto ilustra cómo el patrón Factory Method permite crear objetos de una jerarquía común a través de métodos de fábrica especializados en las subclases, 
        brindando flexibilidad y extensibilidad al sistema para manejar diferentes tipos de objetos.
        
        */


        // Crear instancias usando los Factory Methods
        EnemyFactory basicFactory = new BasicEnemyFactory();
        IEnemy basicEnemy = basicFactory.CreateEnemy();

        EnemyFactory advancedFactory = new AdvancedEnemyFactory();
        IEnemy advancedEnemy = advancedFactory.CreateEnemy();

            // Utilizar los enemigos
            basicEnemy.Attack();    // Salida: El enemigo básico ataca.
            advancedEnemy.Attack(); // Salida: El enemigo avanzado ataca.
        #endregion

        #region SingletonFactoryMethod
        ProductFactory factory = ProductFactory.GetInstance();

        Product productA = factory.CreateProduct("ProductA");
        Product productB = factory.CreateProduct("ProductB");

        productA.Display(); // Salida: Product A
        productB.Display(); // Salida: Product B

        #endregion
        
        #region AbstractFactory
        IVehicleFactory urbanFactory = new UrbanVehicleFactory();
        IVehicleFactory ruralFactory = new RuralVehicleFactory();

        Client urbanClient = new Client(urbanFactory);
        Client ruralClient = new Client(ruralFactory);

        urbanClient.Build();
        ruralClient.Build();
        #endregion
   
        #region Builder 
        var manufacturer = new VehicleManufacturer();
        var carBuilder = new CarBuilder();

        manufacturer.Construct(carBuilder);

        Vehicle car = carBuilder.GetVehicle();
        Console.WriteLine("Car Details:");
        car.DisplayDetails();
        #endregion
   
        #region AbstractFactoryBuilder
        AbstractFactoryBuilderExample.IVehicleFactory abstractFactoryBuilderFactory = new AbstractFactoryBuilderExample.CarFactory();
        AbstractFactoryBuilderExample.IVehicleBuilder builder = abstractFactoryBuilderFactory.CreateBuilder();

        builder.SetEngine();
        builder.SetBody();
        builder.SetAdditionalFeatures();

        AbstractFactoryBuilderExample.Vehicle carAbstractFactoryBuilder = builder.GetVehicle();
        carAbstractFactoryBuilder.DisplayDetails();

        #endregion
        
        #region PrototypeBuilder
        PrototypeBuilderExample.IVehicleBuilder builderPrototypeBuilder = new PrototypeBuilderExample.CarBuilder();

        builderPrototypeBuilder.SetEngine();
        builderPrototypeBuilder.SetBody();
        builderPrototypeBuilder.SetAdditionalFeatures();

        PrototypeBuilderExample.IVehiclePrototype prototypeBuilder = builderPrototypeBuilder.GetVehicle();

        Console.WriteLine("Car Details:");
        Console.WriteLine($"Engine: {prototypeBuilder.Engine}");
        Console.WriteLine($"Body: {prototypeBuilder.Body}");
        Console.WriteLine($"Additional Features: {prototypeBuilder.AdditionalFeatures}");

        #endregion
        
        #region SingletonBuilder
        SingletonBuilderExample.SingletonBuilder singletonBuilder = SingletonBuilderExample.SingletonBuilder.GetInstance();

        singletonBuilder.SetEngine();
        singletonBuilder.SetBody();
        singletonBuilder.SetAdditionalFeatures();

        SingletonBuilderExample.Vehicle carSingletonBuilder = singletonBuilder.GetVehicle();
        carSingletonBuilder.DisplayDetails();
        #endregion
   
    }
}

