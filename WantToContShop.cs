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
    public partial class WantToContShop : Form
    {
        public WantToContShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categories nextform = new categories();
            nextform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewRemoveCheckout nextform = new ViewRemoveCheckout();
            nextform.Show();
            this.Hide();
        }
    }
}
