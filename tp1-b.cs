using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int angulo;
            angulo = int.Parse(textBox1.Text);
            double medGrau = angulo * (Math.PI / 180);

            Math.Sin(medGrau);
            Math.Cos(medGrau);
            Math.Tan(medGrau);
            double secante = 1 /Math.Cos(medGrau);
            MessageBox.Show("Sen = " + Math.Sin(medGrau));
            MessageBox.Show("Cos = " + Math.Cos(medGrau));
            MessageBox.Show("Tan = " + Math.Tan(medGrau));
            MessageBox.Show("Sec = " + secante);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
