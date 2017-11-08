using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressmedia.robots.sdk
{
    /// <summary>
    /// Base interface of 3-d party SDK
    /// </summary>
    public interface IRobot
    {
        void Move(double distance);

        void Turn(double angle);

        void Beep();
    }
}
