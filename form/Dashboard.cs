using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void billingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            billing obj1 = new billing();
            obj1.Show();
        }

        private void calculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            calculator obj2 = new calculator();
            obj2.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj3 = new Form1();
            obj3.Show();
        }

        private void imagesliderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            imageslider obj4 = new imageslider();
            obj4.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void studentdataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            s ob = new s();
            ob.Show();
        }

        private void sliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slider obj5 = new slider();
            obj5.Show();
        }

        private void rawmaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rawmatrial obj6 = new rawmatrial();
            obj6.Show();
        }

        private void greatestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greatest obj7 = new greatest();
            obj7.Show();
        }

        private void primeornotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prime_or_not obj8 = new prime_or_not();
            obj8.Show();
        }
    }
}
