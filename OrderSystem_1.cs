using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuarantine
{
	public partial class OrderSystem_1 : Form
	{
		

		public OrderSystem_1(int i)
		{
			InitializeComponent();
			
		}

		public OrderSystem_1()
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void OrderSystem_1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
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

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((textBox1.Text!="")&&(comboBox1.Text!="")) 
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox1.Text);//get the quantity of product
				float timi = (float)(1.6 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			} 
			if ((textBox1.Text == "") ||(comboBox1.Text == ""))
			{
				MessageBox.Show("Συμπληρώστε τα πεδία της ποσότητας καφέδων και της ποσότητας ζάχαρης");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if ((textBox2.Text != "") && (comboBox2.Text != "")) {
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox2.Text);//get the quantity of product
				float timi = (float)(1.5 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			if ((textBox2.Text == "") || (comboBox2.Text == ""))
			{
				MessageBox.Show("Συμπληρώστε τα πεδία της ποσότητας καφέδων και της ποσότητας ζάχαρης");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if ((textBox3.Text != "") && (comboBox3.Text != ""))
			{ 
			string arxiki = (label17.Text); //get the money of basket
			float flt1 = float.Parse(arxiki);//get the money of basket
			int posothta = Int16.Parse(textBox3.Text);//get the quantity of product
			float timi = (float)(1.2 * posothta);//calculate the price of this product
			flt1 = flt1 + timi; //adds the price
			label17.Text = flt1.ToString();//show the price
			}
			if ((textBox3.Text == "") || (comboBox3.Text == ""))
			{
				MessageBox.Show("Συμπληρώστε τα πεδία της ποσότητας καφέδων και της ποσότητας ζάχαρης");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if ((textBox4.Text != "") && (comboBox4.Text != "")) {
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox1.Text);//get the quantity of product
				float timi = (float)(1.0 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			if ((textBox4.Text == "") || (comboBox4.Text == ""))
			{
				MessageBox.Show("Συμπληρώστε τα πεδία της ποσότητας καφέδων και της ποσότητας ζάχαρης");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textBox5.Text != "" )
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox5.Text);//get the quantity of product
				float timi = (float)(5.0 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			if ((textBox5.Text == "") )
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void label22_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (textBox6.Text != "" )
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox6.Text);//get the quantity of product
				float timi = (float)(8.0 * posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			if ((textBox6.Text == ""))
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (textBox6.Text != "")
			{
				string arxiki = (label17.Text); //get the money of basket
				float flt1 = float.Parse(arxiki);//get the money of basket
				int posothta = Int16.Parse(textBox7.Text);//get the quantity of product
				float timi = (float)(5* posothta);//calculate the price of this product
				flt1 = flt1 + timi; //adds the price
				label17.Text = flt1.ToString();//show the price
			}
			if ((textBox7.Text == ""))
			{
				MessageBox.Show("Συμπληρώστε το πεδίο της ποσότητας ");
			}
		}

		private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			/*
			 this.Hide();
			OrderSystem_1 a = new OrderSystem_1();
			a.Closed += (s, args) => this.Close();
			a.Show();
			 */
			string i = "coffee";
			if (label17.Text!="0")
			{
				this.Hide();
				string price = label17.Text;
				OrderSystem_2 a = new OrderSystem_2(price,i);
				a.Closed += (s, args) => this.Close();
				a.Show();
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			/*if (label17.Text != "0")
			{
				this.Hide();
				string price = label17.Text;
				OrderSystem_2 a = new OrderSystem_2(price);
				a.Closed += (s, args) => this.Close();
				a.Show();
			}*/
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
