using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using expressmedia.robots.sdk;

namespace expressmedia.workers
{
    /// <summary>
    /// Abstract robot's command
    /// </summary>
    public abstract class RobotCommand
    {
        protected RobotCommand()
        {
        }

        public virtual void Execute(IRobot robot)
        {
        }
    }

    /// <summary>
    /// Robot's beep command
    /// </summary>
    public sealed class RobotBeepCommand : RobotCommand
    {
        public override void Execute(IRobot robot)
        {
            robot?.Beep();
        }
    }

    /// <summary>
    /// Robot's move command
    /// </summary>
    public sealed class RobotMoveCommand : RobotCommand
    {
        private readonly double _distance = 0.0;

        public RobotMoveCommand(double distance)
        {
            _distance = distance;
        }

        public override void Execute(IRobot robot)
        {
            robot?.Move(_distance);
        }
    }

    /// <summary>
    /// Robot's turn command
    /// </summary>
    public sealed class RobotTurnCommand : RobotCommand
    {
        private readonly double _angle = 0.0;

        public RobotTurnCommand(double angle)
        {
            _angle = angle;
        }

        public override void Execute(IRobot robot)
        {
            robot?.Turn(_angle);
        }
    }
}
