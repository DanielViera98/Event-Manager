namespace Event_Manager.AdminItems
{
    partial class HostedBy_Edit_Form
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
            textBoxHI = new TextBox();
            textBoxEI = new TextBox();
            textBoxHBI = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 79);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 53;
            label4.Text = "Host ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 52;
            label2.Text = "Event ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 79);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 51;
            label1.Text = "Hosted ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(202, 204);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 50;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // textBoxHI
            // 
            textBoxHI.Location = new Point(321, 127);
            textBoxHI.Name = "textBoxHI";
            textBoxHI.ReadOnly = true;
            textBoxHI.Size = new Size(125, 27);
            textBoxHI.TabIndex = 49;
            // 
            // textBoxEI
            // 
            textBoxEI.Location = new Point(190, 127);
            textBoxEI.Name = "textBoxEI";
            textBoxEI.ReadOnly = true;
            textBoxEI.Size = new Size(125, 27);
            textBoxEI.TabIndex = 48;
            // 
            // textBoxHBI
            // 
            textBoxHBI.Location = new Point(59, 127);
            textBoxHBI.Name = "textBoxHBI";
            textBoxHBI.ReadOnly = true;
            textBoxHBI.Size = new Size(125, 27);
            textBoxHBI.TabIndex = 47;
            // 
            // HostedBy_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxHI);
            Controls.Add(textBoxEI);
            Controls.Add(textBoxHBI);
            Name = "HostedBy_Edit_Form";
            Text = "HostedBy_Edit_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxHI;
        private TextBox textBoxEI;
        private TextBox textBoxHBI;
    }
}