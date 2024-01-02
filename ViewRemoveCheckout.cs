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
    public partial class ViewRemoveCheckout : Form
    {
        Supermarket vrc = new Supermarket();
        Product product = new Product("name", 5.5);
        public ViewRemoveCheckout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            
           //vrc.PrintCart();
           // dataGridView1.Rows.Add(Product.Name,product.Price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashORVisa nextform = new CashORVisa();
            nextform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashORVisa nextform = new CashORVisa();
            nextform.Show();
            this.Hide();
        }
    }
}
