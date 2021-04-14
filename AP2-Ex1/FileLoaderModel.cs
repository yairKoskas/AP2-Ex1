using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace AP2_Ex1
{
    // loads the csv/xml file
    public class FileLoaderModel : IFileLoaderModel
    {
        private const string Fg_path = @"C:\Program Files\FlightGear 2020.3.6\data\Protocol";
        private List<String> CSVLines;
        private String XMLContent;
        public event Notifier NotifyCSVChanged;
        public event Notifier NotifyXMLChanged;

        public FileLoaderModel()
        {
            CSVLines = new List<String>();
            XMLContent = "";
        }

        // loads csv file
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

            if (NotifyCSVChanged != null)
            {
                NotifyCSVChanged();
            }
        }

        // loads xml file
        public void LoadXML()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                File.WriteAllText(Fg_path, File.ReadAllText(dlg.FileName));
            }

            if (NotifyXMLChanged != null)
            {
                NotifyXMLChanged();
            }
        }

        // gets line X of the file
        public string GetCSVLine(int x)
        {
            if(x >= CSVLines.Count)
            {
                return null;
            }
            return CSVLines[x];
        }

        // returns how many lines in the file
        public int GetNumOfCSVLines()
        {
            return CSVLines.Count;
        }
    }
}
