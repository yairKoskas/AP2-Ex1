using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AP2_Ex1
{
    // runs the flight simulation
    public class SimulationRunnerModel : ISimulationRunnerModel
    {
        private Boolean stop = true;
        private IFileLoaderModel fileLoader;
        private IFlightStateControllerModel stateController;
        private ISimulationSpeedControllerModel speedController;

        // gets all needed models and initializes
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

        // runs the simulation
        public void startSimulation(){
            stop = false;
            TcpClient tcpClient = new TcpClient("127.0.0.1", 4500);
            String line = fileLoader.GetCSVLine(stateController.CurrentIndexOfLine);
            int millisecondsPerFrame, startTime, usedTime, milliSecondLeftToSleep;

            while ( line != null)
            {
                startTime = DateTime.Now.Millisecond; // for timing
                millisecondsPerFrame = speedController.getTimeToSleep();

                // show next shot
                stateController.CurrentIndexOfLine = stateController.CurrentIndexOfLine + 1;
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(line);
                NetworkStream stream = tcpClient.GetStream();
                stream.Write(data, 0, data.Length);

                // sleep the rest of the time (if needed)
                usedTime = DateTime.Now.Millisecond - startTime;
                milliSecondLeftToSleep = millisecondsPerFrame - usedTime;
                if (milliSecondLeftToSleep > 0)
                {
                    Thread.Sleep(speedController.getTimeToSleep());
                }
            }
        }

        // stops the simulation
        public void stopSimulation()
        {
            stop = true;
        }
    }
}
