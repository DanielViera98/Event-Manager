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
            label5 = new Label();
            textBoxON = new TextBox();
            textBoxOP = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxName = new TextBox();
            textBoxRP = new TextBox();
            textBoxRN = new TextBox();
            label10 = new Label();
            textBoxPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxHI
            // 
            textBoxHI.Location = new Point(76, 110);
            textBoxHI.Name = "textBoxHI";
            textBoxHI.ReadOnly = true;
            textBoxHI.Size = new Size(125, 27);
            textBoxHI.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 62);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 54;
            label4.Text = "Discriminator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 53;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 52;
            label2.Text = "Website";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 62);
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
            textBoxDiscriminator.Location = new Point(469, 109);
            textBoxDiscriminator.Name = "textBoxDiscriminator";
            textBoxDiscriminator.Size = new Size(125, 27);
            textBoxDiscriminator.TabIndex = 49;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(338, 109);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 48;
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(207, 110);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(125, 27);
            textBoxWebsite.TabIndex = 47;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(611, 62);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 57;
            label5.Text = "Organization Name";
            // 
            // textBoxON
            // 
            textBoxON.Location = new Point(600, 110);
            textBoxON.Name = "textBoxON";
            textBoxON.Size = new Size(125, 27);
            textBoxON.TabIndex = 56;
            // 
            // textBoxOP
            // 
            textBoxOP.Location = new Point(63, 236);
            textBoxOP.Name = "textBoxOP";
            textBoxOP.Size = new Size(125, 27);
            textBoxOP.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 188);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 64;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 188);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 63;
            label7.Text = "Representative Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 188);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 62;
            label8.Text = "Representative Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 188);
            label9.Name = "label9";
            label9.Size = new Size(140, 20);
            label9.TabIndex = 61;
            label9.Text = "Organization Phone";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(500, 236);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 60;
            // 
            // textBoxRP
            // 
            textBoxRP.Location = new Point(361, 236);
            textBoxRP.Name = "textBoxRP";
            textBoxRP.Size = new Size(125, 27);
            textBoxRP.TabIndex = 59;
            // 
            // textBoxRN
            // 
            textBoxRN.Location = new Point(207, 236);
            textBoxRN.Name = "textBoxRN";
            textBoxRN.Size = new Size(125, 27);
            textBoxRN.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(650, 188);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 67;
            label10.Text = "Phone Number";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(650, 236);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 66;
            // 
            // Host_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOP);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxName);
            Controls.Add(textBoxRP);
            Controls.Add(textBoxRN);
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
            Controls.Add(label5);
            Controls.Add(textBoxON);
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
        private Label label5;
        private TextBox textBoxON;
        private TextBox textBoxOP;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxName;
        private TextBox textBoxRP;
        private TextBox textBoxRN;
        private Label label10;
        private TextBox textBoxPhone;
    }
}