using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    public class FlightStateControllerVM
    {
        private IFlightStateControllerModel flightStateController;

        private int currentIndexOfLine =0;
        private int numberOfLines =0;

        public int CurrentIndexOfLine {
            get { return this.currentIndexOfLine; } 
            set
            {
                this.currentIndexOfLine = value;
            }
        }

        public int NumberOfCSVLines
        {
            get { return this.numberOfLines; }
            set
            {
                this.numberOfLines = value;
            }
        }
        public FlightStateControllerVM(IFlightStateControllerModel model)
        {
            this.flightStateController = model;
            model.notifyCurrentIndexChanged += delegate ()
            {
                CurrentIndexOfLine = model.CurrentIndexOfLine;
            };

            model.notifyNumberOfLinesChanged += delegate ()
            {
                NumberOfCSVLines = model.NumberOfCSVLines;
            };
        }
        public void changeIndex()
        {
            flightStateController.changeIndexOfLine(currentIndexOfLine);
        }

    }
}
