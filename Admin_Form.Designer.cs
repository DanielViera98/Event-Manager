namespace Event_Manager
{
    partial class Admin_Form
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
            label2 = new Label();
            EventsButton = new Button();
            VendorsButton = new Button();
            LocationsButton = new Button();
            PresentersButton = new Button();
            HostsButton = new Button();
            dataGridView1 = new DataGridView();
            eventBindingSource = new BindingSource(components);
            AttendeesButton = new Button();
            EmployeesButton = new Button();
            TicketsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // EventsButton
            // 
            EventsButton.Location = new Point(0, 0);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(112, 34);
            EventsButton.TabIndex = 2;
            EventsButton.Text = "Events";
            EventsButton.UseVisualStyleBackColor = true;
            EventsButton.Click += EventsButton_Click;
            // 
            // VendorsButton
            // 
            VendorsButton.Location = new Point(0, 70);
            VendorsButton.Name = "VendorsButton";
            VendorsButton.Size = new Size(112, 34);
            VendorsButton.TabIndex = 3;
            VendorsButton.Text = "Vendors";
            VendorsButton.UseVisualStyleBackColor = true;
            VendorsButton.Click += VendorsButton_Click;
            // 
            // LocationsButton
            // 
            LocationsButton.Location = new Point(0, 105);
            LocationsButton.Name = "LocationsButton";
            LocationsButton.Size = new Size(112, 34);
            LocationsButton.TabIndex = 4;
            LocationsButton.Text = "Locations";
            LocationsButton.UseVisualStyleBackColor = true;
            LocationsButton.Click += LocationsButton_Click;
            // 
            // PresentersButton
            // 
            PresentersButton.Location = new Point(0, 140);
            PresentersButton.Name = "PresentersButton";
            PresentersButton.Size = new Size(112, 34);
            PresentersButton.TabIndex = 5;
            PresentersButton.Text = "Presenters";
            PresentersButton.UseVisualStyleBackColor = true;
            PresentersButton.Click += PresentersButton_Click;
            // 
            // HostsButton
            // 
            HostsButton.Location = new Point(0, 35);
            HostsButton.Name = "HostsButton";
            HostsButton.Size = new Size(112, 34);
            HostsButton.TabIndex = 6;
            HostsButton.Text = "Hosts";
            HostsButton.UseVisualStyleBackColor = true;
            HostsButton.Click += HostsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(118, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(681, 449);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Event);
            // 
            // AttendeesButton
            // 
            AttendeesButton.Location = new Point(0, 175);
            AttendeesButton.Name = "AttendeesButton";
            AttendeesButton.Size = new Size(112, 34);
            AttendeesButton.TabIndex = 8;
            AttendeesButton.Text = "Attendees";
            AttendeesButton.UseVisualStyleBackColor = true;
            AttendeesButton.Click += AttendeesButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(0, 210);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(112, 34);
            EmployeesButton.TabIndex = 9;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // TicketsButton
            // 
            TicketsButton.Location = new Point(0, 245);
            TicketsButton.Name = "TicketsButton";
            TicketsButton.Size = new Size(112, 34);
            TicketsButton.TabIndex = 10;
            TicketsButton.Text = "Tickets";
            TicketsButton.UseVisualStyleBackColor = true;
            TicketsButton.Click += TicketsButton_Click;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TicketsButton);
            Controls.Add(EmployeesButton);
            Controls.Add(AttendeesButton);
            Controls.Add(dataGridView1);
            Controls.Add(HostsButton);
            Controls.Add(PresentersButton);
            Controls.Add(LocationsButton);
            Controls.Add(VendorsButton);
            Controls.Add(EventsButton);
            Controls.Add(label2);
            Name = "Admin_Form";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button EventsButton;
        private Button VendorsButton;
        private Button LocationsButton;
        private Button PresentersButton;
        private Button HostsButton;
        private DataGridView dataGridView1;
        private BindingSource eventBindingSource;
        private Button AttendeesButton;
        private Button EmployeesButton;
        private Button TicketsButton;
    }
}