using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AP2_Ex1.controls
{
    public partial class SimulationRunnerView : UserControl
    {
        private SimulationRunnerVM vm;

        public AP2_Ex1.SimulationRunnerVM VM
        {
            get { return vm; }
            set {
                vm = value;
                DataContext = vm;
            }
        }
        public SimulationRunnerView()
        {
            InitializeComponent();
        }
        
        private void start_Click(object sender, RoutedEventArgs e)
        {
            vm.startSimulation();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            vm.stopSimulation();
        }
    }
}
