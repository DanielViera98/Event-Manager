namespace Event_Manager.Registration___Login
{
    partial class RegisterHost_Form
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
            label1 = new Label();
            button_Register = new Button();
            label_Email = new Label();
            textBox_Email = new TextBox();
            label_Phone = new Label();
            textBox_PhoneNum = new TextBox();
            label_Name = new Label();
            textBox_Name = new TextBox();
            textBox_Website = new TextBox();
            textBox_RName = new TextBox();
            textBox_RPNum = new TextBox();
            label_RName = new Label();
            labelRPNum = new Label();
            label_OrgInfo = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(244, 180);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 34;
            label5.Text = "Website:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(280, 17);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 32;
            label1.Text = "Welcome New Host!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(341, 329);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(112, 34);
            button_Register.TabIndex = 31;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // label_Email
            // 
            label_Email.Anchor = AnchorStyles.Top;
            label_Email.AutoSize = true;
            label_Email.Location = new Point(199, 143);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(124, 25);
            label_Email.TabIndex = 30;
            label_Email.Text = "Contact Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(329, 140);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(150, 31);
            textBox_Email.TabIndex = 29;
            // 
            // label_Phone
            // 
            label_Phone.Anchor = AnchorStyles.Top;
            label_Phone.AutoSize = true;
            label_Phone.Location = new Point(187, 106);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(136, 25);
            label_Phone.TabIndex = 28;
            label_Phone.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(329, 103);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(150, 31);
            textBox_PhoneNum.TabIndex = 27;
            // 
            // label_Name
            // 
            label_Name.Anchor = AnchorStyles.Top;
            label_Name.AutoSize = true;
            label_Name.Location = new Point(260, 69);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(63, 25);
            label_Name.TabIndex = 26;
            label_Name.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(329, 66);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(150, 31);
            textBox_Name.TabIndex = 25;
            // 
            // textBox_Website
            // 
            textBox_Website.Anchor = AnchorStyles.Top;
            textBox_Website.Location = new Point(329, 177);
            textBox_Website.Name = "textBox_Website";
            textBox_Website.Size = new Size(150, 31);
            textBox_Website.TabIndex = 36;
            // 
            // textBox_RName
            // 
            textBox_RName.Anchor = AnchorStyles.Top;
            textBox_RName.Enabled = false;
            textBox_RName.Location = new Point(329, 255);
            textBox_RName.Name = "textBox_RName";
            textBox_RName.Size = new Size(150, 31);
            textBox_RName.TabIndex = 37;
            // 
            // textBox_RPNum
            // 
            textBox_RPNum.Anchor = AnchorStyles.Top;
            textBox_RPNum.Enabled = false;
            textBox_RPNum.Location = new Point(329, 292);
            textBox_RPNum.Name = "textBox_RPNum";
            textBox_RPNum.Size = new Size(150, 31);
            textBox_RPNum.TabIndex = 38;
            // 
            // label_RName
            // 
            label_RName.Anchor = AnchorStyles.Top;
            label_RName.AutoSize = true;
            label_RName.Enabled = false;
            label_RName.Location = new Point(140, 258);
            label_RName.Name = "label_RName";
            label_RName.Size = new Size(183, 25);
            label_RName.TabIndex = 39;
            label_RName.Text = "Representative Name:";
            // 
            // labelRPNum
            // 
            labelRPNum.Anchor = AnchorStyles.Top;
            labelRPNum.AutoSize = true;
            labelRPNum.Enabled = false;
            labelRPNum.Location = new Point(67, 295);
            labelRPNum.Name = "labelRPNum";
            labelRPNum.Size = new Size(256, 25);
            labelRPNum.TabIndex = 40;
            labelRPNum.Text = "Representative Phone Number:";
            // 
            // label_OrgInfo
            // 
            label_OrgInfo.Anchor = AnchorStyles.Top;
            label_OrgInfo.AutoSize = true;
            label_OrgInfo.Enabled = false;
            label_OrgInfo.Location = new Point(485, 258);
            label_OrgInfo.Name = "label_OrgInfo";
            label_OrgInfo.Size = new Size(186, 50);
            label_OrgInfo.TabIndex = 41;
            label_OrgInfo.Text = "This information is for\r\norganizations only\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(488, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(183, 54);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Check if this is for \r\nan Organization";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegisterHost_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 381);
            Controls.Add(checkBox1);
            Controls.Add(label_OrgInfo);
            Controls.Add(labelRPNum);
            Controls.Add(label_RName);
            Controls.Add(textBox_RPNum);
            Controls.Add(textBox_RName);
            Controls.Add(textBox_Website);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button_Register);
            Controls.Add(label_Email);
            Controls.Add(textBox_Email);
            Controls.Add(label_Phone);
            Controls.Add(textBox_PhoneNum);
            Controls.Add(label_Name);
            Controls.Add(textBox_Name);
            Name = "RegisterHost_Form";
            Text = "RegisterHost_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Button button_Register;
        private Label label_Email;
        private TextBox textBox_Email;
        private Label label_Phone;
        private TextBox textBox_PhoneNum;
        private Label label_Name;
        private TextBox textBox_Name;
        private TextBox textBox_Website;
        private TextBox textBox_RName;
        private TextBox textBox_RPNum;
        private Label label_RName;
        private Label labelRPNum;
        private Label label_OrgInfo;
        private CheckBox checkBox1;
    }
}