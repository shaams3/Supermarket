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
    public partial class LastOne : Form
    {
        public LastOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nextform = new Form1();
            nextform.Show();
            this.Hide();
        }

        private void LastOne_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Thank You!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
