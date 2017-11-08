using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using expressmedia.robots.sdk;

namespace expressmedia.workers
{
    /// <summary>
    /// Emulates a commandы set which can be send to the robot
    /// </summary>
    public class Worker
    {
        private readonly List<RobotCommand> _commands; // hold a set of commands

        /// <summary>
        /// Default constructor
        /// </summary>
        public Worker(string name)
        {
            Name = name;
            _commands = new List<RobotCommand>();
        }

        /// <summary>
        /// Returns the name of worker
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Adds a new command to the set
        /// </summary>
        /// <param name="command"></param>
        public void RegisterCommand(RobotCommand command)
        {
            _commands.Add(command);
        }

        /// <summary>
        /// Adds an array of command to the worker
        /// </summary>
        /// <param name="commands"></param>
        public void RegisterCommand(RobotCommand[] commands)
        {
            _commands.AddRange(commands);
        }

        /// <summary>
        /// Send a set of command to the robot
        /// </summary>
        /// <param name="robot"></param>
        public void SendToRobot(IRobot robot)
        {
            _commands.ForEach(command => command.Execute(robot));
        }
    }
}
