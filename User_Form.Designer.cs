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
            vendorBindingSource = new BindingSource(components);
            presenterData = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            presenterFeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presenterBindingSource = new BindingSource(components);
            feeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendorData = new DataGridView();
            PresentersLabel = new Label();
            VendorsLabel = new Label();
            showPresenters = new CheckBox();
            showVendors = new CheckBox();
            ShowEvents = new CheckBox();
            eventData = new DataGridView();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            websiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventBindingSource = new BindingSource(components);
            EventsLabel = new Label();
            eventIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presentationData = new DataGridView();
            roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presenterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presentsBindingSource = new BindingSource(components);
            PresentsLabel = new Label();
            ShowPresentations = new CheckBox();
            hostedData = new DataGridView();
            hostedIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            hostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hostedByBindingSource = new BindingSource(components);
            HostedLabel = new Label();
            ShowHosts = new CheckBox();
            ticketData = new DataGridView();
            ticketIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            attendeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ticketTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ticketBindingSource = new BindingSource(components);
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TicketsLabel = new Label();
            ShowTickets = new CheckBox();
            buyButton = new Button();
            confirmation = new TextBox();
            Confirm = new Button();
            Cancel = new Button();
            NameBox = new TextBox();
            Choice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presenterData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presenterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendorData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presentationData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hostedData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hostedByBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            SuspendLayout();
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
            presenterData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            presenterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            presenterData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, presenterFeeDataGridViewTextBoxColumn });
            presenterData.DataSource = presenterBindingSource;
            presenterData.Location = new Point(410, 89);
            presenterData.Name = "presenterData";
            presenterData.ReadOnly = true;
            presenterData.RowHeadersWidth = 51;
            presenterData.RowTemplate.Height = 29;
            presenterData.Size = new Size(720, 188);
            presenterData.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 78;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            emailDataGridViewTextBoxColumn1.ReadOnly = true;
            emailDataGridViewTextBoxColumn1.Width = 75;
            // 
            // presenterFeeDataGridViewTextBoxColumn
            // 
            presenterFeeDataGridViewTextBoxColumn.DataPropertyName = "PresenterFee";
            presenterFeeDataGridViewTextBoxColumn.HeaderText = "Fee";
            presenterFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            presenterFeeDataGridViewTextBoxColumn.Name = "presenterFeeDataGridViewTextBoxColumn";
            presenterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            presenterFeeDataGridViewTextBoxColumn.Width = 61;
            // 
            // presenterBindingSource
            // 
            presenterBindingSource.DataSource = typeof(Presenter);
            // 
            // feeDataGridViewTextBoxColumn
            // 
            feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            feeDataGridViewTextBoxColumn.MinimumWidth = 6;
            feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            feeDataGridViewTextBoxColumn.ReadOnly = true;
            feeDataGridViewTextBoxColumn.Width = 61;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 78;
            // 
            // vendorData
            // 
            vendorData.AllowUserToAddRows = false;
            vendorData.AllowUserToDeleteRows = false;
            vendorData.AutoGenerateColumns = false;
            vendorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            vendorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendorData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, feeDataGridViewTextBoxColumn });
            vendorData.DataSource = vendorBindingSource;
            vendorData.Location = new Point(545, 107);
            vendorData.Name = "vendorData";
            vendorData.ReadOnly = true;
            vendorData.RowHeadersWidth = 51;
            vendorData.RowTemplate.Height = 29;
            vendorData.Size = new Size(720, 188);
            vendorData.TabIndex = 2;
            vendorData.CellContentClick += vendorData_CellContentClick;
            // 
            // PresentersLabel
            // 
            PresentersLabel.AutoSize = true;
            PresentersLabel.Location = new Point(319, 3);
            PresentersLabel.Name = "PresentersLabel";
            PresentersLabel.Size = new Size(76, 20);
            PresentersLabel.TabIndex = 5;
            PresentersLabel.Text = "Presenters";
            PresentersLabel.Click += PresentersLabel_Click;
            // 
            // VendorsLabel
            // 
            VendorsLabel.AutoSize = true;
            VendorsLabel.Location = new Point(333, 89);
            VendorsLabel.Name = "VendorsLabel";
            VendorsLabel.Size = new Size(62, 20);
            VendorsLabel.TabIndex = 4;
            VendorsLabel.Text = "Vendors";
            VendorsLabel.Click += VendorsLabel_Click;
            // 
            // showPresenters
            // 
            showPresenters.AutoSize = true;
            showPresenters.Location = new Point(12, 47);
            showPresenters.Name = "showPresenters";
            showPresenters.Size = new Size(138, 24);
            showPresenters.TabIndex = 6;
            showPresenters.Text = "Show Presenters";
            showPresenters.UseVisualStyleBackColor = true;
            showPresenters.CheckedChanged += showPresenters_CheckedChanged;
            // 
            // showVendors
            // 
            showVendors.AutoSize = true;
            showVendors.Location = new Point(12, 77);
            showVendors.Name = "showVendors";
            showVendors.Size = new Size(124, 24);
            showVendors.TabIndex = 7;
            showVendors.Text = "Show Vendors";
            showVendors.UseVisualStyleBackColor = true;
            showVendors.CheckedChanged += showVendors_CheckedChanged;
            // 
            // ShowEvents
            // 
            ShowEvents.AutoSize = true;
            ShowEvents.Location = new Point(12, 107);
            ShowEvents.Name = "ShowEvents";
            ShowEvents.Size = new Size(113, 24);
            ShowEvents.TabIndex = 8;
            ShowEvents.Text = "Show Events";
            ShowEvents.UseVisualStyleBackColor = true;
            ShowEvents.CheckedChanged += ShowEvents_CheckedChanged;
            // 
            // eventData
            // 
            eventData.AllowUserToAddRows = false;
            eventData.AllowUserToDeleteRows = false;
            eventData.AutoGenerateColumns = false;
            eventData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            eventData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn2, descriptionDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, websiteDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            eventData.DataSource = eventBindingSource;
            eventData.Location = new Point(434, 217);
            eventData.Name = "eventData";
            eventData.ReadOnly = true;
            eventData.RowHeadersWidth = 51;
            eventData.RowTemplate.Height = 29;
            eventData.Size = new Size(720, 188);
            eventData.TabIndex = 9;
            eventData.CellContentClick += eventData_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            nameDataGridViewTextBoxColumn2.ReadOnly = true;
            nameDataGridViewTextBoxColumn2.Width = 78;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 114;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 101;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.Width = 95;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            websiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            websiteDataGridViewTextBoxColumn.ReadOnly = true;
            websiteDataGridViewTextBoxColumn.Width = 91;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.ReadOnly = true;
            locationDataGridViewTextBoxColumn.Width = 95;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Event);
            // 
            // EventsLabel
            // 
            EventsLabel.AutoSize = true;
            EventsLabel.Location = new Point(342, 136);
            EventsLabel.Name = "EventsLabel";
            EventsLabel.Size = new Size(51, 20);
            EventsLabel.TabIndex = 10;
            EventsLabel.Text = "Events";
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            eventIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // presentationData
            // 
            presentationData.AllowUserToAddRows = false;
            presentationData.AllowUserToDeleteRows = false;
            presentationData.AutoGenerateColumns = false;
            presentationData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            presentationData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            presentationData.Columns.AddRange(new DataGridViewColumn[] { roomIDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn1, timeDataGridViewTextBoxColumn, presenterDataGridViewTextBoxColumn, eventDataGridViewTextBoxColumn });
            presentationData.DataSource = presentsBindingSource;
            presentationData.Location = new Point(298, 112);
            presentationData.Name = "presentationData";
            presentationData.ReadOnly = true;
            presentationData.RowHeadersWidth = 51;
            presentationData.RowTemplate.Height = 29;
            presentationData.Size = new Size(720, 188);
            presentationData.TabIndex = 11;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            roomIDDataGridViewTextBoxColumn.Width = 93;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 67;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn1.Width = 114;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.ReadOnly = true;
            timeDataGridViewTextBoxColumn.Width = 71;
            // 
            // presenterDataGridViewTextBoxColumn
            // 
            presenterDataGridViewTextBoxColumn.DataPropertyName = "Presenter";
            presenterDataGridViewTextBoxColumn.HeaderText = "Presenter";
            presenterDataGridViewTextBoxColumn.MinimumWidth = 6;
            presenterDataGridViewTextBoxColumn.Name = "presenterDataGridViewTextBoxColumn";
            presenterDataGridViewTextBoxColumn.ReadOnly = true;
            presenterDataGridViewTextBoxColumn.Width = 99;
            // 
            // eventDataGridViewTextBoxColumn
            // 
            eventDataGridViewTextBoxColumn.DataPropertyName = "Event";
            eventDataGridViewTextBoxColumn.HeaderText = "Event";
            eventDataGridViewTextBoxColumn.MinimumWidth = 6;
            eventDataGridViewTextBoxColumn.Name = "eventDataGridViewTextBoxColumn";
            eventDataGridViewTextBoxColumn.ReadOnly = true;
            eventDataGridViewTextBoxColumn.Width = 74;
            // 
            // presentsBindingSource
            // 
            presentsBindingSource.DataSource = typeof(Presents);
            // 
            // PresentsLabel
            // 
            PresentsLabel.AutoSize = true;
            PresentsLabel.Location = new Point(298, 177);
            PresentsLabel.Name = "PresentsLabel";
            PresentsLabel.Size = new Size(97, 20);
            PresentsLabel.TabIndex = 12;
            PresentsLabel.Text = "Presentations";
            // 
            // ShowPresentations
            // 
            ShowPresentations.AutoSize = true;
            ShowPresentations.Location = new Point(12, 137);
            ShowPresentations.Name = "ShowPresentations";
            ShowPresentations.Size = new Size(159, 24);
            ShowPresentations.TabIndex = 13;
            ShowPresentations.Text = "Show Presentations";
            ShowPresentations.UseVisualStyleBackColor = true;
            ShowPresentations.CheckedChanged += ShowPresentations_CheckedChanged;
            // 
            // hostedData
            // 
            hostedData.AllowUserToAddRows = false;
            hostedData.AllowUserToDeleteRows = false;
            hostedData.AutoGenerateColumns = false;
            hostedData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            hostedData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hostedData.Columns.AddRange(new DataGridViewColumn[] { hostedIDDataGridViewTextBoxColumn, eventDataGridViewTextBoxColumn1, hostDataGridViewTextBoxColumn });
            hostedData.DataSource = hostedByBindingSource;
            hostedData.Location = new Point(276, 155);
            hostedData.Name = "hostedData";
            hostedData.ReadOnly = true;
            hostedData.RowHeadersWidth = 51;
            hostedData.RowTemplate.Height = 29;
            hostedData.Size = new Size(720, 188);
            hostedData.TabIndex = 14;
            // 
            // hostedIDDataGridViewTextBoxColumn
            // 
            hostedIDDataGridViewTextBoxColumn.DataPropertyName = "HostedID";
            hostedIDDataGridViewTextBoxColumn.HeaderText = "HostedID";
            hostedIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            hostedIDDataGridViewTextBoxColumn.Name = "hostedIDDataGridViewTextBoxColumn";
            hostedIDDataGridViewTextBoxColumn.ReadOnly = true;
            hostedIDDataGridViewTextBoxColumn.Width = 101;
            // 
            // eventDataGridViewTextBoxColumn1
            // 
            eventDataGridViewTextBoxColumn1.DataPropertyName = "Event";
            eventDataGridViewTextBoxColumn1.HeaderText = "Event";
            eventDataGridViewTextBoxColumn1.MinimumWidth = 6;
            eventDataGridViewTextBoxColumn1.Name = "eventDataGridViewTextBoxColumn1";
            eventDataGridViewTextBoxColumn1.ReadOnly = true;
            eventDataGridViewTextBoxColumn1.Width = 74;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
            hostDataGridViewTextBoxColumn.HeaderText = "Host";
            hostDataGridViewTextBoxColumn.MinimumWidth = 6;
            hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            hostDataGridViewTextBoxColumn.ReadOnly = true;
            hostDataGridViewTextBoxColumn.Width = 69;
            // 
            // hostedByBindingSource
            // 
            hostedByBindingSource.DataSource = typeof(HostedBy);
            // 
            // HostedLabel
            // 
            HostedLabel.AutoSize = true;
            HostedLabel.Location = new Point(353, 255);
            HostedLabel.Name = "HostedLabel";
            HostedLabel.Size = new Size(40, 20);
            HostedLabel.TabIndex = 15;
            HostedLabel.Text = "Host";
            // 
            // ShowHosts
            // 
            ShowHosts.AutoSize = true;
            ShowHosts.Location = new Point(12, 167);
            ShowHosts.Name = "ShowHosts";
            ShowHosts.Size = new Size(108, 24);
            ShowHosts.TabIndex = 16;
            ShowHosts.Text = "Show Hosts";
            ShowHosts.UseVisualStyleBackColor = true;
            ShowHosts.CheckedChanged += ShowHosts_CheckedChanged;
            // 
            // ticketData
            // 
            ticketData.AllowUserToAddRows = false;
            ticketData.AllowUserToDeleteRows = false;
            ticketData.AutoGenerateColumns = false;
            ticketData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ticketData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketData.Columns.AddRange(new DataGridViewColumn[] { ticketIDDataGridViewTextBoxColumn, attendeeDataGridViewTextBoxColumn, eventDataGridViewTextBoxColumn2, ticketTypeDataGridViewTextBoxColumn });
            ticketData.DataSource = ticketBindingSource;
            ticketData.Location = new Point(240, 206);
            ticketData.Name = "ticketData";
            ticketData.ReadOnly = true;
            ticketData.RowHeadersWidth = 51;
            ticketData.RowTemplate.Height = 29;
            ticketData.Size = new Size(720, 188);
            ticketData.TabIndex = 17;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            ticketIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // attendeeDataGridViewTextBoxColumn
            // 
            attendeeDataGridViewTextBoxColumn.DataPropertyName = "Attendee";
            attendeeDataGridViewTextBoxColumn.HeaderText = "Attendee";
            attendeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            attendeeDataGridViewTextBoxColumn.Name = "attendeeDataGridViewTextBoxColumn";
            attendeeDataGridViewTextBoxColumn.ReadOnly = true;
            attendeeDataGridViewTextBoxColumn.Width = 99;
            // 
            // eventDataGridViewTextBoxColumn2
            // 
            eventDataGridViewTextBoxColumn2.DataPropertyName = "Event";
            eventDataGridViewTextBoxColumn2.HeaderText = "Event";
            eventDataGridViewTextBoxColumn2.MinimumWidth = 6;
            eventDataGridViewTextBoxColumn2.Name = "eventDataGridViewTextBoxColumn2";
            eventDataGridViewTextBoxColumn2.ReadOnly = true;
            eventDataGridViewTextBoxColumn2.Width = 74;
            // 
            // ticketTypeDataGridViewTextBoxColumn
            // 
            ticketTypeDataGridViewTextBoxColumn.DataPropertyName = "TicketType";
            ticketTypeDataGridViewTextBoxColumn.HeaderText = "TicketType";
            ticketTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            ticketTypeDataGridViewTextBoxColumn.Name = "ticketTypeDataGridViewTextBoxColumn";
            ticketTypeDataGridViewTextBoxColumn.ReadOnly = true;
            ticketTypeDataGridViewTextBoxColumn.Width = 108;
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(Ticket);
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.MinimumWidth = 6;
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.Width = 67;
            // 
            // TicketsLabel
            // 
            TicketsLabel.AutoSize = true;
            TicketsLabel.Location = new Point(339, 302);
            TicketsLabel.Name = "TicketsLabel";
            TicketsLabel.Size = new Size(54, 20);
            TicketsLabel.TabIndex = 18;
            TicketsLabel.Text = "Tickets";
            // 
            // ShowTickets
            // 
            ShowTickets.AutoSize = true;
            ShowTickets.Location = new Point(12, 197);
            ShowTickets.Name = "ShowTickets";
            ShowTickets.Size = new Size(116, 24);
            ShowTickets.TabIndex = 19;
            ShowTickets.Text = "Show Tickets";
            ShowTickets.UseVisualStyleBackColor = true;
            ShowTickets.CheckedChanged += ShowTickets_CheckedChanged;
            // 
            // buyButton
            // 
            buyButton.Location = new Point(12, 281);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(222, 29);
            buyButton.TabIndex = 20;
            buyButton.Text = "buy ticket";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // confirmation
            // 
            confirmation.Location = new Point(12, 316);
            confirmation.Name = "confirmation";
            confirmation.ReadOnly = true;
            confirmation.Size = new Size(222, 27);
            confirmation.TabIndex = 21;
            confirmation.Text = "Are you sure?";
            confirmation.TextAlign = HorizontalAlignment.Center;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(12, 349);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(94, 29);
            Confirm.TabIndex = 22;
            Confirm.Text = "Yes";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(140, 349);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 23;
            Cancel.Text = "No";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 12);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(222, 27);
            NameBox.TabIndex = 24;
            // 
            // Choice
            // 
            Choice.Location = new Point(11, 235);
            Choice.Name = "Choice";
            Choice.ReadOnly = true;
            Choice.Size = new Size(223, 27);
            Choice.TabIndex = 25;
            Choice.Text = "Select an Event";
            // 
            // User_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(Choice);
            Controls.Add(NameBox);
            Controls.Add(Cancel);
            Controls.Add(Confirm);
            Controls.Add(confirmation);
            Controls.Add(buyButton);
            Controls.Add(ShowTickets);
            Controls.Add(TicketsLabel);
            Controls.Add(ticketData);
            Controls.Add(ShowHosts);
            Controls.Add(HostedLabel);
            Controls.Add(hostedData);
            Controls.Add(ShowPresentations);
            Controls.Add(PresentsLabel);
            Controls.Add(presentationData);
            Controls.Add(EventsLabel);
            Controls.Add(eventData);
            Controls.Add(ShowEvents);
            Controls.Add(showVendors);
            Controls.Add(showPresenters);
            Controls.Add(PresentersLabel);
            Controls.Add(VendorsLabel);
            Controls.Add(presenterData);
            Controls.Add(vendorData);
            Name = "User_Form";
            Text = "User_Form";
            Load += User_Form_Load;
            ((System.ComponentModel.ISupportInitialize)vendorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)presenterData).EndInit();
            ((System.ComponentModel.ISupportInitialize)presenterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendorData).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventData).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)presentationData).EndInit();
            ((System.ComponentModel.ISupportInitialize)presentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hostedData).EndInit();
            ((System.ComponentModel.ISupportInitialize)hostedByBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketData).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource vendorBindingSource;
        private DataGridView presenterData;
        private BindingSource presenterBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn presenterFeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridView vendorData;
        private Label PresentersLabel;
        private Label VendorsLabel;
        private CheckBox showPresenters;
        private CheckBox showVendors;
        private CheckBox ShowEvents;
        private DataGridView eventData;
        private BindingSource eventBindingSource;
        private Label EventsLabel;
        private DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridView presentationData;
        private BindingSource presentsBindingSource;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn presenterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
        private Label PresentsLabel;
        private CheckBox ShowPresentations;
        private DataGridView hostedData;
        private BindingSource hostedByBindingSource;
        private DataGridViewTextBoxColumn hostedIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private Label HostedLabel;
        private CheckBox ShowHosts;
        private DataGridView ticketData;
        private DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attendeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ticketTypeDataGridViewTextBoxColumn;
        private BindingSource ticketBindingSource;
        private Label TicketsLabel;
        private CheckBox ShowTickets;
        private Button buyButton;
        private TextBox confirmation;
        private Button Confirm;
        private Button Cancel;
        private TextBox NameBox;
        private TextBox Choice;
    }
}