using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    // controls the simulation speed
    public class SimulationSpeedControllerModel : ISimulationSpeedControllerModel
    {
        // default values
        public const double diffValue = 0.25;
        public const int FPS = 60;
        public const int DEFAULT_SPEED = 1;

        private double simulationSpeed;

        public event Notifier notifySpeedIncrease;
        public event Notifier notifySpeedDecrease;

        public SimulationSpeedControllerModel(double speed)
        {
            if (speed > 0)
            {
                simulationSpeed = speed;
            }
            else
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
            return (int) (FPS * simulationSpeed * 1000); // FPS * speed -> convert to millis
        }
    }
}
