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
    public partial class FlightStateController : UserControl
    {
        private FlightStateControllerVM vm;

        public FlightStateControllerVM VM
        {
            get { return vm; }
            set 
            { 
                  vm = value;
                  stateControllerSlider.DataContext = vm;
            }
        }
        public FlightStateController()
        {
            InitializeComponent();
        }

        private void stateControllerSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vm.changeIndex();
        }

       
       
    }
}
