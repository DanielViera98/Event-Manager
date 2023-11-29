namespace Event_Manager
{
    partial class Vendor_Edit_Form
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
            textBoxVI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxPhone = new TextBox();
            locationBindingSource = new BindingSource(components);
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            label5 = new Label();
            textBoxFee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxVI
            // 
            textBoxVI.Location = new Point(60, 111);
            textBoxVI.Name = "textBoxVI";
            textBoxVI.ReadOnly = true;
            textBoxVI.Size = new Size(125, 27);
            textBoxVI.TabIndex = 85;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(463, 63);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 84;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 63);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 83;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 82;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 81;
            label1.Text = "Vendor ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(484, 361);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 80;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(453, 110);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 79;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(322, 110);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 78;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(191, 111);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(594, 64);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 87;
            label5.Text = "Fee";
            // 
            // textBoxFee
            // 
            textBoxFee.Location = new Point(584, 111);
            textBoxFee.Name = "textBoxFee";
            textBoxFee.Size = new Size(125, 27);
            textBoxFee.TabIndex = 86;
            // 
            // Vendor_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxFee);
            Controls.Add(textBoxVI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "Vendor_Edit_Form";
            Text = "Vendor_Edit_Form";
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxPhone;
        private BindingSource locationBindingSource;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label label5;
        private TextBox textBoxFee;
    }
}