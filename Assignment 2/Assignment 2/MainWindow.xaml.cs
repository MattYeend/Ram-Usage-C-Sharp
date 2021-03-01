using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ResourceMonitor monitor = new ResourceMonitor();

        public MainWindow()
        {
            InitializeComponent();

            monitor.UpdateEvent += new ResourceMonitor.UpdateEventHandler(monitor_UpdateEvent);

        }

        void monitor_UpdateEvent(object sender, EventArgs e)
        {
            string cpuResult = string.Format("{0:#}%",
            monitor.CpuUsage);

            string ramResult = string.Format("{0:#}MB",
            monitor.RamUsage);

            string cpuAverageResult = string.Format("{0:#}%",
            monitor.cpuAverage);

            cpuUsage.Content = cpuResult;
            ramUsage.Content = ramResult;

            if (monitor.CpuUsage >= 0)
                cpuColorSet(0);

            if (monitor.CpuUsage >= 10)
                cpuColorSet(1);

            if (monitor.CpuUsage >= 20)

                cpuColorSet(2);

            if (monitor.CpuUsage >= 30)
                cpuColorSet(3);

            if (monitor.CpuUsage >= 40)
                cpuColorSet(4);

            if (monitor.CpuUsage >= 50)
                cpuColorSet(5);

            if (monitor.CpuUsage >= 60)
                cpuColorSet(6);

            if (monitor.CpuUsage >= 70)
                cpuColorSet(7);

            if (monitor.CpuUsage >= 80)
                cpuColorSet(8);

            if (monitor.CpuUsage >= 90)
                cpuColorSet(9);
        }

        private void cpuColorSet(int CpuColors)
        {
            switch (CpuColors)
            {
                case 0:
                    CPU1.Fill = new SolidColorBrush(Colors.Green);
                    CPU2.Fill = new SolidColorBrush(Colors.White);
                    CPU3.Fill = new SolidColorBrush(Colors.White);
                    break;
                case 1:
                    CPU1.Fill = new SolidColorBrush(Colors.Green);
                    CPU2.Fill = new SolidColorBrush(Colors.Orange);
                    CPU3.Fill = new SolidColorBrush(Colors.White);
                    break;
                case 2:
                    CPU1.Fill = new SolidColorBrush(Colors.Green);
                    CPU2.Fill = new SolidColorBrush(Colors.Orange);
                    CPU3.Fill = new SolidColorBrush(Colors.Red);
                    break;
            }
        }
    }
}
