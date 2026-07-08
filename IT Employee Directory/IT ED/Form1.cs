using ListView_Practise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Practise
{
    public partial class frmED : Form
    {
        public frmED()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) ||
              string.IsNullOrEmpty(txtPosition.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
              return;

            ListViewItem Item = new ListViewItem(txtID.Text.Trim());

            Item.SubItems.Add(txtName.Text.Trim());
            Item.SubItems.Add("IT");
            Item.SubItems.Add(txtPosition.Text.Trim());
            Item.SubItems.Add(txtPhoneNumber.Text.Trim());
            if (rbMale.Checked)
                Item.ImageIndex = 0;
            else
                Item.ImageIndex = 1;


            listView1.Items.Add(Item);

            txtID.Text = "";
            txtName.Text = "";
            txtPosition.Text = "";
            txtPhoneNumber.Text = "";

            txtID.Focus();


        }

        short _Counter = 0;
        private void btnFillRandom_Click(object sender, EventArgs e)
        {

            string[] Names = { "Anis", "EmployeeX", "EmployeeY",
                              "EmployeeZ","Octavio","User","Forty Seven","Random Employee","Not a Employee","Hello World" };

         
            string[] Positions = { "Software Developer", "HR Manager", "Sales Agent",
                             "SOC Analyst", "Network Admin" ,"Pentester","Software Engineer" };


            Random rnd = new Random();



            for (short i = 1; i <= 10; i++)
            {
                _Counter++;
                ListViewItem Item = new ListViewItem(_Counter.ToString());

                if (_Counter % 2 == 0)
                    Item.ImageIndex = 1;//Male
                else
                    Item.ImageIndex = 0;//Female

                Item.SubItems.Add(Names[i - 1]);
                Item.SubItems.Add("IT");
                Item.SubItems.Add(Positions[rnd.Next(0,Positions.Length)]);
                Item.SubItems.Add("+213" + rnd.Next(500000000, 799999999).ToString());

                listView1.Items.Add(Item);
            }


        }


        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
            
                //Image
                if(listView1.SelectedItems[0].ImageIndex == 1)
                {
                    pbEmployeeImage.Image = Resources.Female;
                }
                else
                {
                    pbEmployeeImage.Image = Resources.Male;
                }
                //Name
                lblNamegb.Text = listView1.SelectedItems[0].SubItems[1].Text;

                //ID
                lblIDgb.Text = listView1.SelectedItems[0].Text;

                //Position
                lblPositiongb.Text = listView1.SelectedItems[0].SubItems[3].Text;

                //PhoneNumber
                lblPhoneNumbergb.Text = listView1.SelectedItems[0].SubItems[4].Text;



            }
            else
            {
                pbEmployeeImage.Image = Resources.images;
                lblNamegb.Text = "";
                lblPositiongb.Text = "";
                lblPhoneNumbergb.Text = "";

            }

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {

            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }



    }
}
