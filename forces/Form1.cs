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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(box1.Text);
                double ans4 = asin(n1);
                label1.Text = ans4.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double asin(double n1)
        {
            return Math.Asin(n1) * 180.0 / Math.PI;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double n2 = double.Parse(box2.Text);
                double ans5 = acos(n2);
                label2.Text = ans5.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double acos(double n2)
        {
            return Math.Acos(n2)*180.0/Math.PI;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double n3 = double.Parse(box3.Text);
                double ans6 = atan(n3);
                label3.Text = ans6.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double atan(double n3)
        {
            return Math.Atan(n3) * 180.0 / Math.PI;
        }
    }
}
