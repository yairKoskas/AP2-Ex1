using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class SimulationSpeedControllerVM : ISimulationSpeedControllerVM
    {
        private ISimulationSpeedControllerModel speedControllerModel;
        public string VM_SimulationSpeed { get; set; } // bind to view textbox

        public SimulationSpeedControllerVM(ISimulationSpeedControllerModel model)
        {
            speedControllerModel = model;
            model.notifySpeedDecrease += delegate()
            {
                VM_SimulationSpeed = speedControllerModel.getSimulationSpeed().ToString();
            };
            model.notifySpeedIncrease += delegate ()
            {
                VM_SimulationSpeed = speedControllerModel.getSimulationSpeed().ToString();
            };
            VM_SimulationSpeed = speedControllerModel.getSimulationSpeed().ToString();
        }

        public SimulationSpeedControllerVM()
        {
            speedControllerModel = new SimulationSpeedControllerModel(0);
            speedControllerModel.notifySpeedDecrease += delegate ()
            {
                VM_SimulationSpeed = speedControllerModel.getSimulationSpeed().ToString();
            };
            speedControllerModel.notifySpeedIncrease += delegate ()
            {
                VM_SimulationSpeed = speedControllerModel.getSimulationSpeed().ToString();
            };
            VM_SimulationSpeed = speedControllerModel.getSimulationSpeed().ToString();
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
