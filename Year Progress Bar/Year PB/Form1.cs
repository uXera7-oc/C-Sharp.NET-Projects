using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Now;
            DateTime StartOfYear = new DateTime(DateTime.Now.Year, 1, 1);

            TimeSpan Difference = CurrentDate - StartOfYear;


            double PercentageOfTheYear = (Difference.TotalDays / 365) * 100;
            


           progressBar1.Value =(int)PercentageOfTheYear;
           label1.Text = PercentageOfTheYear.ToString("F2") + "%";

           double LeftYear = 100 - PercentageOfTheYear;

          
           MessageBox.Show("Past Year : " + PercentageOfTheYear.ToString("F2") + "%" + Environment.NewLine + "Left Year : " + LeftYear.ToString("F2") + "%"
               , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            btn1Calculate.Enabled = true;
            label1.Text = 0 + "%";

        }
    }
}
