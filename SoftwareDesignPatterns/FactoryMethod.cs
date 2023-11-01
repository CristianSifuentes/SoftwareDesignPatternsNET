using System;

// Interfaz común para los enemigos
interface IEnemy
{
    void Attack();
}

// Clase base para Factory Method
abstract class EnemyFactory
{
    public abstract IEnemy CreateEnemy();
}

// Clase de enemigo básica
class BasicEnemy : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("El enemigo básico ataca.");
    }
}

// Factory Method para el enemigo básico
class BasicEnemyFactory : EnemyFactory
{
    public override IEnemy CreateEnemy()
    {
        return new BasicEnemy();
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

// Factory Method para el enemigo avanzado
class AdvancedEnemyFactory : EnemyFactory
{
    public override IEnemy CreateEnemy()
    {
        return new AdvancedEnemy();
    }
}

