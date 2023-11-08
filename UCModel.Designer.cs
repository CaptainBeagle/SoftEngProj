namespace SoftEngProj
{
    partial class UCModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Namelb = new System.Windows.Forms.Label();
            this.Catlb = new System.Windows.Forms.Label();
            this.Locationlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelb.Location = new System.Drawing.Point(56, 102);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(0, 42);
            this.Namelb.TabIndex = 0;
            // 
            // Catlb
            // 
            this.Catlb.AutoSize = true;
            this.Catlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catlb.Location = new System.Drawing.Point(56, 254);
            this.Catlb.Name = "Catlb";
            this.Catlb.Size = new System.Drawing.Size(0, 42);
            this.Catlb.TabIndex = 2;
            // 
            // Locationlb
            // 
            this.Locationlb.AutoSize = true;
            this.Locationlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlb.Location = new System.Drawing.Point(56, 400);
            this.Locationlb.Name = "Locationlb";
            this.Locationlb.Size = new System.Drawing.Size(0, 42);
            this.Locationlb.TabIndex = 3;
            // 
            // UCModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Locationlb);
            this.Controls.Add(this.Catlb);
            this.Controls.Add(this.Namelb);
            this.Name = "UCModel";
            this.Size = new System.Drawing.Size(641, 466);
            this.Load += new System.EventHandler(this.UCModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Label Catlb;
        private System.Windows.Forms.Label Locationlb;
    }
}
