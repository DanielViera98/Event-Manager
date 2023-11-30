namespace Event_Manager.AdminItems
{
    partial class HasSpace_Form_Edit
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
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxVI = new TextBox();
            textBoxTI = new TextBox();
            textBoxRI = new TextBox();
            textBoxEI = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(481, 63);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 45;
            label8.Text = "Event ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 63);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 42;
            label4.Text = "Vendor ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 63);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 40;
            label2.Text = "Table ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 63);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 39;
            label1.Text = "Room ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(276, 337);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 38;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // textBoxVI
            // 
            textBoxVI.Location = new Point(328, 110);
            textBoxVI.Name = "textBoxVI";
            textBoxVI.Size = new Size(125, 27);
            textBoxVI.TabIndex = 37;
            // 
            // textBoxTI
            // 
            textBoxTI.Location = new Point(197, 111);
            textBoxTI.Name = "textBoxTI";
            textBoxTI.Size = new Size(125, 27);
            textBoxTI.TabIndex = 36;
            // 
            // textBoxRI
            // 
            textBoxRI.Location = new Point(66, 111);
            textBoxRI.Name = "textBoxRI";
            textBoxRI.ReadOnly = true;
            textBoxRI.Size = new Size(125, 27);
            textBoxRI.TabIndex = 35;
            // 
            // textBoxEI
            // 
            textBoxEI.Location = new Point(459, 111);
            textBoxEI.Name = "textBoxEI";
            textBoxEI.Size = new Size(125, 27);
            textBoxEI.TabIndex = 46;
            // 
            // HasSpace_Form_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(textBoxEI);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxVI);
            Controls.Add(textBoxTI);
            Controls.Add(textBoxRI);
            Name = "HasSpace_Form_Edit";
            Text = "HasSpace_Form_Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxVI;
        private TextBox textBoxTI;
        private TextBox textBoxRI;
        private TextBox textBoxEI;
    }
}