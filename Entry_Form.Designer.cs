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
            richTextBox1 = new RichTextBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Location = new Point(0, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 205);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(17, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(114, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(114, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // button_LogIn
            // 
            button_LogIn.Anchor = AnchorStyles.None;
            button_LogIn.Location = new Point(81, 123);
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
            panel2.Size = new Size(283, 131);
            panel2.TabIndex = 1;
            // 
            // comboBox_Login
            // 
            comboBox_Login.Anchor = AnchorStyles.None;
            comboBox_Login.FormattingEnabled = true;
            comboBox_Login.Items.AddRange(new object[] { "Attendee", "Employee", "Presenter", "Vendor", "Host" });
            comboBox_Login.Location = new Point(49, 64);
            comboBox_Login.Name = "comboBox_Login";
            comboBox_Login.Size = new Size(182, 33);
            comboBox_Login.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(97, 31);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 0;
            label3.Text = "Log In As";
            // 
            // button_Register
            // 
            button_Register.Anchor = AnchorStyles.None;
            button_Register.Location = new Point(69, 240);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(130, 60);
            button_Register.TabIndex = 5;
            button_Register.Text = "Register New User";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button_Register);
            panel3.Controls.Add(richTextBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 336);
            panel3.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Location = new Point(8, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(252, 133);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "New Users, click here to register a new account.\nOtherwise, use the right side to log in to an existing account.";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(270, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 336);
            panel4.TabIndex = 3;
            // 
            // Entry_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 336);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "Entry_Form";
            Text = "Entry Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
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
    }
}