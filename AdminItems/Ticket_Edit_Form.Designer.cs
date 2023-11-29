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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxEI = new TextBox();
            textBoxAI = new TextBox();
            textBoxCost = new TextBox();
            locationBindingSource = new BindingSource(components);
            label5 = new Label();
            textBoxType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxTI
            // 
            textBoxTI.Location = new Point(10, 110);
            textBoxTI.Name = "textBoxTI";
            textBoxTI.ReadOnly = true;
            textBoxTI.Size = new Size(125, 27);
            textBoxTI.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 62);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 42;
            label4.Text = "Event ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 62);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 41;
            label3.Text = "Attendee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 40;
            label2.Text = "Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 39;
            label1.Text = "Ticket ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(434, 360);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 38;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click_1;
            // 
            // textBoxEI
            // 
            textBoxEI.Location = new Point(403, 109);
            textBoxEI.Name = "textBoxEI";
            textBoxEI.ReadOnly = true;
            textBoxEI.Size = new Size(125, 27);
            textBoxEI.TabIndex = 37;
            // 
            // textBoxAI
            // 
            textBoxAI.Location = new Point(272, 109);
            textBoxAI.Name = "textBoxAI";
            textBoxAI.ReadOnly = true;
            textBoxAI.Size = new Size(125, 27);
            textBoxAI.TabIndex = 36;
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(141, 110);
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
            label5.Location = new Point(545, 62);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 46;
            label5.Text = "Ticket Type";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(534, 110);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(125, 27);
            textBoxType.TabIndex = 44;
            // 
            // Ticket_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxTI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxEI);
            Controls.Add(textBoxAI);
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxEI;
        private TextBox textBoxAI;
        private TextBox textBoxCost;
        private BindingSource locationBindingSource;
        private Label label5;
        private TextBox textBoxType;
    }
}