using System;


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
        
        #region 
        IVehicleFactory urbanFactory = new UrbanVehicleFactory();
        IVehicleFactory ruralFactory = new RuralVehicleFactory();

        Client urbanClient = new Client(urbanFactory);
        Client ruralClient = new Client(ruralFactory);

        urbanClient.Build();
        ruralClient.Build();
        #endregion
   
    }
}

