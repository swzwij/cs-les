using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy myEnemy = new Enemy();

            while (myEnemy.isDead == false)
            {
                Console.WriteLine("hit the Enemy? type 'hit'");
                string awnser = Console.ReadLine();

                if (awnser == "hit")
                {
                    myEnemy.damage();
                }

            }

        }
    }

    class Enemy : Program
    {
        public bool isDead = false;
        bool takenHit = true;
        int Health = 10;


        public void damage()
        {
            if (takenHit == true)
            {
                Health = Health - 1;
                Console.WriteLine("Enemy health is " + Health);
            }

            if (Health == 0)
            {
                isDead = true;
                Console.WriteLine("Enemy is dead");
            }

        }
    }
}