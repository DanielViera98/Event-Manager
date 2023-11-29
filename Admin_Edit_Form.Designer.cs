namespace Event_Manager
{
    partial class Admin_Edit_Form
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
            textBoxAddress = new TextBox();
            textBoxName = new TextBox();
            textBoxWebsite = new TextBox();
            textBoxEmail = new TextBox();
            numericRF = new NumericUpDown();
            numericVC = new NumericUpDown();
            numericAC = new NumericUpDown();
            Submit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericRF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAC).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(40, 181);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(171, 181);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(302, 180);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(125, 27);
            textBoxWebsite.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(433, 180);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // numericRF
            // 
            numericRF.Location = new Point(601, 181);
            numericRF.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericRF.Name = "numericRF";
            numericRF.Size = new Size(60, 27);
            numericRF.TabIndex = 4;
            // 
            // numericVC
            // 
            numericVC.Location = new Point(730, 180);
            numericVC.Name = "numericVC";
            numericVC.Size = new Size(60, 27);
            numericVC.TabIndex = 5;
            // 
            // numericAC
            // 
            numericAC.Location = new Point(871, 180);
            numericAC.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericAC.Name = "numericAC";
            numericAC.Size = new Size(60, 27);
            numericAC.TabIndex = 6;
            // 
            // Submit
            // 
            Submit.Location = new Point(464, 431);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 7;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 133);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 8;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 133);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 10;
            label3.Text = "Website";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 133);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 133);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 12;
            label5.Text = "Rental Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(711, 133);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 13;
            label6.Text = "Vendor Capacity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(834, 133);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 14;
            label7.Text = "Attendee Capacity";
            // 
            // Admin_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 602);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(numericAC);
            Controls.Add(numericVC);
            Controls.Add(numericRF);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxWebsite);
            Controls.Add(textBoxName);
            Controls.Add(textBoxAddress);
            Name = "Admin_Edit_Form";
            Text = "Admin_Edit_Form";
            Load += Admin_Edit_Form_Load;
            ((System.ComponentModel.ISupportInitialize)numericRF).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxAddress;
        private TextBox textBoxName;
        private TextBox textBoxWebsite;
        private TextBox textBoxEmail;
        private NumericUpDown numericRF;
        private NumericUpDown numericVC;
        private NumericUpDown numericAC;
        private Button Submit;
    }
}