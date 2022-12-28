using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        bool a = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<char> allowedChars = textBox2.Text.ToList();
            Random r = new Random();
            string s = "";
            if(a == false)
            {
                for (int i = 0; i < numericUpDown1.Value; i++) { if (allowedChars == null) { break; } else { s += allowedChars[r.Next(0, allowedChars.Count)]; } }
                textBox1.Text = s;
            } else
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    char c = allowedChars[r.Next(0, allowedChars.Count)];
                    allowedChars.Remove(c);
                    s += c;
                    textBox1.Text = s;
                }
            }
        }                

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<char> list = textBox2.Text.ToList();
            if (list.Count < numericUpDown1.Value) { checkBox1.Checked = false; checkBox1.Enabled = false; }
            else { checkBox1.Enabled = true; }
        }
    }
}
