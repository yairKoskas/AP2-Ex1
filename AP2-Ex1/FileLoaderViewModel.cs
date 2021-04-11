using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class FileLoaderViewModel : IFileLoaderViewModel
    {
        IFileLoaderModel model;

        public FileLoaderViewModel()
        {
            model = new FileLoaderModel();
        }
        public string GetCSVLine(int x)
        {
            return model.GetCSVLine(x);
        }

        public int GetNumOfCSVLines()
        {
            return model.GetNumOfCSVLines();
        }

        public void LoadCSV()
        {
            model.LoadCSV();
        }

        public void LoadXML()
        {
            model.LoadXML();
        }
    }
}
