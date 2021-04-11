using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace AP2_Ex1
{
    class FileLoaderModel : IFileLoaderModel
    {
        private List<String> CSVLines;
        private String XMLContent;
        public event Notifier NotifyCSVChanged;
        public event Notifier NotifyXMLChanged;

        public FileLoaderModel()
        {
            CSVLines = new List<String>();
            XMLContent = "";
        }

        public void LoadCSV()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".csv";
            dlg.Filter = "CSV Files (*.csv)|*.csv";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                var path = dlg.FileName;
                var content = File.ReadAllLines(path);
                CSVLines = new List<string>(content);
            }
            NotifyCSVChanged();
        }

        public void LoadXML()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                var path = dlg.FileName;
                XMLContent = File.ReadAllText(path);
            }
            NotifyXMLChanged();
        }

        public string getCSVLine(int x)
        {
            return CSVLines[x];
        }
    }
}
