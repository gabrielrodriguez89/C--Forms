/*********************
 
@Auth: Gabriel Rodriguez
Class: CIS162AD
Section: #13552
Date:12/29/2017
Application: Employee Pay Calculator
Assignment: At-Home Final  

**********************/
namespace EmployeePayCalculator
{
    partial class PayCalculator
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.HourlyRate = new System.Windows.Forms.TextBox();
            this.HoursWorked = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next2 = new System.Windows.Forms.Button();
            this.TotalGrossPay = new System.Windows.Forms.Label();
            this.TotalStateTax = new System.Windows.Forms.Label();
            this.TotalMedicare = new System.Windows.Forms.Label();
            this.TotalNetPay = new System.Windows.Forms.Label();
            this.TotalFedTax = new System.Windows.Forms.Label();
            this.TotalSS = new System.Windows.Forms.Label();
            this.TotalSSOut = new System.Windows.Forms.Label();
            this.TotalFedOut = new System.Windows.Forms.Label();
            this.TotalNetOut = new System.Windows.Forms.Label();
            this.TotalMedicareOut = new System.Windows.Forms.Label();
            this.TotalStateOut = new System.Windows.Forms.Label();
            this.TotalGrossOut = new System.Windows.Forms.Label();
            this.Fin = new System.Windows.Forms.Button();
            this.name2 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.totallabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.BiWeekly = new System.Windows.Forms.CheckBox();
            this.Bi_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(14, 52);
            this.FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(163, 22);
            this.FirstName.TabIndex = 0;
            // 
            // HourlyRate
            // 
            this.HourlyRate.Location = new System.Drawing.Point(352, 52);
            this.HourlyRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HourlyRate.Name = "HourlyRate";
            this.HourlyRate.Size = new System.Drawing.Size(80, 22);
            this.HourlyRate.TabIndex = 2;
            // 
            // HoursWorked
            // 
            this.HoursWorked.AcceptsReturn = true;
            this.HoursWorked.Location = new System.Drawing.Point(438, 52);
            this.HoursWorked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(80, 22);
            this.HoursWorked.TabIndex = 3;
            // 
            // EmpName
            // 
            this.EmpName.AutoSize = true;
            this.EmpName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpName.Location = new System.Drawing.Point(204, 9);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(148, 16);
            this.EmpName.TabIndex = 3;
            this.EmpName.Text = "Employee Information";
            this.EmpName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rate.Location = new System.Drawing.Point(349, 32);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(65, 16);
            this.Rate.TabIndex = 4;
            this.Rate.Text = "Pay Rate";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hours.Location = new System.Drawing.Point(435, 32);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(97, 16);
            this.Hours.TabIndex = 5;
            this.Hours.Text = "Hours Worked";
            // 
            // Next
            // 
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Next.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Location = new System.Drawing.Point(304, 80);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(87, 28);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(183, 52);
            this.LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(163, 22);
            this.LastName.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Location = new System.Drawing.Point(137, 80);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(87, 28);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Calculate
            // 
            this.Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calculate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Calculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calculate.Location = new System.Drawing.Point(431, 121);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(87, 28);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Visible = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // prev
            // 
            this.prev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prev.Location = new System.Drawing.Point(128, 441);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(102, 29);
            this.prev.TabIndex = 23;
            this.prev.Text = "Prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Visible = false;
            this.prev.Click += new System.EventHandler(this.Prev_Next_Finish_Click);
            // 
            // next2
            // 
            this.next2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next2.Location = new System.Drawing.Point(290, 441);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(94, 29);
            this.next2.TabIndex = 24;
            this.next2.Text = "Next";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Visible = false;
            this.next2.Click += new System.EventHandler(this.Prev_Next_Finish_Click);
            // 
            // TotalGrossPay
            // 
            this.TotalGrossPay.AutoSize = true;
            this.TotalGrossPay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGrossPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalGrossPay.Location = new System.Drawing.Point(11, 85);
            this.TotalGrossPay.Name = "TotalGrossPay";
            this.TotalGrossPay.Size = new System.Drawing.Size(0, 16);
            this.TotalGrossPay.TabIndex = 26;
            // 
            // TotalStateTax
            // 
            this.TotalStateTax.AutoSize = true;
            this.TotalStateTax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStateTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalStateTax.Location = new System.Drawing.Point(369, 86);
            this.TotalStateTax.Name = "TotalStateTax";
            this.TotalStateTax.Size = new System.Drawing.Size(0, 16);
            this.TotalStateTax.TabIndex = 27;
            // 
            // TotalMedicare
            // 
            this.TotalMedicare.AutoSize = true;
            this.TotalMedicare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMedicare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalMedicare.Location = new System.Drawing.Point(275, 86);
            this.TotalMedicare.Name = "TotalMedicare";
            this.TotalMedicare.Size = new System.Drawing.Size(0, 16);
            this.TotalMedicare.TabIndex = 28;
            // 
            // TotalNetPay
            // 
            this.TotalNetPay.AutoSize = true;
            this.TotalNetPay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNetPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalNetPay.Location = new System.Drawing.Point(90, 86);
            this.TotalNetPay.Name = "TotalNetPay";
            this.TotalNetPay.Size = new System.Drawing.Size(0, 16);
            this.TotalNetPay.TabIndex = 29;
            // 
            // TotalFedTax
            // 
            this.TotalFedTax.AutoSize = true;
            this.TotalFedTax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFedTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalFedTax.Location = new System.Drawing.Point(458, 86);
            this.TotalFedTax.Name = "TotalFedTax";
            this.TotalFedTax.Size = new System.Drawing.Size(0, 16);
            this.TotalFedTax.TabIndex = 30;
            // 
            // TotalSS
            // 
            this.TotalSS.AutoSize = true;
            this.TotalSS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalSS.Location = new System.Drawing.Point(180, 86);
            this.TotalSS.Name = "TotalSS";
            this.TotalSS.Size = new System.Drawing.Size(0, 16);
            this.TotalSS.TabIndex = 31;
            // 
            // TotalSSOut
            // 
            this.TotalSSOut.AutoSize = true;
            this.TotalSSOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSSOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalSSOut.Location = new System.Drawing.Point(180, 118);
            this.TotalSSOut.Name = "TotalSSOut";
            this.TotalSSOut.Size = new System.Drawing.Size(0, 16);
            this.TotalSSOut.TabIndex = 37;
            // 
            // TotalFedOut
            // 
            this.TotalFedOut.AutoSize = true;
            this.TotalFedOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFedOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalFedOut.Location = new System.Drawing.Point(458, 118);
            this.TotalFedOut.Name = "TotalFedOut";
            this.TotalFedOut.Size = new System.Drawing.Size(0, 16);
            this.TotalFedOut.TabIndex = 36;
            // 
            // TotalNetOut
            // 
            this.TotalNetOut.AutoSize = true;
            this.TotalNetOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNetOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalNetOut.Location = new System.Drawing.Point(90, 118);
            this.TotalNetOut.Name = "TotalNetOut";
            this.TotalNetOut.Size = new System.Drawing.Size(0, 16);
            this.TotalNetOut.TabIndex = 35;
            // 
            // TotalMedicareOut
            // 
            this.TotalMedicareOut.AutoSize = true;
            this.TotalMedicareOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMedicareOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalMedicareOut.Location = new System.Drawing.Point(275, 118);
            this.TotalMedicareOut.Name = "TotalMedicareOut";
            this.TotalMedicareOut.Size = new System.Drawing.Size(0, 16);
            this.TotalMedicareOut.TabIndex = 34;
            // 
            // TotalStateOut
            // 
            this.TotalStateOut.AutoSize = true;
            this.TotalStateOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStateOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalStateOut.Location = new System.Drawing.Point(369, 118);
            this.TotalStateOut.Name = "TotalStateOut";
            this.TotalStateOut.Size = new System.Drawing.Size(0, 16);
            this.TotalStateOut.TabIndex = 33;
            // 
            // TotalGrossOut
            // 
            this.TotalGrossOut.AutoSize = true;
            this.TotalGrossOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGrossOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalGrossOut.Location = new System.Drawing.Point(11, 117);
            this.TotalGrossOut.Name = "TotalGrossOut";
            this.TotalGrossOut.Size = new System.Drawing.Size(0, 16);
            this.TotalGrossOut.TabIndex = 32;
            // 
            // Fin
            // 
            this.Fin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.Fin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Fin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fin.Location = new System.Drawing.Point(407, 475);
            this.Fin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(111, 28);
            this.Fin.TabIndex = 39;
            this.Fin.Text = "Return";
            this.Fin.UseVisualStyleBackColor = true;
            this.Fin.Visible = false;
            this.Fin.Click += new System.EventHandler(this.Prev_Next_Finish_Click);
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name2.Location = new System.Drawing.Point(180, 32);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(75, 16);
            this.name2.TabIndex = 40;
            this.name2.Text = "Last Name";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name1.Location = new System.Drawing.Point(14, 32);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(76, 16);
            this.name1.TabIndex = 41;
            this.name1.Text = "First Name";
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputBox.Location = new System.Drawing.Point(17, 154);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(501, 281);
            this.OutputBox.TabIndex = 42;
            this.OutputBox.Text = "";
            this.OutputBox.Visible = false;
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totallabel.Location = new System.Drawing.Point(194, 45);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(0, 16);
            this.totallabel.TabIndex = 43;
            this.totallabel.Visible = false;
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Clear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(17, 121);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 28);
            this.Clear.TabIndex = 44;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Visible = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BiWeekly
            // 
            this.BiWeekly.AutoSize = true;
            this.BiWeekly.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiWeekly.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BiWeekly.Location = new System.Drawing.Point(334, 126);
            this.BiWeekly.Name = "BiWeekly";
            this.BiWeekly.Size = new System.Drawing.Size(91, 20);
            this.BiWeekly.TabIndex = 45;
            this.BiWeekly.Text = "Bi-Weekly";
            this.BiWeekly.UseVisualStyleBackColor = true;
            // 
            // Bi_label
            // 
            this.Bi_label.AutoSize = true;
            this.Bi_label.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bi_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bi_label.Location = new System.Drawing.Point(151, 129);
            this.Bi_label.Name = "Bi_label";
            this.Bi_label.Size = new System.Drawing.Size(177, 14);
            this.Bi_label.TabIndex = 46;
            this.Bi_label.Text = "Please Check Box if paid Bi-Weekly";
            // 
            // PayCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 506);
            this.Controls.Add(this.Bi_label);
            this.Controls.Add(this.BiWeekly);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.TotalSSOut);
            this.Controls.Add(this.TotalFedOut);
            this.Controls.Add(this.TotalNetOut);
            this.Controls.Add(this.TotalMedicareOut);
            this.Controls.Add(this.TotalStateOut);
            this.Controls.Add(this.TotalGrossOut);
            this.Controls.Add(this.TotalSS);
            this.Controls.Add(this.TotalFedTax);
            this.Controls.Add(this.TotalNetPay);
            this.Controls.Add(this.TotalMedicare);
            this.Controls.Add(this.TotalStateTax);
            this.Controls.Add(this.TotalGrossPay);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.HourlyRate);
            this.Controls.Add(this.FirstName);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(558, 214);
            this.Name = "PayCalculator";
            this.Text = "Pay Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PayCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox HourlyRate;
        private System.Windows.Forms.TextBox HoursWorked;
        private System.Windows.Forms.Label EmpName;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.Label TotalGrossPay;
        private System.Windows.Forms.Label TotalStateTax;
        private System.Windows.Forms.Label TotalMedicare;
        private System.Windows.Forms.Label TotalNetPay;
        private System.Windows.Forms.Label TotalFedTax;
        private System.Windows.Forms.Label TotalSS;
        private System.Windows.Forms.Label TotalSSOut;
        private System.Windows.Forms.Label TotalFedOut;
        private System.Windows.Forms.Label TotalNetOut;
        private System.Windows.Forms.Label TotalMedicareOut;
        private System.Windows.Forms.Label TotalStateOut;
        private System.Windows.Forms.Label TotalGrossOut;
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox BiWeekly;
        private System.Windows.Forms.Label Bi_label;
    }
}

