using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = double.Parse(box1.Text);
                double ans1 = sin(a1);
                label1.Text = ans1.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double sin(double a1)
        {
            double rad1 = a1 / 180.0 * Math.PI;
            return Math.Sin(rad1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a2 = double.Parse(box2.Text);
                double ans2 = cos(a2);
                label2.Text = ans2.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double cos(double a2)
        {
            double rad2 = a2 / 180.0 * Math.PI;
            return Math.Cos(rad2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a3 = double.Parse(box3.Text);
                double ans3 = tan(a3);
                label3.Text = ans3.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double tan(double a3)
        {
            double rad3 = a3 / 180.0 * Math.PI;
            return Math.Tan(rad3);
        }
    }
}
