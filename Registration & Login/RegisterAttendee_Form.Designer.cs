namespace Event_Manager.Registration___Login
{
    partial class RegisterAttendee_Form
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
            button_Register = new Button();
            label4 = new Label();
            textBox_Email = new TextBox();
            label3 = new Label();
            textBox_PhoneNum = new TextBox();
            label2 = new Label();
            textBox_Name = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox_Password = new TextBox();
            label6 = new Label();
            textBox_Username = new TextBox();
            SuspendLayout();
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(179, 239);
            button_Register.Margin = new Padding(2);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(90, 27);
            button_Register.TabIndex = 13;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(115, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 12;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(166, 136);
            textBox_Email.Margin = new Padding(2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(121, 27);
            textBox_Email.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(53, 109);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 10;
            label3.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(166, 106);
            textBox_PhoneNum.Margin = new Padding(2);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(121, 27);
            textBox_PhoneNum.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(111, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(166, 77);
            textBox_Name.Margin = new Padding(2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 27);
            textBox_Name.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 60);
            label1.TabIndex = 14;
            label1.Text = "Welcome New User!\r\nAfter registration you will be directed to a \r\nform where you can buy tickets.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 171);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 16;
            label5.Text = "Username:";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(166, 197);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(121, 27);
            textBox_Password.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 200);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 18;
            label6.Text = "Password:";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(166, 168);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(121, 27);
            textBox_Username.TabIndex = 19;
            // 
            // RegisterAttendee_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 286);
            Controls.Add(textBox_Username);
            Controls.Add(label6);
            Controls.Add(textBox_Password);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button_Register);
            Controls.Add(label4);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Controls.Add(textBox_PhoneNum);
            Controls.Add(label2);
            Controls.Add(textBox_Name);
            Margin = new Padding(2);
            Name = "RegisterAttendee_Form";
            Text = "Attendee Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Register;
        private Label label4;
        private TextBox textBox_Email;
        private Label label3;
        private TextBox textBox_PhoneNum;
        private Label label2;
        private TextBox textBox_Name;
        private Label label1;
        private Label label5;
        private TextBox textBox_Password;
        private Label label6;
        private TextBox textBox_Username;
    }
}