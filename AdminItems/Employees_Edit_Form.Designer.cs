namespace Event_Manager
{
    partial class Employees_Edit_Form
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
            textBoxEI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Submit = new Button();
            textBoxShift = new TextBox();
            textBoxPay = new TextBox();
            textBoxName = new TextBox();
            locationBindingSource = new BindingSource(components);
            textBoxHI = new TextBox();
            textBoxLocation = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxEI
            // 
            textBoxEI.Location = new Point(21, 113);
            textBoxEI.Name = "textBoxEI";
            textBoxEI.ReadOnly = true;
            textBoxEI.Size = new Size(125, 27);
            textBoxEI.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 65);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 26;
            label4.Text = "Shift Schedule";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 65);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 25;
            label3.Text = "Pay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 65);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 65);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 23;
            label1.Text = "Employee ID";
            // 
            // Submit
            // 
            Submit.Location = new Point(445, 363);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 22;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // textBoxShift
            // 
            textBoxShift.Location = new Point(414, 112);
            textBoxShift.Name = "textBoxShift";
            textBoxShift.Size = new Size(125, 27);
            textBoxShift.TabIndex = 18;
            // 
            // textBoxPay
            // 
            textBoxPay.Location = new Point(283, 112);
            textBoxPay.Name = "textBoxPay";
            textBoxPay.Size = new Size(125, 27);
            textBoxPay.TabIndex = 17;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(152, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 16;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // textBoxHI
            // 
            textBoxHI.Location = new Point(676, 113);
            textBoxHI.Name = "textBoxHI";
            textBoxHI.Size = new Size(125, 27);
            textBoxHI.TabIndex = 32;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(545, 113);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(125, 27);
            textBoxLocation.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(556, 65);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 33;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(685, 65);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 34;
            label6.Text = "Host ID";
            // 
            // Employees_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxHI);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxEI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Controls.Add(textBoxShift);
            Controls.Add(textBoxPay);
            Controls.Add(textBoxName);
            Name = "Employees_Edit_Form";
            Text = "Employees_Edit_Form";
            Load += Employees_Edit_Form_Load;
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Submit;
        private TextBox textBoxShift;
        private TextBox textBoxPay;
        private TextBox textBoxName;
        private BindingSource locationBindingSource;
        private TextBox textBoxHI;
        private TextBox textBoxLocation;
        private Label label5;
        private Label label6;
    }
}