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

namespace AP2_Ex1
{
    /// <summary>
    /// Interaction logic for FileLoaderView.xaml
    /// </summary>
    public partial class FileLoaderView : UserControl
    {
        IFileLoaderViewModel viewModel;
        public FileLoaderView()
        {
            InitializeComponent();
            viewModel = new FileLoaderViewModel();
        }
        private void CSV_Click(object sender, RoutedEventArgs e)
        {
            viewModel.LoadCSV();
        }

        private void XML_Click(object sender, RoutedEventArgs e)
        {
            viewModel.LoadXML();
        }
    }
}
