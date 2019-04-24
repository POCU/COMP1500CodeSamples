using System;

namespace PartialClass
{
    public partial class Robot
    {
        //public Robot(string name)
        //{
        //    Name = name;
        //}

        //public void ShootLaserBeam()
        //{
        //    Console.WriteLine($"{Name} Shooting laser beam!");
        //}

        public void Nuke()
        {
            Console.WriteLine($"{Name}: Nuclear launch detected!");
        }
    }
}
