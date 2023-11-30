namespace Event_Manager.PresenterItems
{
    partial class PresenterLanding
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
            dataGridView_Presenters = new DataGridView();
            panel1 = new Panel();
            button_Register = new Button();
            eventBindingSource = new BindingSource(components);
            eventIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            websiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Presenters
            // 
            dataGridView_Presenters.AutoGenerateColumns = false;
            dataGridView_Presenters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Presenters.Columns.AddRange(new DataGridViewColumn[] { eventIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, websiteDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            dataGridView_Presenters.DataSource = eventBindingSource;
            dataGridView_Presenters.Dock = DockStyle.Top;
            dataGridView_Presenters.Location = new Point(0, 0);
            dataGridView_Presenters.Name = "dataGridView_Presenters";
            dataGridView_Presenters.RowHeadersWidth = 62;
            dataGridView_Presenters.RowTemplate.Height = 33;
            dataGridView_Presenters.Size = new Size(800, 317);
            dataGridView_Presenters.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Register);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 133);
            panel1.TabIndex = 1;
            // 
            // button_Register
            // 
            button_Register.Location = new Point(345, 31);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(110, 70);
            button_Register.TabIndex = 1;
            button_Register.Text = "Register For Event";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Event);
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            eventIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            eventIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            websiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            websiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.Width = 150;
            // 
            // PresenterLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Presenters);
            Name = "PresenterLanding";
            Text = "PresenterLanding";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Presenters;
        private Panel panel1;
        private Button button_Register;
        private DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private BindingSource eventBindingSource;
    }
}