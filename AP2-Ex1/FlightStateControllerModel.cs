using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class FlightStateControllerModel : IFlightStateControllerModel
    {
        public event Notifier notifyNumberOfLinesChanged;
        public event Notifier notifyCurrentIndexChanged;
        private int currentIndexOfLine = 0;
        private int numberOfCSVLines = 0;
        public FlightStateControllerModel()
        {
        }
        public int NumberOfCSVLines {
            get { return this.numberOfCSVLines; } 
            set
            {
                this.numberOfCSVLines = value;
                notifyNumberOfLinesChanged();
            } 
        }
        public int CurrentIndexOfLine {
            get { return this.currentIndexOfLine; }
            set 
            {
                this.currentIndexOfLine = value;
                notifyCurrentIndexChanged();
            } 
        }

        public void changeIndexOfLine(int x)
        {
            this.currentIndexOfLine = x;
        }
    }
}
