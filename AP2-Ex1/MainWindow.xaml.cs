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
            InitializeComponent();
            speedController = new SimulationSpeedControllerVM();
            this.DataContext = speedController;
        }

        private void inc_Click(object sender, EventArgs args)
        {
            speedController.increaseSpeed();
        }
    }
}
