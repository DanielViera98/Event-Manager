namespace Event_Manager.VendorItems
{
    partial class VendorLanding
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
            dataGridView_Vendors = new DataGridView();
            eventBindingSource = new BindingSource(components);
            panel1 = new Panel();
            button_register = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Vendors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Vendors
            // 
            dataGridView_Vendors.AllowUserToAddRows = false;
            dataGridView_Vendors.AllowUserToDeleteRows = false;
            dataGridView_Vendors.AllowUserToResizeColumns = false;
            dataGridView_Vendors.AllowUserToResizeRows = false;
            dataGridView_Vendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Vendors.Dock = DockStyle.Top;
            dataGridView_Vendors.Location = new Point(0, 0);
            dataGridView_Vendors.Margin = new Padding(2);
            dataGridView_Vendors.Name = "dataGridView_Vendors";
            dataGridView_Vendors.ReadOnly = true;
            dataGridView_Vendors.RowHeadersWidth = 62;
            dataGridView_Vendors.RowTemplate.Height = 33;
            dataGridView_Vendors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Vendors.Size = new Size(800, 318);
            dataGridView_Vendors.TabIndex = 0;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Event);
            // 
            // panel1
            // 
            panel1.Controls.Add(button_register);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 318);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 132);
            panel1.TabIndex = 1;
            // 
            // button_register
            // 
            button_register.Location = new Point(345, 31);
            button_register.Margin = new Padding(2);
            button_register.Name = "button_register";
            button_register.Size = new Size(110, 70);
            button_register.TabIndex = 1;
            button_register.Text = "Register For Event";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // VendorLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Vendors);
            Margin = new Padding(2);
            Name = "VendorLanding";
            Text = "VendorLanding";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Vendors).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Vendors;
        private Panel panel1;
        private Button button_addPresenter;
        private Button button_register;
        private BindingSource eventBindingSource;
    }
}