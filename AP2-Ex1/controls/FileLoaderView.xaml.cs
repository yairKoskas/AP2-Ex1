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
    /// Interaction logic for FileLoaderView.xaml
    /// </summary>
    public partial class FileLoaderView : UserControl
    {
        private IFileLoaderViewModel viewModel;

        public IFileLoaderViewModel VM
        {
            get { return viewModel; }
            set
            {
                viewModel = value;
            }
        }
        public FileLoaderView()
        {
            InitializeComponent();
        }

        private void Load_CSV(object sender, RoutedEventArgs e)
        {
            viewModel.LoadCSV();
        }
        private void Load_XML(object sender, RoutedEventArgs e)
        {
            viewModel.LoadXML();
        }

    }
}
