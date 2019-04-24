using System;

namespace Class
{
    public class Warrior
    {
        private const int MAX_HEALTH = 500;
        private const int MAX_MANA = 50;
        private const int MAX_STAMINA = 200;

        private int mHealth = MAX_HEALTH;
        private int mMana = MAX_MANA;
        private int mStamina = MAX_STAMINA;

        public Warrior(string name)
        {
            Name = name;
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
            Console.WriteLine($"I'm {Name}! Honour and glory!! THIS IS SPARTA!!");
        }

        public void UseWhirlwind()
        {
            if (Mana < 5 || Stamina < 70)
            {
                Console.WriteLine($"{Name} can't use Whirlwind!");
                return;
            }

            Mana -= 5;
            Stamina -= 70;

            Console.WriteLine($"{Name} used Whilrwind!");
        }

        public void SwordStrike()
        {
            if (Stamina < 20)
            {
                Console.WriteLine($"{Name} can't use SwordStrike!");
                return;
            }

            Stamina -= 20;

            Console.WriteLine($"{Name} used SwordStrike!");
        }

        public void Rest()
        {
            Mana += 2;
            Stamina += 5;
            Health += 5;

            Console.WriteLine($"{Name} is resting.");
        }

        public void GetStatus()
        {
            Console.WriteLine($"{Name} - Health: {Health} / Mana: {Mana} / Stamina: {Stamina}");
        }
    }
}
