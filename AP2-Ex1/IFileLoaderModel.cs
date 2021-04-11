using System;
using System.Collections.Generic;
using System.Text;



namespace AP2_Ex1
{
    interface IFileLoaderModel
    {
        void LoadCSV();
        void LoadXML();

        String getCSVLine(int x);

        public delegate void Notifier();
        public event Notifier NotifyCSVChanged, NotifyXMLChanged;
    }
}
