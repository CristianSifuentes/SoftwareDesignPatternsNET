using System;

public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton instance;
    private static readonly object lockObject = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance()
    {
        if (instance == null)
        {
            // Utilizamos un bloqueo para garantizar la exclusión mutua.
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ThreadSafeSingleton();
                }
            }
        }
        return instance;
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("Ejecutando la lógica de negocio en ThreadSafeSingleton.");
    }
}
