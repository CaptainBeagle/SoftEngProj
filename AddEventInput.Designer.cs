namespace SoftEngProj
{
    partial class AddEventInput
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
            this.Starthour = new System.Windows.Forms.ComboBox();
            this.EndHour = new System.Windows.Forms.ComboBox();
            this.AmPm1 = new System.Windows.Forms.ComboBox();
            this.AmPm2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RepeatEvent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reminder = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter event name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Enter event Location";
            // 
            // Starthour
            // 
            this.Starthour.FormattingEnabled = true;
            this.Starthour.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00"});
            this.Starthour.Location = new System.Drawing.Point(161, 176);
            this.Starthour.Name = "Starthour";
            this.Starthour.Size = new System.Drawing.Size(121, 33);
            this.Starthour.TabIndex = 2;
            // 
            // EndHour
            // 
            this.EndHour.FormattingEnabled = true;
            this.EndHour.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00"});
            this.EndHour.Location = new System.Drawing.Point(589, 176);
            this.EndHour.Name = "EndHour";
            this.EndHour.Size = new System.Drawing.Size(121, 33);
            this.EndHour.TabIndex = 3;
            // 
            // AmPm1
            // 
            this.AmPm1.FormattingEnabled = true;
            this.AmPm1.Items.AddRange(new object[] {
            "Am",
            "Pm"});
            this.AmPm1.Location = new System.Drawing.Point(299, 176);
            this.AmPm1.Name = "AmPm1";
            this.AmPm1.Size = new System.Drawing.Size(60, 33);
            this.AmPm1.TabIndex = 4;
            // 
            // AmPm2
            // 
            this.AmPm2.FormattingEnabled = true;
            this.AmPm2.Items.AddRange(new object[] {
            "Am",
            "Pm"});
            this.AmPm2.Location = new System.Drawing.Point(728, 176);
            this.AmPm2.Name = "AmPm2";
            this.AmPm2.Size = new System.Drawing.Size(60, 33);
            this.AmPm2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Time";
            // 
            // RepeatEvent
            // 
            this.RepeatEvent.FormattingEnabled = true;
            this.RepeatEvent.Items.AddRange(new object[] {
            "Never",
            "Weekdays",
            "Weekends",
            "Every day",
            "Once a week"});
            this.RepeatEvent.Location = new System.Drawing.Point(211, 250);
            this.RepeatEvent.Name = "RepeatEvent";
            this.RepeatEvent.Size = new System.Drawing.Size(148, 33);
            this.RepeatEvent.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Event Repetition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reminders";
            // 
            // Reminder
            // 
            this.Reminder.FormattingEnabled = true;
            this.Reminder.Items.AddRange(new object[] {
            "Never",
            "Every Day",
            "A week in advance",
            "A day in advance"});
            this.Reminder.Location = new System.Drawing.Point(589, 250);
            this.Reminder.Name = "Reminder";
            this.Reminder.Size = new System.Drawing.Size(199, 33);
            this.Reminder.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Work",
            "School",
            "Social",
            "Recreation"});
            this.Category.Location = new System.Drawing.Point(589, 43);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 33);
            this.Category.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category";
            // 
            // AddEventInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reminder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RepeatEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmPm2);
            this.Controls.Add(this.AmPm1);
            this.Controls.Add(this.EndHour);
            this.Controls.Add(this.Starthour);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddEventInput";
            this.Text = "AddEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEventInput_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox Starthour;
        private System.Windows.Forms.ComboBox EndHour;
        private System.Windows.Forms.ComboBox AmPm1;
        private System.Windows.Forms.ComboBox AmPm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RepeatEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Reminder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label label5;
    }
}