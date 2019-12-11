using System;

namespace LightSwitch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int count= 0;
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 135);
            this.label1.Name = "Label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LightSwitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.count += 1;
            if (this.count % 2 == 0) { this.button1.Text = "off"; }
            else { this.button1.Text = "on"; }
            this.label1.Text = Convert.ToString(this.count, 2);
        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

