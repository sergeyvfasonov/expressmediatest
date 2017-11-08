using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressmedia.robots.sdk
{
    /// <summary>
    /// Emulate concreate implementation of irobot interface
    /// </summary>
    internal class Robot : IRobot
    {
        private readonly string _name = string.Empty; // test robot name

        public Robot(string name)
        {
            _name = name;
        }

        public void Move(double distance)
        {
            System.Diagnostics.Debug.WriteLine($"Robot '{_name}' executes the command 'Move' with parameter {nameof(distance)} = {distance}");
        }

        public void Turn(double angle)
        {
            System.Diagnostics.Debug.WriteLine($"Robot '{_name}' executes the command 'Turn' with parameter {nameof(angle)} = {angle}");
        }


        public void Beep()
        {
            System.Diagnostics.Debug.WriteLine($"Robot '{_name}' executes the command 'Beep'");
        }

    }
}
