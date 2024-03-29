﻿namespace Event_Manager
{
    partial class Entry_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBox_Password = new TextBox();
            textBox_Username = new TextBox();
            button_LogIn = new Button();
            panel2 = new Panel();
            comboBox_Login = new ComboBox();
            label3 = new Label();
            button_Register = new Button();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel5 = new Panel();
            radioButton_Host = new RadioButton();
            radioButton_Vendor = new RadioButton();
            radioButton_Presenter = new RadioButton();
            radioButton_Employee = new RadioButton();
            radioButton_Attendee = new RadioButton();
            label4 = new Label();
            panel6 = new Panel();
            richTextBox1 = new RichTextBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(textBox_Username);
            panel1.Controls.Add(button_LogIn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 188);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 240);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(26, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(21, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.None;
            textBox_Password.Location = new Point(121, 95);
            textBox_Password.Margin = new Padding(4, 4, 4, 4);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(186, 31);
            textBox_Password.TabIndex = 2;
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.None;
            textBox_Username.Location = new Point(121, 47);
            textBox_Username.Margin = new Padding(4, 4, 4, 4);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(186, 31);
            textBox_Username.TabIndex = 1;
            // 
            // button_LogIn
            // 
            button_LogIn.Anchor = AnchorStyles.None;
            button_LogIn.Location = new Point(80, 141);
            button_LogIn.Margin = new Padding(4, 4, 4, 4);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(162, 50);
            button_LogIn.TabIndex = 0;
            button_LogIn.Text = "Log In";
            button_LogIn.UseVisualStyleBackColor = true;
            button_LogIn.Click += button_LogIn_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBox_Login);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 188);
            panel2.TabIndex = 1;
            // 
            // comboBox_Login
            // 
            comboBox_Login.Anchor = AnchorStyles.None;
            comboBox_Login.FormattingEnabled = true;
            comboBox_Login.Items.AddRange(new object[] { "Attendee", "Presenter", "Vendor", "Host", "Admin" });
            comboBox_Login.Location = new Point(51, 98);
            comboBox_Login.Margin = new Padding(4, 4, 4, 4);
            comboBox_Login.Name = "comboBox_Login";
            comboBox_Login.Size = new Size(226, 33);
            comboBox_Login.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(111, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 0;
            label3.Text = "Log In As";
            // 
            // button_Register
            // 
            button_Register.Location = new Point(14, 78);
            button_Register.Margin = new Padding(4, 4, 4, 4);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(121, 75);
            button_Register.TabIndex = 5;
            button_Register.Text = "Register New User";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 428);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 188);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(332, 238);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Register);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(184, 0);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(148, 238);
            panel8.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(radioButton_Host);
            panel5.Controls.Add(radioButton_Vendor);
            panel5.Controls.Add(radioButton_Presenter);
            panel5.Controls.Add(radioButton_Employee);
            panel5.Controls.Add(radioButton_Attendee);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2);
            panel5.MinimumSize = new Size(184, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(184, 238);
            panel5.TabIndex = 6;
            // 
            // radioButton_Host
            // 
            radioButton_Host.AutoSize = true;
            radioButton_Host.Location = new Point(12, 178);
            radioButton_Host.Margin = new Padding(2);
            radioButton_Host.Name = "radioButton_Host";
            radioButton_Host.Size = new Size(75, 29);
            radioButton_Host.TabIndex = 4;
            radioButton_Host.TabStop = true;
            radioButton_Host.Text = "Host";
            radioButton_Host.UseVisualStyleBackColor = true;
            // 
            // radioButton_Vendor
            // 
            radioButton_Vendor.AutoSize = true;
            radioButton_Vendor.Location = new Point(12, 142);
            radioButton_Vendor.Margin = new Padding(2);
            radioButton_Vendor.Name = "radioButton_Vendor";
            radioButton_Vendor.Size = new Size(94, 29);
            radioButton_Vendor.TabIndex = 3;
            radioButton_Vendor.TabStop = true;
            radioButton_Vendor.Text = "Vendor";
            radioButton_Vendor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Presenter
            // 
            radioButton_Presenter.AutoSize = true;
            radioButton_Presenter.Location = new Point(12, 108);
            radioButton_Presenter.Margin = new Padding(2);
            radioButton_Presenter.Name = "radioButton_Presenter";
            radioButton_Presenter.Size = new Size(110, 29);
            radioButton_Presenter.TabIndex = 2;
            radioButton_Presenter.TabStop = true;
            radioButton_Presenter.Text = "Presenter";
            radioButton_Presenter.UseVisualStyleBackColor = true;
            // 
            // radioButton_Employee
            // 
            radioButton_Employee.AutoSize = true;
            radioButton_Employee.Location = new Point(12, 72);
            radioButton_Employee.Margin = new Padding(2);
            radioButton_Employee.Name = "radioButton_Employee";
            radioButton_Employee.Size = new Size(115, 29);
            radioButton_Employee.TabIndex = 1;
            radioButton_Employee.TabStop = true;
            radioButton_Employee.Text = "Employee";
            radioButton_Employee.UseVisualStyleBackColor = true;
            // 
            // radioButton_Attendee
            // 
            radioButton_Attendee.AutoSize = true;
            radioButton_Attendee.Location = new Point(12, 38);
            radioButton_Attendee.Margin = new Padding(2);
            radioButton_Attendee.Name = "radioButton_Attendee";
            radioButton_Attendee.Size = new Size(109, 29);
            radioButton_Attendee.TabIndex = 0;
            radioButton_Attendee.TabStop = true;
            radioButton_Attendee.Text = "Attendee";
            radioButton_Attendee.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 0;
            label4.Text = "Select Account Type";
            // 
            // panel6
            // 
            panel6.Controls.Add(richTextBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 188);
            panel6.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(4, 4, 4, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(332, 188);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "New Users, click here to register a new account.\nOtherwise, use the right side to log in to an existing account.";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(334, 0);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 428);
            panel4.TabIndex = 3;
            // 
            // Entry_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 428);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(680, 472);
            Name = "Entry_Form";
            Text = "Entry Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_Password;
        private TextBox textBox_Username;
        private Button button_LogIn;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button button_Register;
        private ComboBox comboBox_Login;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private RichTextBox richTextBox1;
        private Panel panel6;
        private Panel panel5;
        private RadioButton radioButton_Host;
        private RadioButton radioButton_Vendor;
        private RadioButton radioButton_Presenter;
        private RadioButton radioButton_Employee;
        private RadioButton radioButton_Attendee;
        private Label label4;
        private Panel panel7;
        private Panel panel8;
    }
}