using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuarantine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SmartPlan a = new SmartPlan();
			a.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form2 a = new Form2();
			a.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            House a = new House();
            a.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Elders a = new Elders();
            a.Show();        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderSystem a = new OrderSystem();
            a.Show();
        }
    }
}
