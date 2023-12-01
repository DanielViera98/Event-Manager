namespace Event_Manager.Registration___Login
{
    partial class RegisterPresenter_Form
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
            label1 = new Label();
            button_Register = new Button();
            label4 = new Label();
            textBox_Email = new TextBox();
            label3 = new Label();
            textBox_PhoneNum = new TextBox();
            label2 = new Label();
            textBox_Name = new TextBox();
            numericUpDown_Fee = new NumericUpDown();
            label5 = new Label();
            textBox_Username = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox_Password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(51, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 60);
            label1.TabIndex = 22;
            label1.Text = "Welcome New User!\r\nAfter registration you will be directed to a \r\nform where you can buy tickets.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(127, 322);
            button_Register.Margin = new Padding(2);
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
            label4.Location = new Point(78, 167);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 20;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(130, 165);
            textBox_Email.Margin = new Padding(2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(121, 27);
            textBox_Email.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(16, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 18;
            label3.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(130, 135);
            textBox_PhoneNum.Margin = new Padding(2);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(121, 27);
            textBox_PhoneNum.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(74, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(130, 106);
            textBox_Name.Margin = new Padding(2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 27);
            textBox_Name.TabIndex = 15;
            // 
            // numericUpDown_Fee
            // 
            numericUpDown_Fee.Anchor = AnchorStyles.Top;
            numericUpDown_Fee.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Fee.Location = new Point(130, 292);
            numericUpDown_Fee.Margin = new Padding(2);
            numericUpDown_Fee.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_Fee.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDown_Fee.Name = "numericUpDown_Fee";
            numericUpDown_Fee.Size = new Size(120, 27);
            numericUpDown_Fee.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(90, 294);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 24;
            label5.Text = "Fee:";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Top;
            textBox_Username.Location = new Point(130, 229);
            textBox_Username.Margin = new Padding(2);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(121, 27);
            textBox_Username.TabIndex = 25;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(49, 232);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 26;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(53, 264);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 28;
            label7.Text = "Password:";
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top;
            textBox_Password.Location = new Point(130, 261);
            textBox_Password.Margin = new Padding(2);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(121, 27);
            textBox_Password.TabIndex = 27;
            // 
            // RegisterPresenter_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 359);
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
            Margin = new Padding(2);
            Name = "RegisterPresenter_Form";
            Text = "RegisterPresenter";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fee).EndInit();
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
        private NumericUpDown numericUpDown_Fee;
        private Label label5;
        private TextBox textBox_Username;
        private Label label6;
        private Label label7;
        private TextBox textBox_Password;
    }
}