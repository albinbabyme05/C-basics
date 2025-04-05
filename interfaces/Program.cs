using System;
using System.Collections.Generic;

public interface IEnemy
{
    public void Attack();
    public void Defend();
}

class Dragon : IEnemy
{
    public void Attack(){
        System.Console.WriteLine("Dragon firing 🔥🔥🔥");
    }

    public void Defend(){
        System.Console.WriteLine("Dragon spread his wings 🪽🪽🪽");
    }
}

class Vampire : IEnemy
{
    public void Attack(){
        System.Console.WriteLine("Vampire strikes with its fangs😈😈😈");
    }

    public void Defend(){
        System.Console.WriteLine("Vampire tranform into bat to evade🦇🦇🦇");
    }
}
class Program
{
    static void Main()
    {
        IEnemy e1 = new Dragon();
        IEnemy e2 = new Vampire();

        List<IEnemy> enemies = new List<IEnemy>();
        enemies.Add(e1);
        enemies.Add(e2);

        foreach (var e in enemies)
        {
            
            e.Attack();
        }
    }
}
