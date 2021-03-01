using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class RAMEventArgs : EventArgs
    {
        private float _ramUsage;

        public float RamUsage
        {
            get { return _ramUsage; }
            set { _ramUsage = value; }
        }

        private float _ramAverage;

        public float ramAverage
        {
            get { return _ramAverage; }
            set { _ramAverage = value; }
        }
    }
}
