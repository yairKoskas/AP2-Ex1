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
    /// <summary>
    /// Interaction logic for FlightStateController.xaml
    /// </summary>
    public partial class FlightStateController : UserControl
    {
        private FlightStateControllerVM vm;
        public FlightStateController()
        {
            this.vm = new FlightStateControllerVM(new FlightStateControllerModel());
            InitializeComponent();
            DataContext = vm;
        }

        private void stateControllerSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vm.changeIndex();
        }

       
       
    }
}
