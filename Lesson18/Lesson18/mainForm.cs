using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson18
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            timer1.Start();

           DialogResult dialogResult= MessageBox.Show("fjhdgj","jhf", MessageBoxButtons.YesNo);
          if(dialogResult==DialogResult.Yes)

        }
        int min = 0;
        int sec = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cldColor.ShowDialog();
            fontDialog1.ShowDialog();
            openFileDialog1.ShowDialog();
        }

        private void tt(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec<10)
                lblSeconds.Text = "0"+sec.ToString() ;
            else
                lblSeconds.Text= sec.ToString();

            if (sec > 59)
            {
                min++;
                if (min < 10)
                    lblMinutes.Text = "0" + min.ToString();
                else
                    lblMinutes.Text = min.ToString();
                sec = 0;
            }
        }

        private void lblSeconds_Click(object sender, EventArgs e)
        {

        }

        private void lblMinutes_Click(object sender, EventArgs e)
        {

        }
    }
}
