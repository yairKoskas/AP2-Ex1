using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    interface IFileLoaderViewModel
    {
        void LoadCSV();
        void LoadXML();
        String GetCSVLine(int x);
        int GetNumOfCSVLines();
    }
}
