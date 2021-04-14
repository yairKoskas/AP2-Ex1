using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    public class SimulationSpeedControllerModel : ISimulationSpeedControllerModel
    {
        public const double diffValue = 0.25; // need to be changed
        public const int fps = 60; // please define it for me... (its for my getTimeToSleep() method)
        public const int DEFAULT_SPEED = 1;

        private double simulationSpeed;

        public event Notifier notifySpeedIncrease;
        public event Notifier notifySpeedDecrease;

        public SimulationSpeedControllerModel(double speed)
        {
            if (speed > 0)
            {
                simulationSpeed = speed;
            } else
            {
                simulationSpeed = DEFAULT_SPEED;
            }
        }

        public void increaseSpeed()
        {
            simulationSpeed += diffValue;
            if (notifySpeedIncrease != null)
            {
                notifySpeedIncrease();
            }
        }

        public void decreaseSpeed()
        {
            if (simulationSpeed > diffValue)
            {
                simulationSpeed -= diffValue;
                if (notifySpeedDecrease != null)
                {
                    notifySpeedDecrease();
                }
            }
        }

        public void setSpeed(double speed)
        {
            if (speed > 0)
            {
                simulationSpeed = speed;
            }
        }

        public double getSimulationSpeed()
        {
            return simulationSpeed;
        }

        public int getTimeToSleep()
        {
            return ((int) simulationSpeed * 1000) / fps;
        }
    }
}
