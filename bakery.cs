using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSJ
{
    struct items
    { int categ , code , price , quantity ; };
    public partial class bakery : Form
    {
      
        public bakery()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            HowMany nextform = new HowMany();
            nextform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HowMany nextform = new HowMany();
            nextform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HowMany nextform = new HowMany();
            nextform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HowMany nextform = new HowMany();
            nextform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HowMany nextform = new HowMany();
            nextform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categories nextform = new categories();
            nextform.Show();
            this.Hide();
        }
       
        private void bakery_Load(object sender, EventArgs e)
        {

        }
    }
}
