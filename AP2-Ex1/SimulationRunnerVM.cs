using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    public class SimulationRunnerVM
    {
        private ISimulationRunnerModel model;
        
        public SimulationRunnerVM(ISimulationRunnerModel model)
        {
            this.model = model;
        }

        public void startSimulation()
        {
            model.startSimulation();
        }

        public void stopSimulation()
        {
            model.stopSimulation();
        }
    }
}
