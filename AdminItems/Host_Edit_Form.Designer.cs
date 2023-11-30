namespace Event_Manager
{
    partial class Host_Edit_Form
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
            textBoxHI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxDiscriminator = new TextBox();
            textBoxEmail = new TextBox();
            textBoxWebsite = new TextBox();
            locationBindingSource = new BindingSource(components);
            label6 = new Label();
            textBoxName = new TextBox();
            label10 = new Label();
            textBoxPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxHI
            // 
            textBoxHI.Location = new Point(12, 109);
            textBoxHI.Name = "textBoxHI";
            textBoxHI.ReadOnly = true;
            textBoxHI.Size = new Size(125, 27);
            textBoxHI.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 61);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 54;
            label4.Text = "Discriminator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 61);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 53;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 61);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 52;
            label2.Text = "Website";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 51;
            label1.Text = "Host ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(500, 360);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 50;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click_1;
            // 
            // textBoxDiscriminator
            // 
            textBoxDiscriminator.Location = new Point(405, 108);
            textBoxDiscriminator.Name = "textBoxDiscriminator";
            textBoxDiscriminator.ReadOnly = true;
            textBoxDiscriminator.Size = new Size(125, 27);
            textBoxDiscriminator.TabIndex = 49;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(274, 108);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 48;
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(143, 109);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(125, 27);
            textBoxWebsite.TabIndex = 47;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 61);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 64;
            label6.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(536, 109);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(663, 61);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 67;
            label10.Text = "Phone Number";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(663, 109);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 66;
            // 
            // Host_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBoxName);
            Controls.Add(label10);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxHI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxDiscriminator);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxWebsite);
            Name = "Host_Edit_Form";
            Text = "Host_Edit_Form";
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxDiscriminator;
        private TextBox textBoxEmail;
        private TextBox textBoxWebsite;
        private BindingSource locationBindingSource;
        private Label label6;
        private TextBox textBoxName;
        private Label label10;
        private TextBox textBoxPhone;
    }
}