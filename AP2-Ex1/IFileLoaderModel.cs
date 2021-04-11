using System;
using System.Collections.Generic;
using System.Text;



namespace AP2_Ex1
{
    public delegate void Notifier();
    interface IFileLoaderModel
    {
        void LoadCSV();
        void LoadXML();

        String GetCSVLine(int x);
        int GetNumOfCSVLines();
        public event Notifier NotifyCSVChanged, NotifyXMLChanged;
    }
}
