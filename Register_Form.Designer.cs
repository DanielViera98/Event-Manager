namespace Event_Manager
{
    partial class Register_Form
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
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            radioButton_Host = new RadioButton();
            radioButton_Vendor = new RadioButton();
            radioButton_Presenter = new RadioButton();
            radioButton_Employee = new RadioButton();
            radioButton_Attendee = new RadioButton();
            label1 = new Label();
            panel_Attendee = new Panel();
            panel2.SuspendLayout();
            panel_Attendee.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(108, 89);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Location = new Point(172, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(30, 52);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 3;
            label3.Text = "Phone Number:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(172, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(103, 15);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(172, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(radioButton_Host);
            panel2.Controls.Add(radioButton_Vendor);
            panel2.Controls.Add(radioButton_Presenter);
            panel2.Controls.Add(radioButton_Employee);
            panel2.Controls.Add(radioButton_Attendee);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.MinimumSize = new Size(184, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 239);
            panel2.TabIndex = 3;
            // 
            // radioButton_Host
            // 
            radioButton_Host.AutoSize = true;
            radioButton_Host.Location = new Point(12, 177);
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
            radioButton_Presenter.Location = new Point(12, 107);
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
            radioButton_Attendee.Location = new Point(12, 37);
            radioButton_Attendee.Name = "radioButton_Attendee";
            radioButton_Attendee.Size = new Size(109, 29);
            radioButton_Attendee.TabIndex = 0;
            radioButton_Attendee.TabStop = true;
            radioButton_Attendee.Text = "Attendee";
            radioButton_Attendee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Account Type";
            // 
            // panel_Attendee
            // 
            panel_Attendee.BorderStyle = BorderStyle.Fixed3D;
            panel_Attendee.Controls.Add(label4);
            panel_Attendee.Controls.Add(textBox3);
            panel_Attendee.Controls.Add(label3);
            panel_Attendee.Controls.Add(textBox2);
            panel_Attendee.Controls.Add(label2);
            panel_Attendee.Controls.Add(textBox1);
            panel_Attendee.Dock = DockStyle.Right;
            panel_Attendee.Location = new Point(188, 0);
            panel_Attendee.Name = "panel_Attendee";
            panel_Attendee.Size = new Size(356, 239);
            panel_Attendee.TabIndex = 2;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 239);
            Controls.Add(panel2);
            Controls.Add(panel_Attendee);
            MinimumSize = new Size(566, 295);
            Name = "Register_Form";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_Attendee.ResumeLayout(false);
            panel_Attendee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Panel panel2;
        private RadioButton radioButton_Host;
        private RadioButton radioButton_Vendor;
        private RadioButton radioButton_Presenter;
        private RadioButton radioButton_Employee;
        private RadioButton radioButton_Attendee;
        private Label label1;
        private Panel panel_Attendee;
    }
}