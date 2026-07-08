using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int startX = 550;
            int startY = 80;
            int cellSize = 150;

            // الخطوط العمودية
            g.DrawLine(Pen, startX + cellSize, startY, startX + cellSize, startY + cellSize * 3);
            g.DrawLine(Pen, startX + cellSize * 2, startY, startX + cellSize * 2, startY + cellSize * 3);

            // الخطوط الأفقية
            g.DrawLine(Pen, startX, startY + cellSize, startX + cellSize * 3, startY + cellSize);
            g.DrawLine(Pen, startX, startY + cellSize * 2, startX + cellSize * 3, startY + cellSize * 2);

            Pen.Dispose();



        }



        public void CheckWinner()
        {
            object WinnerTag = null;

            if ((pb1.Tag == pb2.Tag) && (pb2.Tag == pb3.Tag) && pb1.Tag != null)
                WinnerTag = pb1.Tag;
            else if ((pb4.Tag == pb5.Tag) && (pb5.Tag == pb6.Tag) && pb4.Tag != null)
                WinnerTag = pb4.Tag;
            else if ((pb7.Tag == pb8.Tag) && (pb8.Tag == pb9.Tag) && pb7.Tag != null)
                WinnerTag = pb7.Tag;
            else if ((pb1.Tag == pb4.Tag) && (pb4.Tag == pb7.Tag) && pb1.Tag != null)
                WinnerTag = pb1.Tag;
            else if ((pb2.Tag == pb5.Tag) && (pb5.Tag == pb8.Tag) && pb2.Tag != null)
                WinnerTag = pb2.Tag;
            else if ((pb3.Tag == pb6.Tag) && (pb6.Tag == pb9.Tag) && pb3.Tag != null)
                WinnerTag = pb3.Tag;
            else if ((pb1.Tag == pb5.Tag) && (pb5.Tag == pb9.Tag) && pb1.Tag != null)
                WinnerTag = pb5.Tag;
            else if ((pb3.Tag == pb5.Tag) && (pb5.Tag == pb7.Tag) && pb3.Tag != null)
                WinnerTag = pb3.Tag;

            if (WinnerTag != null)
            {
                if (WinnerTag.ToString() == "X")
                {
                    lblWinner.Text = "Player1";
                    MessageBox.Show("Player1 Wins !","Game Over",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BlockPbxs();
                }

                else
                {
                    lblWinner.Text = "Player2";
                    MessageBox.Show("Player2 Wins !","Game Over",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BlockPbxs();

                }
            }   
            else if (pb1.Tag != null && pb2.Tag != null && pb3.Tag != null && pb4.Tag != null && pb5.Tag != null
                    && pb6.Tag != null && pb7.Tag != null && pb8.Tag != null && pb9.Tag != null)
            {
                    MessageBox.Show("Draw !","Game Over",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblWinner.Text = "Draw";
                    BlockPbxs();
            }
            
            

         
        }


        public void BlockPbxs()
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;
        }

        public void UnBlockPbxs()
        {
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = "Player1";
            lblWinner.Text = "No one";

            pb1.Image = Resources.question_mark_96; pb1.Tag = null;
            pb2.Image = Resources.question_mark_96; pb2.Tag = null;
            pb3.Image = Resources.question_mark_96; pb3.Tag = null;
            pb4.Image = Resources.question_mark_96; pb4.Tag = null;
            pb5.Image = Resources.question_mark_96; pb5.Tag = null;
            pb6.Image = Resources.question_mark_96; pb6.Tag = null;
            pb7.Image = Resources.question_mark_96; pb7.Tag = null;
            pb8.Image = Resources.question_mark_96; pb8.Tag = null;
            pb9.Image = Resources.question_mark_96; pb9.Tag = null;
            UnBlockPbxs();
        }

        private void pb1_Click(object sender, EventArgs e)
        {


            if (pb1.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb1.Image = Resources.X;
                pb1.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            { 
                pb1.Image = Resources.O;
                pb1.Tag = "O";
                lblPlayer.Text = "Player1";
            }

            CheckWinner();

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (pb2.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb2.Image = Resources.X;
                pb2.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            { 
                pb2.Image = Resources.O;
                pb2.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();

        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (pb3.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb3.Image = Resources.X;
                pb3.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb3.Image = Resources.O;
                pb3.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();

        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (pb4.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb4.Image = Resources.X;
                pb4.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb4.Image = Resources.O;
                pb4.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (pb5.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb5.Image = Resources.X;
                pb5.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb5.Image = Resources.O;
                pb5.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (pb6.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb6.Image = Resources.X;
                pb6.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb6.Image = Resources.O;
                pb6.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (pb7.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb7.Image = Resources.X;
                pb7.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb7.Image = Resources.O;
                pb7.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (pb8.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb8.Image = Resources.X;
                pb8.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb8.Image = Resources.O;
                pb8.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (pb9.Tag != null) return;

            if (lblPlayer.Text == "Player1")
            {
                pb9.Image = Resources.X;
                pb9.Tag = "X";
                lblPlayer.Text = "Player2";
            }
            else
            {
                pb9.Image = Resources.O;
                pb9.Tag = "O";
                lblPlayer.Text = "Player1";
            }
            CheckWinner();
        }

        
    }
    
}
