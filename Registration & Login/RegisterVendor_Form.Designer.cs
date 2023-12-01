﻿namespace Event_Manager.Registration___Login
{
    partial class RegisterVendor_Form
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
            label5 = new Label();
            numericUpDown_Fee = new NumericUpDown();
            label1 = new Label();
            button_Register = new Button();
            label4 = new Label();
            textBox_Email = new TextBox();
            label3 = new Label();
            textBox_PhoneNum = new TextBox();
            label2 = new Label();
            textBox_Name = new TextBox();
            label6 = new Label();
            textBox_Username = new TextBox();
            label7 = new Label();
            textBox_Password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fee).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(102, 200);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 34;
            label5.Text = "Fee:";
            // 
            // numericUpDown_Fee
            // 
            numericUpDown_Fee.Anchor = AnchorStyles.Top;
            numericUpDown_Fee.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Fee.Location = new Point(142, 198);
            numericUpDown_Fee.Margin = new Padding(2, 2, 2, 2);
            numericUpDown_Fee.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_Fee.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDown_Fee.Name = "numericUpDown_Fee";
            numericUpDown_Fee.Size = new Size(120, 27);
            numericUpDown_Fee.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(101, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 32;
            label1.Text = "Welcome New Vendor!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(139, 228);
            button_Register.Margin = new Padding(2, 2, 2, 2);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(90, 27);
            button_Register.TabIndex = 31;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(90, 100);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 30;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(142, 98);
            textBox_Email.Margin = new Padding(2, 2, 2, 2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(121, 27);
            textBox_Email.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(28, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 28;
            label3.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(142, 68);
            textBox_PhoneNum.Margin = new Padding(2, 2, 2, 2);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(121, 27);
            textBox_PhoneNum.TabIndex = 27;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(86, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 26;
            label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(142, 38);
            textBox_Name.Margin = new Padding(2, 2, 2, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 27);
            textBox_Name.TabIndex = 25;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(61, 132);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 36;
            label6.Text = "Username:";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Top;
            textBox_Username.Location = new Point(142, 129);
            textBox_Username.Margin = new Padding(2);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(121, 27);
            textBox_Username.TabIndex = 35;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(66, 163);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 38;
            label7.Text = "Password:";
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top;
            textBox_Password.Location = new Point(142, 160);
            textBox_Password.Margin = new Padding(2);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(121, 27);
            textBox_Password.TabIndex = 37;
            // 
            // RegisterVendor_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 266);
            Controls.Add(label7);
            Controls.Add(textBox_Password);
            Controls.Add(label6);
            Controls.Add(textBox_Username);
            Controls.Add(label5);
            Controls.Add(numericUpDown_Fee);
            Controls.Add(label1);
            Controls.Add(button_Register);
            Controls.Add(label4);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Controls.Add(textBox_PhoneNum);
            Controls.Add(label2);
            Controls.Add(textBox_Name);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegisterVendor_Form";
            Text = "Register Vendor";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private NumericUpDown numericUpDown_Fee;
        private Label label1;
        private Button button_Register;
        private Label label4;
        private TextBox textBox_Email;
        private Label label3;
        private TextBox textBox_PhoneNum;
        private Label label2;
        private TextBox textBox_Name;
        private Label label6;
        private TextBox textBox_Username;
        private Label label7;
        private TextBox textBox_Password;
    }
}