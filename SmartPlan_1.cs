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
	public partial class SmartPlan_1 : Form
	{
		public SmartPlan_1()
		{
			InitializeComponent();
		}

		private void SmartPlan_1_Load(object sender, EventArgs e)
		{
            pictureBox1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{


			if ((comboBox2.Text != "") && (textBox1.Text != "") && (textBox2.Text != "") && (comboBox1.Text != "") && (checkedListBox1.SelectedIndex != -1))
			{
				bool a = checkedListBox1.GetItemChecked(0);
				bool b = checkedListBox1.GetItemChecked(1);
				bool c = checkedListBox1.GetItemChecked(2);

				if (((a == true) && (c == true)) || ((b == true) && (c == true)))
				{
					MessageBox.Show("Επιλέξτε αν θέλετε να πάρετε καφέ ή φαγητό ");
				}
				else
				{
                    pictureBox1.Visible = true;

                    comboBox2.Text = "";
					textBox1.Text = "";
					textBox2.Text = "";
					comboBox1.Text = "";
					for (int i = 0; i < checkedListBox1.Items.Count; i++)
					{
						checkedListBox1.SetItemChecked(i, false);
					}
				}

			}
			else
			{
				MessageBox.Show("Συμπληρώστε τα στοιχεία της φόρμας");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ((comboBox2.Text != "") && (textBox1.Text != "") && (textBox2.Text != "") && (comboBox1.Text != "") && (checkedListBox1.SelectedIndex != -1))
			{
				bool a = checkedListBox1.GetItemChecked(0);
				bool b = checkedListBox1.GetItemChecked(1);
				bool c = checkedListBox1.GetItemChecked(2);

				if (((a == true) && (c == true))||((b == true) && (c == true)))
				{
					MessageBox.Show("Επιλέξτε αν θέλετε να πάρετε καφέ ή φαγητό ");
				}
				else
				{ 
				
					comboBox2.Text = "";
					textBox1.Text = "";
					textBox2.Text = "";
					comboBox1.Text = "";
					for (int i = 0; i < checkedListBox1.Items.Count; i++)
					{
						checkedListBox1.SetItemChecked(i, false);
					}
				}


			}
			else
			{
				MessageBox.Show("Συμπληρώστε τα στοιχεία της φόρμας");

			}
			/*SmartPlan_1 a = new SmartPlan_1();
			a.Show();*/
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
