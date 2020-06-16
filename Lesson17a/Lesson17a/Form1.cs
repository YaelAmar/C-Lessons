using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson17a
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            (groupBox1.Controls[groupBox1.Controls.IndexOf(radioButton3)] as RadioButton).Checked = true;
        }

      

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            lblMessage.Text = "ההודעה נקלטה בהצלחה";
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            btnOk.BackColor = button1.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("שלום למגמת מחשבים","הודעה חשובה", MessageBoxButtons.YesNoCancel);
        }
    }
}
