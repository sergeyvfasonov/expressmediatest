using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressmedia.robots.sdk
{
    /// <summary>
    /// Emulate factory to create/get a robot(s)
    /// </summary>
    public static class RobotFactory
    {
        /// <summary>
        /// Creates a robot
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IRobot CreateRobot(string name)
        {
            return new Robot(name);
        }
    }
}
