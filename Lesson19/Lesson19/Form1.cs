using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.RightToLeft = RightToLeft.Yes;
            button.Location = new Point(100, 100);
            Controls.Add(button);
            button.Text = "אישור";
        }
        //  GroupBox groupBox = new GroupBox();
        Button button = new Button();
        Button[] KeyBoard { get; set; } = new Button[27];
        private void Form1_Load(object sender, EventArgs e)
        {
            // groupBox.Size = new Size(500, 250);
            //  Controls.Add(groupBox);
            char s = 'א';

            for (int i = 0; i < KeyBoard.Length; i++)
            {

                KeyBoard[i] = new Button();
                KeyBoard[i].Text = s.ToString();
                s++;
                if (i < 10)
                    KeyBoard[i].Location = new Point(i * 30, 10);
                if (i >= 10 && i < 20)
                    KeyBoard[i].Location = new Point((i - 10) * 30, 40);
                if (i >= 20)
                    KeyBoard[i].Location = new Point((i - 20) * 30, 70);
                KeyBoard[i].Size = new Size(30, 20);

                KeyBoard[i].Click += new System.EventHandler(KeyBoard_Click);

                Controls.Add(KeyBoard[i]);
            }

        }

        private void KeyBoard_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (IsDigit(textBox1.Text))
                errorProvider1.SetError(textBox1, "אין להכיל מספרים");
            else
                errorProvider1.Clear();
        }

        private bool IsDigit(string s)
        {
            if (s.IndexOf("0") != -1 || s.IndexOf("1") != -1)
                return true;
            return false;
        }
    }
}
