namespace Event_Manager
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            radioButton_Admin = new RadioButton();
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
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button_LogIn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 191);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(16, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(96, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(96, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 1;
            // 
            // button_LogIn
            // 
            button_LogIn.Anchor = AnchorStyles.None;
            button_LogIn.Location = new Point(63, 112);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(130, 40);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 151);
            panel2.TabIndex = 1;
            // 
            // comboBox_Login
            // 
            comboBox_Login.Anchor = AnchorStyles.None;
            comboBox_Login.FormattingEnabled = true;
            comboBox_Login.Items.AddRange(new object[] { "Attendee", "Employee", "Presenter", "Vendor", "Host" });
            comboBox_Login.Location = new Point(40, 78);
            comboBox_Login.Name = "comboBox_Login";
            comboBox_Login.Size = new Size(182, 28);
            comboBox_Login.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(88, 45);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Log In As";
            // 
            // button_Register
            // 
            button_Register.Location = new Point(11, 62);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(97, 60);
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
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 342);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 150);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 190);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_Register);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(148, 0);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(118, 190);
            panel8.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(radioButton_Admin);
            panel5.Controls.Add(radioButton_Host);
            panel5.Controls.Add(radioButton_Vendor);
            panel5.Controls.Add(radioButton_Presenter);
            panel5.Controls.Add(radioButton_Employee);
            panel5.Controls.Add(radioButton_Attendee);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.MinimumSize = new Size(148, 173);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 190);
            panel5.TabIndex = 6;
            // 
            // radioButton_Host
            // 
            radioButton_Host.AutoSize = true;
            radioButton_Host.Location = new Point(10, 142);
            radioButton_Host.Margin = new Padding(2, 2, 2, 2);
            radioButton_Host.Name = "radioButton_Host";
            radioButton_Host.Size = new Size(61, 24);
            radioButton_Host.TabIndex = 4;
            radioButton_Host.TabStop = true;
            radioButton_Host.Text = "Host";
            radioButton_Host.UseVisualStyleBackColor = true;
            // 
            // radioButton_Vendor
            // 
            radioButton_Vendor.AutoSize = true;
            radioButton_Vendor.Location = new Point(10, 114);
            radioButton_Vendor.Margin = new Padding(2, 2, 2, 2);
            radioButton_Vendor.Name = "radioButton_Vendor";
            radioButton_Vendor.Size = new Size(77, 24);
            radioButton_Vendor.TabIndex = 3;
            radioButton_Vendor.TabStop = true;
            radioButton_Vendor.Text = "Vendor";
            radioButton_Vendor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Presenter
            // 
            radioButton_Presenter.AutoSize = true;
            radioButton_Presenter.Location = new Point(10, 86);
            radioButton_Presenter.Margin = new Padding(2, 2, 2, 2);
            radioButton_Presenter.Name = "radioButton_Presenter";
            radioButton_Presenter.Size = new Size(91, 24);
            radioButton_Presenter.TabIndex = 2;
            radioButton_Presenter.TabStop = true;
            radioButton_Presenter.Text = "Presenter";
            radioButton_Presenter.UseVisualStyleBackColor = true;
            // 
            // radioButton_Employee
            // 
            radioButton_Employee.AutoSize = true;
            radioButton_Employee.Location = new Point(10, 58);
            radioButton_Employee.Margin = new Padding(2, 2, 2, 2);
            radioButton_Employee.Name = "radioButton_Employee";
            radioButton_Employee.Size = new Size(96, 24);
            radioButton_Employee.TabIndex = 1;
            radioButton_Employee.TabStop = true;
            radioButton_Employee.Text = "Employee";
            radioButton_Employee.UseVisualStyleBackColor = true;
            // 
            // radioButton_Attendee
            // 
            radioButton_Attendee.AutoSize = true;
            radioButton_Attendee.Location = new Point(10, 30);
            radioButton_Attendee.Margin = new Padding(2, 2, 2, 2);
            radioButton_Attendee.Name = "radioButton_Attendee";
            radioButton_Attendee.Size = new Size(91, 24);
            radioButton_Attendee.TabIndex = 0;
            radioButton_Attendee.TabStop = true;
            radioButton_Attendee.Text = "Attendee";
            radioButton_Attendee.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 0;
            label4.Text = "Select Account Type";
            // 
            // panel6
            // 
            panel6.Controls.Add(richTextBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(266, 150);
            panel6.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(266, 150);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "New Users, click here to register a new account.\nOtherwise, use the right side to log in to an existing account.";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(268, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 342);
            panel4.TabIndex = 3;
            // 
            // radioButton_Admin
            // 
            radioButton_Admin.AutoSize = true;
            radioButton_Admin.Location = new Point(10, 166);
            radioButton_Admin.Margin = new Padding(2);
            radioButton_Admin.Name = "radioButton_Admin";
            radioButton_Admin.Size = new Size(74, 24);
            radioButton_Admin.TabIndex = 5;
            radioButton_Admin.TabStop = true;
            radioButton_Admin.Text = "Admin";
            radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // Entry_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 342);
            Controls.Add(panel4);
            Controls.Add(panel3);
            MinimumSize = new Size(548, 389);
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
        private TextBox textBox2;
        private TextBox textBox1;
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
        private RadioButton radioButton_Admin;
    }
}