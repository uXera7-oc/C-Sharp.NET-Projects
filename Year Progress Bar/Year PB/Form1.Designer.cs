namespace ProgressBar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1Calculate = new System.Windows.Forms.Button();
            this.Btn2Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(175, 206);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 34);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "0 %";
            // 
            // btn1Calculate
            // 
            this.btn1Calculate.Location = new System.Drawing.Point(204, 303);
            this.btn1Calculate.Name = "btn1Calculate";
            this.btn1Calculate.Size = new System.Drawing.Size(113, 47);
            this.btn1Calculate.TabIndex = 2;
            this.btn1Calculate.Text = "Calculate";
            this.btn1Calculate.UseVisualStyleBackColor = true;
            this.btn1Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn2Reset
            // 
            this.Btn2Reset.Location = new System.Drawing.Point(425, 303);
            this.Btn2Reset.Name = "Btn2Reset";
            this.Btn2Reset.Size = new System.Drawing.Size(113, 47);
            this.Btn2Reset.TabIndex = 3;
            this.Btn2Reset.Text = "Reset";
            this.Btn2Reset.UseVisualStyleBackColor = true;
            this.Btn2Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 436);
            this.Controls.Add(this.Btn2Reset);
            this.Controls.Add(this.btn1Calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Percentage Of The Year";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1Calculate;
        private System.Windows.Forms.Button Btn2Reset;
    }
}

