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
	public partial class OrderSystem : Form
	{
		public OrderSystem()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 1;
			this.Hide();
			OrderSystem_1 a = new OrderSystem_1(i);
			a.Closed += (s, args) => this.Close();
			a.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int j = 2;
			this.Hide();
			OrderSystem_3 a = new OrderSystem_3(j);
			a.Closed += (s, args) => this.Close();
			a.Show();
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if ((textBox1.Text!="")&& (textBox2.Text != "")&& (textBox3.Text != "")&& (textBox4.Text != "")&& (textBox5.Text != ""))
			{
				/*this.Hide();
				OrderSystem_1 a = new OrderSystem_1();
				a.Closed += (s, args) => this.Close();*/
				foreach (Control c in this.Controls)
				{
					c.Visible = false;//or true.

				}
				button1.Visible = true;
				button2.Visible = true;
				button3.Visible = true;
				label1.Visible = true;
				button3.Location = new Point(244, 262);
				
				
				


			}
		}

		private void OrderSystem_Load(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}


}
