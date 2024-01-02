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
    public partial class CashORVisa : Form
    {
        public CashORVisa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visa nextform = new Visa();
            nextform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash nextform = new Cash();
            nextform.Show();
            this.Hide();
        }
    }
}
