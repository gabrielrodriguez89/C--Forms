namespace FunWithMath
{
    partial class Math
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
            this.Adding = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOne = new System.Windows.Forms.TextBox();
            this.numTwo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adding
            // 
            this.Adding.BackColor = System.Drawing.SystemColors.Control;
            this.Adding.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adding.ForeColor = System.Drawing.Color.DarkBlue;
            this.Adding.Location = new System.Drawing.Point(198, 110);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(75, 23);
            this.Adding.TabIndex = 2;
            this.Adding.Text = "Add";
            this.Adding.UseVisualStyleBackColor = false;
            this.Adding.Click += new System.EventHandler(this.Adding_MouseClick);
            this.Adding.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Adding_MouseClick);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(198, 151);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 3;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Subtract_MouseClick);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(117, 131);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            this.Divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Divide_MouseClick);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(279, 131);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Multiply_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Second Number";
            // 
            // numOne
            // 
            this.numOne.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOne.HideSelection = false;
            this.numOne.Location = new System.Drawing.Point(117, 40);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(100, 21);
            this.numOne.TabIndex = 0;
            this.numOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.numOne.Leave += new System.EventHandler(this.Num_One_TextChanged);
            // 
            // numTwo
            // 
            this.numTwo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTwo.Location = new System.Drawing.Point(279, 40);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(100, 21);
            this.numTwo.TabIndex = 1;
            this.numTwo.Leave += new System.EventHandler(this.Num_Two_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer:";
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(185, 216);
            this.display.MinimumSize = new System.Drawing.Size(100, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(100, 17);
            this.display.TabIndex = 9;
            // 
            // Math
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 253);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Adding);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Math";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Wiz";
            this.Load += new System.EventHandler(this.Math_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Num_One;
        private System.Windows.Forms.TextBox Num_Two;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numOne;
        private System.Windows.Forms.TextBox numTwo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label display;
    }
}

