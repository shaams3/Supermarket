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
   
    
    public partial class informations : Form
    {
        UserData ud = new UserData("DJS","12345678910","hh","cash");
        public informations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            categories nextform = new categories();
            nextform.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            ud.UserPhoneNumber("textBox2.Text");
            string numericText = new string(textBox2.Text.Where(char.IsDigit).ToArray());
            if (numericText.Length < 12) //numericText.Length>11)
            {
                textBox2.Text = numericText;
            }
            else
                MessageBox.Show("please try again");
            // textBox2.Text = numericText;
           
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                textBox3.Focus();
                /*    int mimo, nana;
                    mimo = textBox2.Text.Length;
                    if (mimo != 11)
                        MessageBox.Show("Invalid phone number, phone number must be 11 digit");
                    else
                    {
                        for (nana = 0; nana < mimo; nana++)
                        {
                            if ((textBox2.Text[nana] < '0') || (textBox2.Text[nana] > '9'))
                            {
                                MessageBox.Show("Invalid phone number, phone number must be only digits");
                                // Console.WriteLine(pn[nana]);
                                mimo = 0;
                            }
                        }*/
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nextform = new Form1();
            nextform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
         {

             ud.UserName("textBox1.Text");
            /* if (textBox1.Text.Length == 0) 
                 MessageBox.Show("Please Enter Your Name. ");
             else if ((("textBox1.Text"[0] < 'A') || ("textBox1.Text"[0] > 'Z')) && (("textBox1.Text"[0] < 'a') || ("textBox1.Text"[0] > 'z')))
                     MessageBox.Show("Please Enter Your Name Correctly. ");
                     */
             }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox2.Focus();
            }
        }
                       /*  if (textBox1.Text.Length == 0)
                         {
                           MessageBox.Show("Please Enter Your Name. ");
                         }
                         else if ((("textBox1.Text"[0] < 'A') || ("textBox1.Text"[0] > 'Z')) && (("textBox1.Text"[0] < 'a') || ("textBox1.Text"[0] > 'z')))
                         MessageBox.Show("Please Enter Your Name Correctly. ");
                         textBox2.Focus();
                      }
                      if (e.KeyCode == Keys.Enter)
                         {*/
        /*   if (string.IsNullOrEmpty(textBox1.Text))
               {
                 MessageBox.Show("Please enter text.");
                 }
           else
             {
                 int number;
                  if (int.TryParse(textBox1.Text, out number))
                  {
                      MessageBox.Show("Please enter text that is not a number.");
                    }
              }
              }
 }
 */
      private void textBox1_KeyPress(object sender,KeyPressEventArgs e )
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Your Name Correctly. ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            ud.UserAddress("textBox3.Text");
          
               
                if (textBox3.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Your Address Correctly.");
                  
                }

         

        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                add.Focus();
            }
        }




        private void informations_Load(object sender, EventArgs e)
        {

        }


    }
}
