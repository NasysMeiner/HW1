using System;

namespace HW1
{
    class Weapon
    {
        public int Damage { get; private set; }
        public int Bullets { get; private set; }

        public Weapon(int damage, int bullets)
        {
            Damage = damage;
            Bullets = bullets;
        }

        public void Fire(Player player)
        {
            if(Bullets <= 0)
            {
                Console.WriteLine("No bullets");

                return;
            }

            player.ApplyDamage(Damage);
            Bullets -= 1;
        }
    }

    class Player
    {
        public int Health { get; private set; }

        public Player(int health)
        {
            Health = health;
        }

        public void ApplyDamage(int damage)
        {
            Health -= damage;

            if (Health <= 0)
                Die();
        }

        private void Die()
        {
            Console.WriteLine("Player die!");
        }
    }

    class Bot
    {
        private readonly Weapon Weapon;

        public Bot(Weapon weapon)
        {
            Weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            Weapon.Fire(player);
        }
    }
}
