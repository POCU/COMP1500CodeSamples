using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Chuck");

            warrior.Introduce();
            warrior.GetStatus();

            //warrior.Name = "Peter";

            warrior.SwordStrike();
            warrior.UseWhirlwind();
            warrior.Rest();

            warrior.GetStatus();

            warrior.Health -= 200;
            //warrior.mHealth = 5000;

            warrior.GetStatus();

            Magician magician = new Magician("Gandalf");

            magician.Introduce();
            magician.GetStatus();

            magician.UseFireball();
            magician.UseIceSpear();
            magician.UseThunder();
            magician.Pound();

            magician.GetStatus();

            magician.Rest();
            magician.GetStatus();
        }
    }
}
