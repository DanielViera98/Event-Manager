namespace Event_Manager
{
    partial class Event_Edit_Form
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            textBoxEID = new TextBox();
            label8 = new Label();
            dateTimePickerSD = new DateTimePicker();
            dateTimePickerED = new DateTimePicker();
            textBoxWebsite = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 70);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 27;
            label5.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 70);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 26;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(756, 70);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 25;
            label3.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 70);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 23;
            label1.Text = "Event ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(444, 368);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 22;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click_1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(282, 117);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(125, 27);
            textBoxDescription.TabIndex = 17;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(151, 118);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 16;
            // 
            // textBoxEID
            // 
            textBoxEID.Location = new Point(20, 118);
            textBoxEID.Name = "textBoxEID";
            textBoxEID.ReadOnly = true;
            textBoxEID.Size = new Size(125, 27);
            textBoxEID.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 70);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 30;
            label8.Text = "Start Date";
            // 
            // dateTimePickerSD
            // 
            dateTimePickerSD.Location = new Point(413, 117);
            dateTimePickerSD.Name = "dateTimePickerSD";
            dateTimePickerSD.Size = new Size(144, 27);
            dateTimePickerSD.TabIndex = 31;
            // 
            // dateTimePickerED
            // 
            dateTimePickerED.Location = new Point(563, 118);
            dateTimePickerED.Name = "dateTimePickerED";
            dateTimePickerED.Size = new Size(144, 27);
            dateTimePickerED.TabIndex = 32;
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(724, 117);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(125, 27);
            textBoxWebsite.TabIndex = 34;
            // 
            // Event_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(textBoxWebsite);
            Controls.Add(dateTimePickerED);
            Controls.Add(dateTimePickerSD);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEID);
            Name = "Event_Edit_Form";
            Text = "Event_Edit_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private TextBox textBoxEID;
        private Label label8;
        private DateTimePicker dateTimePickerSD;
        private DateTimePicker dateTimePickerED;
        private TextBox textBoxWebsite;
    }
}