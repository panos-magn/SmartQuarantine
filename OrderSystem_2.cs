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
	public partial class OrderSystem_2 : Form
	{
		private string price;

		public OrderSystem_2(string price, string i)
		{
			InitializeComponent();
			label1.Text = price;
			label6.Text = i;

		}

		public OrderSystem_2(string price)
		{
			this.price = price;
		}

		private void OrderSystem_2_Load(object sender, EventArgs e)
		{

		}

		private void radioButton1_Click(object sender, EventArgs e)
		{
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			textBox1.Visible = false;
			textBox2.Visible = false;
			dateTimePicker1.Visible = false;
			button1.Location = new Point(220, 150);
		}

		private void radioButton2_Click(object sender, EventArgs e)
		{
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;
			textBox1.Visible = true;
			textBox2.Visible = true;
			dateTimePicker1.Visible = true;
			//296,275
			button1.Location = new Point(220, 230);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((radioButton1.Checked == true) || ((radioButton2.Checked = true) && (textBox1.Text.Length == 16) && (textBox2.Text.Length == 3)))
			{
				MessageBox.Show("Η αποστολή σας στάλθηκε");
				this.Hide();
				OrderSystem a = new OrderSystem();
				a.Closed += (s, args) => this.Close();
				a.Show();
			}
			else
			{
				MessageBox.Show("Βεβαιωθείτε οτι έχετε συμπληρώσει "+"\n"+ "16 αριθμούς στον αριθμό κάρτας"+"\n"+" και 3 αριθμούς στο CVV");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (label6.Text == "coffee")
			{
				this.Hide();

				OrderSystem_1 a = new OrderSystem_1(1);
				a.Closed += (s, args) => this.Close();
				a.Show();
			}
			else if (label6.Text == "eshop")
			{
				OrderSystem_3 a = new OrderSystem_3(1);
				a.Closed += (s, args) => this.Close();
				a.Show();
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
