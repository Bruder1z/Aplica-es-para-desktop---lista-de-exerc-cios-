using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, n4, media;
            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);
            n3 = float.Parse(textBox3.Text);
            n4 = float.Parse(textBox4.Text);
            media = (n1 + n2 + n3 + n4) / 4;
            MessageBox.Show("Média = " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
