﻿namespace MoneyTracker
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
            this.addAmount = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.amountInput_TextChanged);
            // 
            // addAmount
            // 
            this.addAmount.Location = new System.Drawing.Point(65, 140);
            this.addAmount.Name = "addAmount";
            this.addAmount.Size = new System.Drawing.Size(75, 23);
            this.addAmount.TabIndex = 1;
            this.addAmount.Text = "Add Amount";
            this.addAmount.UseVisualStyleBackColor = true;
            this.addAmount.Click += new System.EventHandler(this.addAmount_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(382, 60);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(126, 20);
            this.output.TabIndex = 2;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showTransactions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.addAmount);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addAmount;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
    }
}

