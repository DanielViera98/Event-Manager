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
            label7 = new Label();
            comboBox_Employer = new ComboBox();
            label8 = new Label();
            locationBindingSource = new BindingSource(components);
            hostBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Pay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hostBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(110, 11);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 22;
            label1.Text = "Register New Employee";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(153, 414);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(112, 34);
            button_Register.TabIndex = 21;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(141, 127);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 20;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(205, 124);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(150, 31);
            textBox_Email.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(63, 90);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 18;
            label3.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(205, 87);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(150, 31);
            textBox_PhoneNum.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(136, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(205, 50);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(150, 31);
            textBox_Name.TabIndex = 15;
            // 
            // numericUpDown_Pay
            // 
            numericUpDown_Pay.Anchor = AnchorStyles.Top;
            numericUpDown_Pay.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown_Pay.Location = new Point(205, 161);
            numericUpDown_Pay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_Pay.Name = "numericUpDown_Pay";
            numericUpDown_Pay.Size = new Size(150, 31);
            numericUpDown_Pay.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(141, 163);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 24;
            label5.Text = "Pay:";
            // 
            // richTextBox_ShiftInfo
            // 
            richTextBox_ShiftInfo.Anchor = AnchorStyles.Top;
            richTextBox_ShiftInfo.Location = new Point(70, 223);
            richTextBox_ShiftInfo.Name = "richTextBox_ShiftInfo";
            richTextBox_ShiftInfo.Size = new Size(279, 107);
            richTextBox_ShiftInfo.TabIndex = 25;
            richTextBox_ShiftInfo.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(136, 195);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 26;
            label6.Text = "Shift Information";
            // 
            // comboBox_Location
            // 
            comboBox_Location.Anchor = AnchorStyles.Top;
            comboBox_Location.DataSource = locationBindingSource;
            comboBox_Location.DisplayMember = "Name";
            comboBox_Location.FormattingEnabled = true;
            comboBox_Location.Location = new Point(202, 336);
            comboBox_Location.Name = "comboBox_Location";
            comboBox_Location.Size = new Size(182, 33);
            comboBox_Location.TabIndex = 27;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(34, 339);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 28;
            label7.Text = "Location Employer:";
            // 
            // comboBox_Employer
            // 
            comboBox_Employer.Anchor = AnchorStyles.Top;
            comboBox_Employer.DataSource = hostBindingSource;
            comboBox_Employer.DisplayMember = "Name";
            comboBox_Employer.FormattingEnabled = true;
            comboBox_Employer.Location = new Point(202, 375);
            comboBox_Employer.Name = "comboBox_Employer";
            comboBox_Employer.Size = new Size(182, 33);
            comboBox_Employer.TabIndex = 29;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(62, 378);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 30;
            label8.Text = "Host Employer:";
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // hostBindingSource
            // 
            hostBindingSource.DataSource = typeof(Host);
            // 
            // RegisterEmployee_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 458);
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
    }
}