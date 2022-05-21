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
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
    
        }

        private void House_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            button13.Visible = false;
            pictureBox4.Visible = false;
            pictureBox1.Visible = false;
            button15.Visible = false;
            pictureBox7.Visible = false;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            button12.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button13.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            button14.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            button15.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button16.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(1, 4);
            if (a==1)
            {
                MessageBox.Show("Η θερμοκρασία έξω είναι χαμηλή. Καλύτερα να ανεβάσετε τη θέρμανση!");
            }
            else if(a==2)
            {
                MessageBox.Show("Η θερμοκρασία έξω είναι υψηλή. Καλύτερα να χαμηλώσετε τη θέρμανση!");
            }
             else
            {
                MessageBox.Show("Η θερμοκρασία ρυθμίστηκε επιτυχώς!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
