using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    public interface ISimulationSpeedControllerModel
    {
        void increaseSpeed();
        void decreaseSpeed();
        void setSpeed(double x);
        double getSimulationSpeed();
        int getTimeToSleep();

        public event Notifier notifySpeedIncrease, notifySpeedDecrease;
    }
}
