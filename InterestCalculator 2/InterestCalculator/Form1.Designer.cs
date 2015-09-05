namespace InterestCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Principle = new System.Windows.Forms.Label();
            this.Interest = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_cncl = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(102, 145);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(29, 19);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 4;
            this.Time.Text = "Time";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(29, 55);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(30, 13);
            this.Rate.TabIndex = 5;
            this.Rate.Text = "Rate";
            // 
            // Principle
            // 
            this.Principle.AutoSize = true;
            this.Principle.Location = new System.Drawing.Point(29, 97);
            this.Principle.Name = "Principle";
            this.Principle.Size = new System.Drawing.Size(47, 13);
            this.Principle.TabIndex = 6;
            this.Principle.Text = "Principle";
            // 
            // Interest
            // 
            this.Interest.AutoSize = true;
            this.Interest.Location = new System.Drawing.Point(6, 198);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(76, 13);
            this.Interest.TabIndex = 7;
            this.Interest.Text = "Simple Interest";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // btn_cncl
            // 
            this.btn_cncl.Location = new System.Drawing.Point(197, 145);
            this.btn_cncl.Name = "btn_cncl";
            this.btn_cncl.Size = new System.Drawing.Size(75, 23);
            this.btn_cncl.TabIndex = 9;
            this.btn_cncl.Text = "Cancel";
            this.btn_cncl.UseVisualStyleBackColor = true;
            this.btn_cncl.Click += new System.EventHandler(this.btn_cncl_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 228);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_cncl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.Principle);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Simple Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Principle;
        private System.Windows.Forms.Label Interest;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_cncl;
        private System.Windows.Forms.Button btn_close;
    }
}

