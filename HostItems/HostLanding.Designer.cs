namespace Event_Manager
{
    partial class HostLanding
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
            button_RegisterEvent = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            eventBindingSource = new BindingSource(components);
            eventIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            websiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button_RegisterEvent
            // 
            button_RegisterEvent.Location = new Point(572, 340);
            button_RegisterEvent.Name = "button_RegisterEvent";
            button_RegisterEvent.Size = new Size(112, 72);
            button_RegisterEvent.TabIndex = 0;
            button_RegisterEvent.Text = "Register Event";
            button_RegisterEvent.UseVisualStyleBackColor = true;
            button_RegisterEvent.Click += button1_RegisterEvent;
            // 
            // button2
            // 
            button2.Location = new Point(351, 324);
            button2.Name = "button2";
            button2.Size = new Size(112, 72);
            button2.TabIndex = 1;
            button2.Text = "View Events";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(160, 340);
            button3.Name = "button3";
            button3.Size = new Size(131, 72);
            button3.TabIndex = 2;
            button3.Text = "View Account Info";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { eventIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, websiteDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = eventBindingSource;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(800, 258);
            dataGridView1.TabIndex = 3;
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
            // HostLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_RegisterEvent);
            Name = "HostLanding";
            Text = "HostLanding";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_RegisterEvent;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
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