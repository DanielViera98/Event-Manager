namespace Event_Manager.Registration___Login
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Fee).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(128, 161);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 34;
            label5.Text = "Fee:";
            // 
            // numericUpDown_Fee
            // 
            numericUpDown_Fee.Anchor = AnchorStyles.Top;
            numericUpDown_Fee.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Fee.Location = new Point(177, 159);
            numericUpDown_Fee.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_Fee.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDown_Fee.Name = "numericUpDown_Fee";
            numericUpDown_Fee.Size = new Size(150, 31);
            numericUpDown_Fee.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(126, 20);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 32;
            label1.Text = "Welcome New Vendor!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.Top;
            button_Register.Location = new Point(174, 196);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(112, 34);
            button_Register.TabIndex = 31;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(113, 125);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 30;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top;
            textBox_Email.Location = new Point(177, 122);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(150, 31);
            textBox_Email.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(35, 88);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 28;
            label3.Text = "Phone Number:";
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Anchor = AnchorStyles.Top;
            textBox_PhoneNum.Location = new Point(177, 85);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(150, 31);
            textBox_PhoneNum.TabIndex = 27;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(108, 51);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 26;
            label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(177, 48);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(150, 31);
            textBox_Name.TabIndex = 25;
            // 
            // RegisterVendor_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 252);
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
    }
}