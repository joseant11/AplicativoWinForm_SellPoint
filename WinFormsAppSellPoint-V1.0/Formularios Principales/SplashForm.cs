using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppSellPoint_V1._0
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        //Evento para que la progressBar aumente
        private void timerSplashForm_Tick(object sender, EventArgs e)
        {
            timerSplashForm.Enabled = true;
            CircleProgressBarSplash.Increment(2);
            labelProgressBar.Text = CircleProgressBarSplash.Value.ToString() + "%";

            if(CircleProgressBarSplash.Value == 100) 
            {
                timerSplashForm.Enabled = false;
                this.Close();
            }
        }
    }
}
