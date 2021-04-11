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
        List<String> CSVLines;
        String XMLContent;
        public event IFileLoaderModel.Notifier NotifyCSVChanged;
        public event IFileLoaderModel.Notifier NotifyXMLChanged;

        public FileLoaderModel()
        {
            CSVLines = new List<String>();
            XMLContent = "";
        }

        event Notifier IFileLoaderModel.NotifyCSVChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Notifier IFileLoaderModel.NotifyXMLChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
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
            throw new NotImplementedException();
        }

        public string getCSVLine(int x)
        {
            return CSVLines[x];
        }
    }
}
