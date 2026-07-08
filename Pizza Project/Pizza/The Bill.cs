using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class The_Bill : Form
    {
        public string SizeName;
        public string CrustType;
        public string Toppings;
        public string WhereToEat;
        public float TotalPrice;





        public The_Bill()
        {
            InitializeComponent();
        }

        public void ShowBill(object sender, EventArgs e)
        {
        }

        private void The_Bill_Load(object sender, EventArgs e)
        {
            lblSizeName.Text = SizeName;
            lblCrustType.Text = CrustType;
            lblToppings.Text = Toppings;
            lblWhereToEat.Text = WhereToEat;
            lblTotalPrice.Text = TotalPrice.ToString() + "$";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order has been confirmed !","Order Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }
        
    }
}
