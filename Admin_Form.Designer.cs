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
            DeleteButton = new Button();
            ModifyButton = new Button();
            HasSpaceButton = new Button();
            HostedByButton = new Button();
            PresentsButton = new Button();
            hasSpaceBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hasSpaceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // EventsButton
            // 
            EventsButton.Location = new Point(0, 0);
            EventsButton.Margin = new Padding(2);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(90, 27);
            EventsButton.TabIndex = 2;
            EventsButton.Text = "Events";
            EventsButton.UseVisualStyleBackColor = true;
            EventsButton.Click += EventsButton_Click;
            // 
            // VendorsButton
            // 
            VendorsButton.Location = new Point(0, 56);
            VendorsButton.Margin = new Padding(2);
            VendorsButton.Name = "VendorsButton";
            VendorsButton.Size = new Size(90, 27);
            VendorsButton.TabIndex = 3;
            VendorsButton.Text = "Vendors";
            VendorsButton.UseVisualStyleBackColor = true;
            VendorsButton.Click += VendorsButton_Click;
            // 
            // LocationsButton
            // 
            LocationsButton.Location = new Point(0, 84);
            LocationsButton.Margin = new Padding(2);
            LocationsButton.Name = "LocationsButton";
            LocationsButton.Size = new Size(90, 27);
            LocationsButton.TabIndex = 4;
            LocationsButton.Text = "Locations";
            LocationsButton.UseVisualStyleBackColor = true;
            LocationsButton.Click += LocationsButton_Click;
            // 
            // PresentersButton
            // 
            PresentersButton.Location = new Point(0, 112);
            PresentersButton.Margin = new Padding(2);
            PresentersButton.Name = "PresentersButton";
            PresentersButton.Size = new Size(90, 27);
            PresentersButton.TabIndex = 5;
            PresentersButton.Text = "Presenters";
            PresentersButton.UseVisualStyleBackColor = true;
            PresentersButton.Click += PresentersButton_Click;
            // 
            // HostsButton
            // 
            HostsButton.Location = new Point(0, 28);
            HostsButton.Margin = new Padding(2);
            HostsButton.Name = "HostsButton";
            HostsButton.Size = new Size(90, 27);
            HostsButton.TabIndex = 6;
            HostsButton.Text = "Hosts";
            HostsButton.UseVisualStyleBackColor = true;
            HostsButton.Click += HostsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(963, 453);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Event);
            // 
            // AttendeesButton
            // 
            AttendeesButton.Location = new Point(0, 140);
            AttendeesButton.Margin = new Padding(2);
            AttendeesButton.Name = "AttendeesButton";
            AttendeesButton.Size = new Size(90, 27);
            AttendeesButton.TabIndex = 8;
            AttendeesButton.Text = "Attendees";
            AttendeesButton.UseVisualStyleBackColor = true;
            AttendeesButton.Click += AttendeesButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(0, 168);
            EmployeesButton.Margin = new Padding(2);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(90, 27);
            EmployeesButton.TabIndex = 9;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // TicketsButton
            // 
            TicketsButton.Location = new Point(0, 196);
            TicketsButton.Margin = new Padding(2);
            TicketsButton.Name = "TicketsButton";
            TicketsButton.Size = new Size(90, 27);
            TicketsButton.TabIndex = 10;
            TicketsButton.Text = "Tickets";
            TicketsButton.UseVisualStyleBackColor = true;
            TicketsButton.Click += TicketsButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(0, 423);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(0, 388);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(94, 29);
            ModifyButton.TabIndex = 12;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // HasSpaceButton
            // 
            HasSpaceButton.Location = new Point(0, 228);
            HasSpaceButton.Name = "HasSpaceButton";
            HasSpaceButton.Size = new Size(94, 29);
            HasSpaceButton.TabIndex = 13;
            HasSpaceButton.Text = "HasSpace";
            HasSpaceButton.UseVisualStyleBackColor = true;
            HasSpaceButton.Click += HasSpaceButton_Click_1;
            // 
            // HostedByButton
            // 
            HostedByButton.Location = new Point(0, 263);
            HostedByButton.Name = "HostedByButton";
            HostedByButton.Size = new Size(94, 29);
            HostedByButton.TabIndex = 14;
            HostedByButton.Text = "HostedBy";
            HostedByButton.UseVisualStyleBackColor = true;
            HostedByButton.Click += HostedByButton_Click_1;
            // 
            // PresentsButton
            // 
            PresentsButton.Location = new Point(0, 298);
            PresentsButton.Name = "PresentsButton";
            PresentsButton.Size = new Size(94, 29);
            PresentsButton.TabIndex = 15;
            PresentsButton.Text = "Presents";
            PresentsButton.UseVisualStyleBackColor = true;
            PresentsButton.Click += PresentsButton_Click_1;
            // 
            // hasSpaceBindingSource
            // 
            hasSpaceBindingSource.DataSource = typeof(HasSpace);
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 464);
            Controls.Add(PresentsButton);
            Controls.Add(HostedByButton);
            Controls.Add(HasSpaceButton);
            Controls.Add(ModifyButton);
            Controls.Add(DeleteButton);
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
            Margin = new Padding(2);
            Name = "Admin_Form";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hasSpaceBindingSource).EndInit();
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
        private Button DeleteButton;
        private Button ModifyButton;
        private Button HasSpaceButton;
        private Button HostedByButton;
        private Button PresentsButton;
        private BindingSource hasSpaceBindingSource;
    }
}