using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownScheduler
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            int atHour = (int)nudHr.Value;
            int atMinute = (int)nudMin.Value;
            int requestedShutdownInSeconds = 3600 * atHour + 60 * atMinute;

            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;
            int currentTimeInSeconds = 3600 * currentHour + 60 * currentMinute;

            int timeTillShutdown;

            if (requestedShutdownInSeconds > currentTimeInSeconds) //e.g. shut down at 23:30, current time is 22:30
            {
                timeTillShutdown = requestedShutdownInSeconds - currentTimeInSeconds;
            }
            else //e.g. shut down at 0:30, current time is 23:30
            {
                int timeToMidnightInSeconds = 24 * 3600 - currentTimeInSeconds;

                timeTillShutdown = requestedShutdownInSeconds + timeToMidnightInSeconds;
            }

            Process.Start("cmd.exe", $"/C shutdown -s -t {timeTillShutdown}");
            this.Close();
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudMin.Value == -1)
            {
                nudMin.Value = 59;
            }

            if ((int)nudMin.Value == 60)
            {
                nudMin.Value = 0;
            }
        }

        private void nudHr_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudHr.Value == -1)
            {
                nudHr.Value = 23;
            }

            if ((int)nudHr.Value == 24)
            {
                nudHr.Value = 0;
            }
        }
    }
}
