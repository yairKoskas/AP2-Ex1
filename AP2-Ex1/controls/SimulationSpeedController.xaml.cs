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
    public partial class SimulationSpeedController : UserControl
    {
        private SimulationSpeedControllerVM vm;

        public SimulationSpeedControllerVM VM
        {
            get { return vm; }
            set
            {
                vm = value;
                speed.DataContext = vm;
            }
        }
        public SimulationSpeedController()
        {
            InitializeComponent();
        }

        private void inc_Click(object sender, RoutedEventArgs e)
        {
            vm.increaseSpeed();
        }

        private void speed_TextChanged(object sender, TextChangedEventArgs e)
        {
            vm.setSpeed();
        }

        private void dec_Click(object sender, RoutedEventArgs e)
        {
            vm.decreaseSpeed();
        }
    }
}
