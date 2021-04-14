using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class SimulationSpeedControllerVM : ISimulationSpeedControllerVM
    {
        private ISimulationSpeedControllerModel speedControllerModel;
        double simulationSpeed { get; set; } // bind to view textbox

        public SimulationSpeedControllerVM(ISimulationSpeedControllerModel model, Notifier speedIncrease, Notifier speedDecrease)
        {
            speedControllerModel = model;
            model.notifySpeedDecrease += speedDecrease;
            model.notifySpeedIncrease += speedIncrease;
        }

        public SimulationSpeedControllerVM(Notifier speedIncrease, Notifier speedDecrease)
        {
            speedControllerModel = new SimulationSpeedControllerModel(simulationSpeed);
            speedControllerModel.notifySpeedDecrease += speedDecrease;
            speedControllerModel.notifySpeedIncrease += speedIncrease;
        }

        public void decreaseSpeed()
        {
            speedControllerModel.decreaseSpeed();
        }

        public void increaseSpeed()
        {
            speedControllerModel.increaseSpeed();
        }

        public void setSpeed(double speed)
        {
            speedControllerModel.setSpeed(speed);
        }
    }
}
