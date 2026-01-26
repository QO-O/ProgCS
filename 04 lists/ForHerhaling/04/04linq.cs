using System;
using System.Collections.Generic;
using System.Linq;


namespace _04;

class Program
{
    static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

            List<Mob> mobs = new List<Mob>
        {
            new Mob("Enderman"),
            new Mob("Husk"),
            new Mob("Parched")
        };

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                foreach (var mob in mobs)
                {
                    int damage = rand.Next(0, 100);

                    if (damage < 30)
                    {
                        mob.TakeDamage(1);
                    }
                }
            }

            List<Mob> defeated = mobs.Where(mob=>mob.isDead).ToList();

    }

        void intDamage()
        {
            
        }

        internal void Run()
        {
        
        }
}
class Mob
{
    public bool isDead;
    public string Name;
    internal int hp = 10;

        public Mob(string name, int initialHp = 10)
        {
            Name = name;
            hp = initialHp;
            isDead = false;
        }
     public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            hp = 0;
            isDead = true;
        }
    }


}