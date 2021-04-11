using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class FileLoaderModel : IFileLoaderModel
    {
        List<String> CSVLines;
        string XMLContent;
        public event IFileLoaderModel.Notifier NotifyCSVChanged;
        public event IFileLoaderModel.Notifier NotifyXMLChanged;

        public
        public void LoadCSV()
        {
            throw new NotImplementedException();
        }

        public void LoadXML()
        {
            throw new NotImplementedException();
        }
    }
}
