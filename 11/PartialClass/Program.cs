using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Death Robot");

            Console.WriteLine(robot.Name);

            robot.ShootLaserBeam();
            robot.ShootMissiles();
            robot.Nuke();
        }
    }
}
