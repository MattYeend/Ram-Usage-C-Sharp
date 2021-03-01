using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class CPUEventArgs : EventArgs
    {
        private float _cpuUsage;

        public float CpuUsage
        {
            get { return _cpuUsage; }
            set { _cpuUsage = value; }
        }

        private float _cpuAverage;

        public float cpuAverage
        {
            get { return _cpuAverage; }
            set { _cpuAverage = value; }
        }
    }
}
