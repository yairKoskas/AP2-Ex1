using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class SimulationSpeedControllerView : ISimulationSpeedControllerView
    {
        private ISimulationSpeedControllerVM speedControllerVM;

        public SimulationSpeedControllerView(ISimulationSpeedControllerVM vm)
        {
            speedControllerVM = vm;
        }

        public void decreaseSpeed()
        {
            speedControllerVM.decreaseSpeed();
        }

        public void increaseSpeed()
        {
            speedControllerVM.increaseSpeed();
        }

        public void setSpeed(double speed)
        {
            speedControllerVM.setSpeed(speed);
        }
    }
}
