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


    }
}

