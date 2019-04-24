using System;

namespace PartialClass
{
    public partial class Robot
    {
        public Robot(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void ShootLaserBeam()
        {
            Console.WriteLine($"{Name} shooting laser beam!");
        }

        public void ShootMissiles()
        {
            Console.WriteLine($"{Name} shooting missiles!");
        }
    }
}
