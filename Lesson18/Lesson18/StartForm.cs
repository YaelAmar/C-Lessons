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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            mainForm.Show();
            this.Hide();
        }

        private void EnableNext(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "txb1")
                label3.Text = "txb1 is writing";
            else if((sender as TextBox).Name == "txb2")
            label3.Text = "txb2 is writing";



            if (txb1.Text != "" && txb2.Text != "")
            {
                button1.Visible = true;
                if (txb1.Text != txb2.Text)
                    button1.Enabled = true;
            }
        }
    }
}
