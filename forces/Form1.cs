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

       
        private double cos(double a2)
        {
            double rad2 = a2 / 180.0 * Math.PI;
            return Math.Cos(rad2);
        }

        
        private double tan(double a3)
        {
            double rad3 = a3 / 180.0 * Math.PI;
            return Math.Tan(rad3);
        }

       
        private double asin(double n1)
        {
            return Math.Asin(n1) * 180.0 / Math.PI;
        }

        
        private double acos(double n2)
        {
            return Math.Acos(n2)*180.0/Math.PI;
        }

        
        private double atan(double n3)
        {
            return Math.Atan(n3) * 180.0 / Math.PI;
        }
    }
}
