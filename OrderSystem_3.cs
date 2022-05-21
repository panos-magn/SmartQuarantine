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
	public partial class OrderSystem_3 : Form
	{
		public OrderSystem_3(int j)
		{
			InitializeComponent();
		}

		public OrderSystem_3()
		{
		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((textBox1.Text != "") )
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox1.Text);//get the quantity of product
				float timi = (float)(1800 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the pric
			}
			else
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if ((textBox2.Text != ""))
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox2.Text);//get the quantity of product
				float timi = (float)(1200 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			else
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if ((textBox4.Text != ""))
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox4.Text);//get the quantity of product
				float timi = (float)(855 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			else
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if ((textBox3.Text != ""))
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox3.Text);//get the quantity of product
				float timi = (float)(700 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the pric
			}
			else
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (label17.Text != "0")
			{
				string j = "eshop";
				this.Hide();
				string price = label17.Text;
				OrderSystem_2 a = new OrderSystem_2(price,j);
				a.Closed += (s, args) => this.Close();
				a.Show();
			}
		}

		private void OrderSystem_3_Load(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			OrderSystem a = new OrderSystem();
			a.Closed += (s, args) => this.Close();
			a.Show();
		}
	}
}
