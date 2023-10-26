using System;


class Program
{
    static void Main(string[] args)
    {
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
    }
}

