namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.redTB = new System.Windows.Forms.TextBox();
            this.greenTB = new System.Windows.Forms.TextBox();
            this.blueTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GmaxTB = new System.Windows.Forms.TextBox();
            this.GminTB = new System.Windows.Forms.TextBox();
            this.GavgTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CornersTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(12, 12);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(664, 444);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 1;
            this.PB1.TabStop = false;
            // 
            // redTB
            // 
            this.redTB.Location = new System.Drawing.Point(772, 39);
            this.redTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redTB.Name = "redTB";
            this.redTB.Size = new System.Drawing.Size(68, 20);
            this.redTB.TabIndex = 4;
            // 
            // greenTB
            // 
            this.greenTB.Location = new System.Drawing.Point(773, 73);
            this.greenTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenTB.Name = "greenTB";
            this.greenTB.Size = new System.Drawing.Size(68, 20);
            this.greenTB.TabIndex = 5;
            // 
            // blueTB
            // 
            this.blueTB.Location = new System.Drawing.Point(773, 104);
            this.blueTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blueTB.Name = "blueTB";
            this.blueTB.Size = new System.Drawing.Size(68, 20);
            this.blueTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Red avg.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blue avg.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Green avg.";
            // 
            // GmaxTB
            // 
            this.GmaxTB.Location = new System.Drawing.Point(924, 104);
            this.GmaxTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GmaxTB.Name = "GmaxTB";
            this.GmaxTB.Size = new System.Drawing.Size(68, 20);
            this.GmaxTB.TabIndex = 12;
            // 
            // GminTB
            // 
            this.GminTB.Location = new System.Drawing.Point(924, 73);
            this.GminTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GminTB.Name = "GminTB";
            this.GminTB.Size = new System.Drawing.Size(68, 20);
            this.GminTB.TabIndex = 13;
            // 
            // GavgTB
            // 
            this.GavgTB.Location = new System.Drawing.Point(924, 39);
            this.GavgTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GavgTB.Name = "GavgTB";
            this.GavgTB.Size = new System.Drawing.Size(68, 20);
            this.GavgTB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Grey avg.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grey min.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(866, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grey max.";
            // 
            // CornersTB
            // 
            this.CornersTB.Location = new System.Drawing.Point(888, 156);
            this.CornersTB.Name = "CornersTB";
            this.CornersTB.Size = new System.Drawing.Size(100, 20);
            this.CornersTB.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(828, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Corners";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1019, 530);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CornersTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GavgTB);
            this.Controls.Add(this.GminTB);
            this.Controls.Add(this.GmaxTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blueTB);
            this.Controls.Add(this.greenTB);
            this.Controls.Add(this.redTB);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.TextBox redTB;
        private System.Windows.Forms.TextBox greenTB;
        private System.Windows.Forms.TextBox blueTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GmaxTB;
        private System.Windows.Forms.TextBox GminTB;
        private System.Windows.Forms.TextBox GavgTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CornersTB;
        private System.Windows.Forms.Label label7;
    }
}

