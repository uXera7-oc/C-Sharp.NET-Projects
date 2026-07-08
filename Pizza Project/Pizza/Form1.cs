using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowPanel(panel1Pizza);
        }

        float TotalPrice = 0;
        string SizeName = "";
        string CrustType = "";
        string Toppings = "";
        string WhereToEat = "";


        private void ShowPanel(Panel p)
        {
            panel1Pizza.Visible = false;
            panel2AboutOurPizza.Visible = false;
            panel3OurMenu.Visible = false;
            panel4OrderYourPizza.Visible = false;

            p.Visible = true;
            p.BringToFront();
        }



     
        private void UpdateTotalPrice()
        {
            TotalPrice = SizePrice + CrustPrice + ToppingsPrice;

            label1TotalPrice.Text = TotalPrice.ToString() + "$";
        }



        private void BtnNext1_Click(object sender, EventArgs e)
        {
            ShowPanel(panel2AboutOurPizza);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(panel1Pizza);
        }

        private void BtnNext2_Click(object sender, EventArgs e)
        {
            ShowPanel(panel3OurMenu);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel(panel2AboutOurPizza);
        }
        private void BtnNext3_Click(object sender, EventArgs e)
        {
            ShowPanel(panel4OrderYourPizza);
        }

        float SizePrice = 0;
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSmall.Checked)
            {
                SizePrice = 5;
                SizeName = "Small";
            }
            UpdateTotalPrice();


        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMedium.Checked)
            {
                SizePrice = 7.25f;
                SizeName = "Medium";
            }
            UpdateTotalPrice();

        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLarge.Checked)
            {
                SizePrice = 10;
                SizeName = "Large";
            }
            UpdateTotalPrice();

        }

        

        float CrustPrice = 0;
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if(rbThinCrust.Checked)
            {
                CrustPrice += 3;
                CrustType = "Thin";
            }
            else
            {
                CrustPrice -= 3;
                
            }
            UpdateTotalPrice();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            if(rbThickCrust.Checked)
            {
                CrustPrice += 5;
                CrustType = "Thick";
            }
            else
            {
                CrustPrice -= 5;
                
            }
            UpdateTotalPrice();
        }

        float ToppingsPrice = 0;
        private void chkBxExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxExtraChees.Checked)
            {
                ToppingsPrice += 3;
                Toppings += "Extra Chees, ";
            }
            else
            {
                ToppingsPrice -= 3;
                
            }
            UpdateTotalPrice();
        }

        private void chkBxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxMushrooms.Checked)
            {
                ToppingsPrice += 2;
                Toppings += "Mushrooms, ";
            }
            else
            {
                ToppingsPrice -= 2;
                
            }

            UpdateTotalPrice();

        }

        private void chkBxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxTomatoes.Checked)
            {
                ToppingsPrice += 2;
                Toppings += "Tomatoes, ";
            }
            else
            {
                ToppingsPrice -= 2;
                
            }
            UpdateTotalPrice();

        }

        private void chkBxOnion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxOnion.Checked)
            {
                ToppingsPrice += 1;
                Toppings += "Onion, ";
            }
            else
            {
                ToppingsPrice -= 1;
              
            }
            UpdateTotalPrice();
        }

        private void chkBxOlives_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxOlives.Checked)
            {
                ToppingsPrice += 2;
                Toppings += "Olives, ";
            }
            else
            {
                ToppingsPrice -= 2;
                
            }
            UpdateTotalPrice();
        }

        private void chkBxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxGreenPeppers.Checked)
            {
                ToppingsPrice += 2;
                Toppings += "Green Peppers ";
            }
            else
            {
                ToppingsPrice -= 2;
                
            }
            UpdateTotalPrice();
        }

        private void Btn5ResetForm_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            SizePrice = 0;

            rbThinCrust.Checked = false;
            rbThickCrust.Checked = false;
            CrustPrice = 0;


            chkBxExtraChees.Checked = false;
            chkBxMushrooms.Checked = false;
            chkBxTomatoes.Checked = false;
            chkBxOnion.Checked = false;
            chkBxOlives.Checked = false;
            chkBxGreenPeppers.Checked = false;
            ToppingsPrice = 0;


            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;

            TotalPrice = 0;
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEatIn.Checked)
            {
                WhereToEat = "Eat In";
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTakeOut.Checked)
            {
                WhereToEat = "Take Out";
            }
        }

        private void Btn4OrderNow_Click(object sender, EventArgs e)
        {
            if (SizeName == "")
            {
                MessageBox.Show("Please select a size.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (CrustType == "")
            {
                MessageBox.Show("Please select a crust type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (WhereToEat == "")
            {
                MessageBox.Show("Please select where to eat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            The_Bill  BillFrm = new The_Bill();

            BillFrm.SizeName = SizeName;
            BillFrm.CrustType = CrustType;
            BillFrm.Toppings = Toppings;
            BillFrm.WhereToEat = WhereToEat;
            BillFrm.TotalPrice = TotalPrice;

          
            BillFrm.ShowDialog();
            
        }


    }
}
