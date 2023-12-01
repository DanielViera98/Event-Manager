namespace Event_Manager.Registration___Login
{
    partial class RegisterEmployee_Form
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button_Register = new Button();
            label4 = new Label();
            textBox_Email = new TextBox();
            label3 = new Label();
            textBox_PhoneNum = new TextBox();
            label2 = new Label();
            textBox_Name = new TextBox();
            numericUpDown_Pay = new NumericUpDown();
            label5 = new Label();
            richTextBox_ShiftInfo = new RichTextBox();
            label6 = new Label();
            comboBox_Location = new ComboBox();
            locationBindingSource = new BindingSource(components);
            label7 = new Label();
            comboBox_Employer = new ComboBox();
            hostBindingSource = new BindingSource(components);
            label8 = new Label();
            label9 = new Label();
            textBox_Username = new TextBox();
            label10 = new Label();
            textBox_Password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Pay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hostBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(88, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 22;
            label1.Text = "Register New Employee";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(127, 400);
            button_Register.Margin = new Padding(2, 2, 2, 2);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(90, 27);
            button_Register.TabIndex = 21;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(113, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 20;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(164, 99);
            textBox_Email.Margin = new Padding(2, 2, 2, 2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(121, 27);
            textBox_Email.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(50, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 18;
            label3.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(164, 70);
            textBox_PhoneNum.Margin = new Padding(2, 2, 2, 2);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(121, 27);
            textBox_PhoneNum.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(109, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(164, 40);
            textBox_Name.Margin = new Padding(2, 2, 2, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 27);
            textBox_Name.TabIndex = 15;
            // 
            // numericUpDown_Pay
            // 
            numericUpDown_Pay.Anchor = AnchorStyles.Top;
            numericUpDown_Pay.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown_Pay.Location = new Point(169, 198);
            numericUpDown_Pay.Margin = new Padding(2, 2, 2, 2);
            numericUpDown_Pay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_Pay.Name = "numericUpDown_Pay";
            numericUpDown_Pay.Size = new Size(120, 27);
            numericUpDown_Pay.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(118, 199);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 24;
            label5.Text = "Pay:";
            // 
            // richTextBox_ShiftInfo
            // 
            richTextBox_ShiftInfo.Anchor = AnchorStyles.Top;
            richTextBox_ShiftInfo.Location = new Point(61, 247);
            richTextBox_ShiftInfo.Margin = new Padding(2, 2, 2, 2);
            richTextBox_ShiftInfo.Name = "richTextBox_ShiftInfo";
            richTextBox_ShiftInfo.Size = new Size(224, 86);
            richTextBox_ShiftInfo.TabIndex = 25;
            richTextBox_ShiftInfo.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(114, 225);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 26;
            label6.Text = "Shift Information";
            // 
            // comboBox_Location
            // 
            comboBox_Location.Anchor = AnchorStyles.Top;
            comboBox_Location.DataSource = locationBindingSource;
            comboBox_Location.DisplayMember = "Name";
            comboBox_Location.FormattingEnabled = true;
            comboBox_Location.Location = new Point(167, 338);
            comboBox_Location.Margin = new Padding(2, 2, 2, 2);
            comboBox_Location.Name = "comboBox_Location";
            comboBox_Location.Size = new Size(146, 28);
            comboBox_Location.TabIndex = 27;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(32, 340);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 28;
            label7.Text = "Location Employer:";
            // 
            // comboBox_Employer
            // 
            comboBox_Employer.Anchor = AnchorStyles.Top;
            comboBox_Employer.DataSource = hostBindingSource;
            comboBox_Employer.DisplayMember = "Name";
            comboBox_Employer.FormattingEnabled = true;
            comboBox_Employer.Location = new Point(167, 369);
            comboBox_Employer.Margin = new Padding(2, 2, 2, 2);
            comboBox_Employer.Name = "comboBox_Employer";
            comboBox_Employer.Size = new Size(146, 28);
            comboBox_Employer.TabIndex = 29;
            // 
            // hostBindingSource
            // 
            hostBindingSource.DataSource = typeof(Host);
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(55, 371);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 30;
            label8.Text = "Host Employer:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(83, 133);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 32;
            label9.Text = "Username:";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Top;
            textBox_Username.Location = new Point(164, 130);
            textBox_Username.Margin = new Padding(2);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(121, 27);
            textBox_Username.TabIndex = 31;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(87, 164);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 34;
            label10.Text = "Password:";
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top;
            textBox_Password.Location = new Point(164, 161);
            textBox_Password.Margin = new Padding(2);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(121, 27);
            textBox_Password.TabIndex = 33;
            // 
            // RegisterEmployee_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 433);
            Controls.Add(label10);
            Controls.Add(textBox_Password);
            Controls.Add(label9);
            Controls.Add(textBox_Username);
            Controls.Add(label8);
            Controls.Add(comboBox_Employer);
            Controls.Add(label7);
            Controls.Add(comboBox_Location);
            Controls.Add(label6);
            Controls.Add(richTextBox_ShiftInfo);
            Controls.Add(label5);
            Controls.Add(numericUpDown_Pay);
            Controls.Add(label1);
            Controls.Add(button_Register);
            Controls.Add(label4);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Controls.Add(textBox_PhoneNum);
            Controls.Add(label2);
            Controls.Add(textBox_Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegisterEmployee_Form";
            Text = "Employee Registration";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Pay).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hostBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Register;
        private Label label4;
        private TextBox textBox_Email;
        private Label label3;
        private TextBox textBox_PhoneNum;
        private Label label2;
        private TextBox textBox_Name;
        private NumericUpDown numericUpDown_Pay;
        private Label label5;
        private RichTextBox richTextBox_ShiftInfo;
        private Label label6;
        private ComboBox comboBox_Location;
        private Label label7;
        private ComboBox comboBox_Employer;
        private Label label8;
        private BindingSource locationBindingSource;
        private BindingSource hostBindingSource;
        private Label label9;
        private TextBox textBox_Username;
        private Label label10;
        private TextBox textBox_Password;
    }
}