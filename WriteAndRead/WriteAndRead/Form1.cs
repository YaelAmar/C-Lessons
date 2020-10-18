using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteAndRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "../../f1.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs;
            if(File.Exists(path))
            {
                fs = new FileStream(path,FileMode.Append,FileAccess.Write);
            }
            else
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
           
            writer.WriteLine(textBox1.Text);
           
            writer.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(path,
                                     FileMode.Open,
                                     FileAccess.Read);

            StreamReader reader = new StreamReader(fs);

            string str = reader.ReadToEnd();
            label1.Text = str;

            reader.Close();
            fs.Close();
        }
    }
    }

