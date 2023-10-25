using System;

public class Singleton
{
    private static Singleton instance;
    
    // Un constructor privado para evitar la creación de instancias desde fuera de la clase.
    private Singleton() { }
    
    // Un método público que devuelve la única instancia de la clase.
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("Ejecutando la lógica de negocio en Singleton.");
    }
}

