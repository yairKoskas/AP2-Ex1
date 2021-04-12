using System;
using System.Collections.Generic;
using System.Text;

namespace AP2_Ex1
{
    class FlightStateControllerVM
    {
        private IFlightStateControllerModel flightStateController;

        private int currentIndexOfLine =0;
        private int numberOfLines =0;

        public FlightStateControllerVM(FlightStateControllerModel model)
        {
            this.flightStateController = model;
            model.notifyCurrentIndexChanged += delegate ()
            {
                currentIndexOfLine = model.CurrentIndexOfLine;
            };

            model.notifyNumberOfLinesChanged += delegate ()
            {
                numberOfLines = model.NumberOfCSVLines;
            };
        }
        public void changeIndex()
        {
            flightStateController.changeIndexOfLine(currentIndexOfLine);
        }

    }
}
