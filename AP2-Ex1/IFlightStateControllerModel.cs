using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    interface IFlightStateControllerModel
    {
        public String getLine();

        public int NumberOfCSVLines { get; set; }
        public void changeIndexOfLine(int x);
        public int CurrentIndexOfLine { get; set; }

        public event Notifier notifyNumberOfLinesChanged;
        public event Notifier notifyCurrentIndexChanged;

    }
}
