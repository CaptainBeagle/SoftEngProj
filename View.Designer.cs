﻿using System.Runtime.CompilerServices;
using System.Threading;

namespace SoftEngProj
{
    partial class View
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 224);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1366, 375);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1370, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thursday";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1072, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Friday";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1264, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
    }
}

