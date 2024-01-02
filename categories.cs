using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSJ
{
    public partial class categories : Form
    {
        public categories()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dairy nextform = new dairy();
            nextform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bakery nextform = new bakery();
            nextform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cannedfood nextform = new cannedfood();
            nextform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beverages nextform = new beverages();
            nextform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frozenfood nextform = new frozenfood();
            nextform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meat nextform = new meat();
            nextform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            poulty nextform = new poulty();
            nextform.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seafood nextform = new seafood();
            nextform.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vegetables nextform = new vegetables();
            nextform.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fruit nextform = new fruit();
            nextform.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sweet nextform = new sweet();
            nextform.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groceries nextform = new groceries();
            nextform.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            beautyproducts nextform = new beautyproducts();
            nextform.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            snacks nextform = new snacks();
            nextform.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            detergents nextform = new detergents();
            nextform.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            informations nextform = new informations();
            nextform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ("textBox1.Text" == "bakery")
                {
                    bakery.Focus();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            Button selectedButton = this.Controls.OfType<Button>().FirstOrDefault(b => b.Name == selectedItem);
            if(selectedButton != null)

            {

                selectedButton.Focus();
            }
        }
    }
}

