using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    // view model for file loader
    public class FileLoaderViewModel : IFileLoaderViewModel
    {
        IFileLoaderModel model;

        public FileLoaderViewModel(IFileLoaderModel model)
        {
            this.model = model;
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
