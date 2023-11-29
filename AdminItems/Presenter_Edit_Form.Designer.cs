namespace Event_Manager
{
    partial class Presenter_Edit_Form
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
            textBoxPI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxPF = new TextBox();
            locationBindingSource = new BindingSource(components);
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxPI
            // 
            textBoxPI.Location = new Point(65, 110);
            textBoxPI.Name = "textBoxPI";
            textBoxPI.ReadOnly = true;
            textBoxPI.Size = new Size(125, 27);
            textBoxPI.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 62);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 75;
            label4.Text = "Presenter Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 74;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 73;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 72;
            label1.Text = "Presenter ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(489, 360);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 71;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // textBoxPF
            // 
            textBoxPF.Location = new Point(458, 109);
            textBoxPF.Name = "textBoxPF";
            textBoxPF.Size = new Size(125, 27);
            textBoxPF.TabIndex = 70;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(327, 109);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 69;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(196, 110);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 68;
            // 
            // Presenter_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxPF);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "Presenter_Edit_Form";
            Text = "Presenter_Edit_Form";
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxPF;
        private BindingSource locationBindingSource;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
    }
}