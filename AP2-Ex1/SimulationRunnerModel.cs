using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AP2_Ex1
{
    class SimulationRunnerModel : ISimulationRunnerModel
    {
        private Boolean stop = true;
        private IFileLoaderModel fileLoader;
        private IFlightStateControllerModel stateController;
        private ISimulationSpeedControllerModel speedController;

        public SimulationRunnerModel(IFileLoaderModel fileLoader, IFlightStateControllerModel stateController, ISimulationSpeedControllerModel speedController)
        {
            fileLoader.NotifyCSVChanged += delegate ()
            {
                stateController.CurrentIndexOfLine = fileLoader.GetNumOfCSVLines();
            };
            this.fileLoader = fileLoader;
            this.stateController = stateController;
            this.speedController = speedController;
        }

        public void startSimulation(){
            stop = false;
            TcpClient tcpClient = new TcpClient("127.0.0.1", 4500);
            String line = fileLoader.GetCSVLine(stateController.CurrentIndexOfLine);
            while ( line != null)
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(line);
                NetworkStream stream = tcpClient.GetStream();
                stream.Write(data, 0, data.Length);
                Thread.Sleep(speedController.getTimeToSleep());
            }
        }
        public void stopSimulation()
        {
            stop = true;
        }
    }
}
