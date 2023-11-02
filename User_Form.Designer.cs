namespace Event_Manager
{
    partial class User_Form
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
            vendorData = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendorBindingSource = new BindingSource(components);
            presenterData = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            presenterFeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presenterBindingSource = new BindingSource(components);
            VendorsLabel = new Label();
            PresentersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)vendorData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presenterData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presenterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // vendorData
            // 
            vendorData.AllowUserToAddRows = false;
            vendorData.AllowUserToDeleteRows = false;
            vendorData.AutoGenerateColumns = false;
            vendorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendorData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, feeDataGridViewTextBoxColumn });
            vendorData.DataSource = vendorBindingSource;
            vendorData.Location = new Point(12, 51);
            vendorData.Name = "vendorData";
            vendorData.RowHeadersWidth = 51;
            vendorData.RowTemplate.Height = 29;
            vendorData.Size = new Size(362, 188);
            vendorData.TabIndex = 2;
            vendorData.CellContentClick += vendorData_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // feeDataGridViewTextBoxColumn
            // 
            feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            feeDataGridViewTextBoxColumn.MinimumWidth = 6;
            feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            feeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorBindingSource
            // 
            vendorBindingSource.DataSource = typeof(Vendor);
            // 
            // presenterData
            // 
            presenterData.AllowUserToAddRows = false;
            presenterData.AllowUserToDeleteRows = false;
            presenterData.AutoGenerateColumns = false;
            presenterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            presenterData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, presenterFeeDataGridViewTextBoxColumn });
            presenterData.DataSource = presenterBindingSource;
            presenterData.Location = new Point(428, 51);
            presenterData.Name = "presenterData";
            presenterData.ReadOnly = true;
            presenterData.RowHeadersWidth = 51;
            presenterData.RowTemplate.Height = 29;
            presenterData.Size = new Size(360, 188);
            presenterData.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            emailDataGridViewTextBoxColumn1.ReadOnly = true;
            emailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // presenterFeeDataGridViewTextBoxColumn
            // 
            presenterFeeDataGridViewTextBoxColumn.DataPropertyName = "PresenterFee";
            presenterFeeDataGridViewTextBoxColumn.HeaderText = "Fee";
            presenterFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            presenterFeeDataGridViewTextBoxColumn.Name = "presenterFeeDataGridViewTextBoxColumn";
            presenterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            presenterFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // presenterBindingSource
            // 
            presenterBindingSource.DataSource = typeof(Presenter);
            // 
            // VendorsLabel
            // 
            VendorsLabel.AutoSize = true;
            VendorsLabel.Location = new Point(178, 28);
            VendorsLabel.Name = "VendorsLabel";
            VendorsLabel.Size = new Size(62, 20);
            VendorsLabel.TabIndex = 4;
            VendorsLabel.Text = "Vendors";
            // 
            // PresentersLabel
            // 
            PresentersLabel.AutoSize = true;
            PresentersLabel.Location = new Point(596, 28);
            PresentersLabel.Name = "PresentersLabel";
            PresentersLabel.Size = new Size(76, 20);
            PresentersLabel.TabIndex = 5;
            PresentersLabel.Text = "Presenters";
            // 
            // User_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PresentersLabel);
            Controls.Add(VendorsLabel);
            Controls.Add(presenterData);
            Controls.Add(vendorData);
            Name = "User_Form";
            Text = "User_Form";
            Load += User_Form_Load;
            ((System.ComponentModel.ISupportInitialize)vendorData).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)presenterData).EndInit();
            ((System.ComponentModel.ISupportInitialize)presenterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView vendorData;
        private BindingSource vendorBindingSource;
        private DataGridView presenterData;
        private BindingSource presenterBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn presenterFeeDataGridViewTextBoxColumn;
        private Label VendorsLabel;
        private Label PresentersLabel;
    }
}