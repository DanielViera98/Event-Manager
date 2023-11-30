namespace Event_Manager
{
    partial class Ticket_Edit_Form
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
            textBoxTI = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxCost = new TextBox();
            locationBindingSource = new BindingSource(components);
            label5 = new Label();
            textBoxType = new TextBox();
            dateTimePickerCheckin = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxTI
            // 
            textBoxTI.Location = new Point(209, 110);
            textBoxTI.Name = "textBoxTI";
            textBoxTI.ReadOnly = true;
            textBoxTI.Size = new Size(125, 27);
            textBoxTI.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 40;
            label2.Text = "Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 62);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 39;
            label1.Text = "Ticket ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(371, 357);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 38;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click_1;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(340, 110);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(125, 27);
            textBoxCost.TabIndex = 35;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 62);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 46;
            label5.Text = "Ticket Type";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(471, 110);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(125, 27);
            textBoxType.TabIndex = 44;
            // 
            // dateTimePickerCheckin
            // 
            dateTimePickerCheckin.Location = new Point(308, 235);
            dateTimePickerCheckin.Name = "dateTimePickerCheckin";
            dateTimePickerCheckin.Size = new Size(250, 27);
            dateTimePickerCheckin.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 192);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 48;
            label6.Text = "Check in Time";
            // 
            // Ticket_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(dateTimePickerCheckin);
            Controls.Add(textBoxTI);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxCost);
            Controls.Add(label5);
            Controls.Add(textBoxType);
            Name = "Ticket_Edit_Form";
            Text = "Ticket_Edit_Form";
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTI;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxCost;
        private BindingSource locationBindingSource;
        private Label label5;
        private TextBox textBoxType;
        private DateTimePicker dateTimePickerCheckin;
        private Label label6;
    }
}