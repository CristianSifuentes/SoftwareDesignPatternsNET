using System;

// Interfaz común para los enemigos
// IEnemy define un comportamiento común para los enemigos (en este caso, el método Attack()).
interface IEnemy
{
    void Attack();
}

// Clase base para Factory Method
// EnemyFactory es la clase abstracta que define el Factory Method (CreateEnemy()).
abstract class EnemyFactory
{
    public abstract IEnemy CreateEnemy();
}



// Clase de enemigo básica
//BasicEnemy y AdvancedEnemy son las implementaciones concretas de enemigos que implementan IEnemy.
class BasicEnemy : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("El enemigo básico ataca.");
    }
}

// Otra clase de enemigo
class AdvancedEnemy : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("El enemigo avanzado ataca.");
    }
}



// BasicEnemyFactory y AdvancedEnemyFactory son las clases que extienden EnemyFactory y proporcionan sus propios métodos CreateEnemy() para instanciar tipos específicos de enemigos.
// Factory Method para el enemigo básico
class BasicEnemyFactory : EnemyFactory
{
    public override IEnemy CreateEnemy()
    {
        return new BasicEnemy();
    }
}



// Factory Method para el enemigo avanzado
class AdvancedEnemyFactory : EnemyFactory
{
    public override IEnemy CreateEnemy()
    {
        return new AdvancedEnemy();
    }
}

