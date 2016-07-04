using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureQuiz
{
    public partial class TelephoneJokerDialog : Form
    {
        public TelephoneJokerDialog()
        {
            InitializeComponent();
            progressBarTime.Maximum = 120;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            disableTimer();
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerStart();
        }

        private void timerStart()
        {
            timerSeconds.Enabled = true;
            timerSeconds.Start();
            buttonStart.Enabled = false;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (progressBarTime.Value < 120)
            {
                //progressBarTime.Value += 1;
                progressBarTime.Increment(1);
            }
            else
            {
                disableTimer();
                this.Close();
            }
        }

        private void disableTimer()
        {
            timerSeconds.Stop();
            timerSeconds.Enabled = false;
        }
    }
}
