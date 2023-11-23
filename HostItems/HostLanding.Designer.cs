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
            button_RegisterEvent = new Button();
            button_Refresh = new Button();
            button3 = new Button();
            dataGridView_Events = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Events).BeginInit();
            SuspendLayout();
            // 
            // button_RegisterEvent
            // 
            button_RegisterEvent.Location = new Point(572, 340);
            button_RegisterEvent.Name = "button_RegisterEvent";
            button_RegisterEvent.Size = new Size(110, 70);
            button_RegisterEvent.TabIndex = 0;
            button_RegisterEvent.Text = "Register Event";
            button_RegisterEvent.UseVisualStyleBackColor = true;
            button_RegisterEvent.Click += button_RegisterEvent_Click;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(355, 340);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(110, 70);
            button_Refresh.TabIndex = 1;
            button_Refresh.Text = "Refresh View";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 340);
            button3.Name = "button3";
            button3.Size = new Size(168, 70);
            button3.TabIndex = 2;
            button3.Text = "View Account Info";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Events
            // 
            dataGridView_Events.AllowUserToAddRows = false;
            dataGridView_Events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Events.Dock = DockStyle.Top;
            dataGridView_Events.Location = new Point(0, 0);
            dataGridView_Events.Name = "dataGridView_Events";
            dataGridView_Events.RowHeadersWidth = 62;
            dataGridView_Events.RowTemplate.Height = 33;
            dataGridView_Events.Size = new Size(800, 258);
            dataGridView_Events.TabIndex = 3;
            // 
            // HostLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_Events);
            Controls.Add(button3);
            Controls.Add(button_Refresh);
            Controls.Add(button_RegisterEvent);
            Name = "HostLanding";
            Text = "HostLanding";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Events).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_RegisterEvent;
        private Button button_Refresh;
        private Button button3;
        private DataGridView dataGridView_Events;
    }
}