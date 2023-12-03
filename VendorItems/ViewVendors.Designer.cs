namespace Event_Manager.VendorItems
{
    partial class ViewVendors
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
            panel2 = new Panel();
            button_refresh = new Button();
            checkBox_ViewUserVendor = new CheckBox();
            button_DeleteVendor = new Button();
            button_close = new Button();
            panel1 = new Panel();
            dataGridView_Vendors = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Vendors).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(button_refresh);
            panel2.Controls.Add(checkBox_ViewUserVendor);
            panel2.Controls.Add(button_DeleteVendor);
            panel2.Controls.Add(button_close);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 3;
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.None;
            button_refresh.Location = new Point(477, 18);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(110, 70);
            button_refresh.TabIndex = 5;
            button_refresh.Text = "Refresh View";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // checkBox_ViewUserVendor
            // 
            checkBox_ViewUserVendor.AutoSize = true;
            checkBox_ViewUserVendor.Location = new Point(12, 3);
            checkBox_ViewUserVendor.Name = "checkBox_ViewUserVendor";
            checkBox_ViewUserVendor.Size = new Size(132, 54);
            checkBox_ViewUserVendor.TabIndex = 4;
            checkBox_ViewUserVendor.Text = "View User's \r\nSpaces";
            checkBox_ViewUserVendor.UseVisualStyleBackColor = true;
            checkBox_ViewUserVendor.CheckedChanged += checkBox_ViewUserVendor_CheckedChanged;
            // 
            // button_DeleteVendor
            // 
            button_DeleteVendor.Anchor = AnchorStyles.None;
            button_DeleteVendor.Location = new Point(213, 18);
            button_DeleteVendor.Name = "button_DeleteVendor";
            button_DeleteVendor.Size = new Size(126, 70);
            button_DeleteVendor.TabIndex = 1;
            button_DeleteVendor.Text = "Delete Vendor";
            button_DeleteVendor.UseVisualStyleBackColor = true;
            button_DeleteVendor.Click += button_DeleteVendor_Click;
            // 
            // button_close
            // 
            button_close.Anchor = AnchorStyles.None;
            button_close.Location = new Point(353, 18);
            button_close.Name = "button_close";
            button_close.Size = new Size(110, 70);
            button_close.TabIndex = 0;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Vendors);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 350);
            panel1.TabIndex = 4;
            // 
            // dataGridView_Vendors
            // 
            dataGridView_Vendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Vendors.Dock = DockStyle.Fill;
            dataGridView_Vendors.Location = new Point(0, 0);
            dataGridView_Vendors.Name = "dataGridView_Vendors";
            dataGridView_Vendors.RowHeadersWidth = 62;
            dataGridView_Vendors.RowTemplate.Height = 33;
            dataGridView_Vendors.Size = new Size(800, 350);
            dataGridView_Vendors.TabIndex = 0;
            // 
            // ViewVendors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ViewVendors";
            Text = "ViewVendors";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Vendors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button_refresh;
        private CheckBox checkBox_ViewUserVendor;
        private Button button_DeleteVendor;
        private Button button_close;
        private Panel panel1;
        private DataGridView dataGridView_Vendors;
    }
}