using Memory;
using System.ComponentModel;

namespace Black_Ops_1_external
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mem m = new Mem();
        string processName = "BlackOpsMP";
        bool ProcOpen = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess(processName);
            if (!ProcOpen)
            {
                Thread.Sleep(1500);

                return;
            }
            Thread.Sleep(1500);

            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                gameStatusLabel.ForeColor = Color.SeaGreen;
                gameStatusLabel.Text = "Game Found!";
                m.OpenProcess(processName);
            }
        }

        private void fovScaleToggle_Click(object sender, EventArgs e)
        {
            if (fovScaleToggle.Text == "Off")
            {
                fovScaleToggle.Text = "On";
                fovScaleTimer.Start();
            }
            else
            {
                fovScaleToggle.Text = "Off";
                fovScaleTimer.Stop();
                m.WriteMemory("D52388, 18", "float", "1");

            }
        }

        private void fovScaleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("D52388, 18", "float", fovScaleTextbox.Text);
            }
            catch { }

        }

        private void fovToggle_Click(object sender, EventArgs e)
        {
            if (fovToggle.Text == "Off")
            {
                fovToggle.Text = "On";
                fovTimer.Start();
            }
            else
            {
                fovToggle.Text = "Off";
                fovTimer.Stop();
                m.WriteMemory("D52624, 18", "float", "65");

            }
        }

        private void fovTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("D52624, 18", "float", fovVal.Text);
            }
            catch { }

        }

        private void UAVtoggle_Click(object sender, EventArgs e)
        {
            if (UAVtoggle.Text == "Off")
            {
                UAVtoggle.Text = "On";
                UAVTimer.Start();
            }
            else
            {
                UAVtoggle.Text = "Off";
                UAVTimer.Stop();
                m.WriteMemory("0x00EE2AAC", "int", "0");
                m.WriteMemory("0xC97834, 18", "float", "4");
                m.WriteMemory("0xC97858, 18", "float", "2");

            }
        }

        private void UAVTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("0x00EE2AAC", "int", "1");
                m.WriteMemory("0xC97834, 18", "float", UAVVal.Text);
                m.WriteMemory("0xC97858, 18", "float", UAVVal.Text);
            }
            catch { }

        }
    }
}