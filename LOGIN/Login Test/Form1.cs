using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtUsername.Text == "" )
            {
                MessageBox.Show("Please Enter a Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            if(txtPassword.Text == "" )
            {
                MessageBox.Show("Please Enter a Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }


            if(!(txtUsername.Text == "Admin" &&  txtPassword.Text == "Admin2026"))
            {
                MessageBox.Show("Wrong Password Or Username Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if(!(txtUsername.Text == "Admin"))
                txtUsername.Text = "";

                
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Welcome Admin","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
                AdminPanel frm = new AdminPanel();
                frm.Show();
                

            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
            
                txtPassword.PasswordChar = '\0';
            
            else
                txtPassword.PasswordChar = '*';


        }
    }
}
