using System;
using System.Windows;

namespace AP2_Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ISimulationSpeedControllerVM speedController;
        public MainWindow()
        {
            IFileLoaderModel fileLoaderModel = new FileLoaderModel();
            FileLoaderViewModel fileLoaderVM = new FileLoaderViewModel(fileLoaderModel);

            IFlightStateControllerModel stateControllerModel = new FlightStateControllerModel();
            FlightStateControllerVM stateControllerVM = new FlightStateControllerVM(stateControllerModel);

            ISimulationSpeedControllerModel speedControllerModel = new SimulationSpeedControllerModel(1);
            SimulationSpeedControllerVM speedControllerVM = new SimulationSpeedControllerVM(speedControllerModel);

            ISimulationRunnerModel simulationRunnerModel = new SimulationRunnerModel(fileLoaderModel, stateControllerModel, speedControllerModel);
            SimulationRunnerVM simulationRunnerVM = new SimulationRunnerVM(simulationRunnerModel);

            fileLoaderView.VM = fileLoaderVM;
            stateControllerView.VM = stateControllerVM;
            speedControllerView.VM = speedControllerVM;
            simulationRunnerView.VM = simulationRunnerVM;
            InitializeComponent();
        }
    }
}
