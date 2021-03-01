using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace Assignment_2
{
    class ResourceMonitor
    {
        PerformanceStatistics stats = new PerformanceStatistics();

        private DispatcherTimer timer;

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

        private float _ramUsage;

        public float RamUsage
        {
            get { return _ramUsage; }
            set { _ramUsage = value; }
        }



        public ResourceMonitor()
        {
            timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromMilliseconds(1000);

            timer.Tick += new EventHandler(TimeChanged);

            timer.Start();

            CpuUsage = stats.GetCurrentCpuUsage();
            RamUsage = stats.GetCurrentAvailableRam();
        }

        public void TimeChanged(object Sender, EventArgs e)
        {

            float CPU = stats.GetCurrentCpuUsage();
            float RAM = stats.GetCurrentAvailableRam();
            EventArgs args = new EventArgs();

            if (CPU != CpuUsage || RAM != RamUsage)
            {
                TriggerUpdateEvent(args);
            }

            CpuUsage = CPU;
            RamUsage = RAM;

            TriggerTickEvent(args);
        }

        public delegate void TickedEventHandler(object sender, EventArgs e);

        public event TickedEventHandler TickEvent;

        private void TriggerTickEvent(EventArgs data)
        {
            if (TickEvent != null)
            {
                TickEvent(this, data);
            }
        }

        public delegate void UpdateEventHandler(object sender, EventArgs e);

        public event UpdateEventHandler UpdateEvent;

        private void TriggerUpdateEvent(EventArgs data)
        {
            if (UpdateEvent != null)
            {
                UpdateEvent(this, data);
            }
        }

    }
}
