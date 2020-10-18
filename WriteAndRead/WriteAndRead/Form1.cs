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
        //הגדרת כתובת
        const string path = "../../List.txt";
        private void button1_Click_1(object sender, EventArgs e)
        {
            //הגדרת זרם 
            FileStream fs;
            if(File.Exists(path))
            {
                fs=new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            }
            //הגדרת כתבן ושיוכו לזרם
            StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
            writer.WriteLine("שלום");

            //סגירת הזרם
            writer.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs;
            //if (File.Exists(path))
            //{
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    MessageBox.Show("עוד לא יצרת קבלה");
            //}
          
            StreamReader reader = new StreamReader(fs);
            label1.Text= reader.ReadToEnd();
            reader.Close();
            File.Delete(path);
        }
    }
    }

