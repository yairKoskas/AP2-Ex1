using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    interface ISimulationSpeedControllerView
    {
        void increaseSpeed();
        void decreaseSpeed();
        void setSpeed(double speed);
    }
}
