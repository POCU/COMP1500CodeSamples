using System;

namespace Class
{
    public class Magician
    {
        private const int MAX_HEALTH = 250;
        private const int MAX_MANA = 400;
        private const int MAX_STAMINA = 100;

        private int mHealth;
        private int mMana;
        private int mStamina;

        public Magician(string name)
        {
            Name = name;
            mHealth = MAX_HEALTH;
            mMana = MAX_MANA;
            mStamina = MAX_STAMINA;
        }

        public string Name { get; private set; }

        public int Health
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;

                if (mHealth < 0)
                {
                    mHealth = 0;
                }

                if (mHealth > MAX_HEALTH)
                {
                    mHealth = MAX_HEALTH;
                }
            }
        }

        public int Mana
        {
            get
            {
                return mMana;
            }
            set
            {
                mMana = value;

                if (mMana < 0)
                {
                    mMana = 0;
                }

                if (mMana > MAX_MANA)
                {
                    mMana = MAX_MANA;
                }
            }
        }

        public int Stamina
        {
            get
            {
                return mStamina;
            }
            set
            {
                mStamina = value;

                if (mStamina < 0)
                {
                    mStamina = 0;
                }

                if (mStamina > MAX_STAMINA)
                {
                    mStamina = MAX_STAMINA;
                }
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"I'm {Name}! Knowledge is power. Ask, and learn...");
        }

        public void Pound()
        {
            if (Stamina < 50)
            {
                Console.WriteLine($"{Name} can't use Pound!");
                return;
            }

            Stamina -= 50;

            Console.WriteLine($"{Name} used Pound!");
        }

        public void UseFireball()
        {
            if (Mana < 50)
            {
                Console.WriteLine($"{Name} can't use Fireball!");
                return;
            }

            Mana -= 50;

            Console.WriteLine($"{Name} used Fireball!");
        }

        public void UseIceSpear()
        {
            if (Mana < 30)
            {
                Console.WriteLine($"{Name} can't use IceSpear!");
                return;
            }

            Mana -= 30;

            Console.WriteLine($"{Name} used IceSpear!");
        }

        public void UseThunder()
        {
            if (Mana < 80)
            {
                Console.WriteLine($"{Name} can't use Thunder!");
                return;
            }

            Mana -= 80;

            Console.WriteLine($"{Name} used Thunder!");
        }

        public void Rest()
        {
            Mana += 5;
            Stamina += 2;
            Health += 3;

            Console.WriteLine($"{Name} is resting.");
        }

        public void GetStatus()
        {
            Console.WriteLine($"{Name} - Health: {Health} / Mana: {Mana} / Stamina: {Stamina}");
        }
    }
}
