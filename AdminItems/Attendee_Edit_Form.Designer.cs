namespace Event_Manager
{
    partial class Attendee_Edit_Form
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
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxAI = new TextBox();
            label3 = new Label();
            textBoxPhone = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 74);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 73);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 23;
            label1.Text = "Attendee ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(308, 349);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 22;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click_1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(361, 121);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 18;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(230, 121);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 16;
            // 
            // textBoxAI
            // 
            textBoxAI.Location = new Point(99, 121);
            textBoxAI.Name = "textBoxAI";
            textBoxAI.ReadOnly = true;
            textBoxAI.Size = new Size(125, 27);
            textBoxAI.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 73);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 28;
            label3.Text = "Phone Number";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(492, 121);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 27;
            // 
            // Attendee_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(label3);
            Controls.Add(textBoxPhone);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxAI);
            Name = "Attendee_Edit_Form";
            Text = "Attendee_Edit_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxAI;
        private Label label3;
        private TextBox textBoxPhone;
    }
}