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
            dataGridView_Events = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Events).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_RegisterEvent
            // 
            button_RegisterEvent.Anchor = AnchorStyles.Top;
            button_RegisterEvent.Location = new Point(416, 27);
            button_RegisterEvent.Name = "button_RegisterEvent";
            button_RegisterEvent.Size = new Size(110, 70);
            button_RegisterEvent.TabIndex = 0;
            button_RegisterEvent.Text = "Register Event";
            button_RegisterEvent.UseVisualStyleBackColor = true;
            button_RegisterEvent.Click += button_RegisterEvent_Click;
            // 
            // button_Refresh
            // 
            button_Refresh.Anchor = AnchorStyles.Top;
            button_Refresh.Location = new Point(279, 27);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(110, 70);
            button_Refresh.TabIndex = 1;
            button_Refresh.Text = "Refresh View";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // dataGridView_Events
            // 
            dataGridView_Events.AllowUserToAddRows = false;
            dataGridView_Events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Events.Dock = DockStyle.Fill;
            dataGridView_Events.Location = new Point(0, 0);
            dataGridView_Events.Name = "dataGridView_Events";
            dataGridView_Events.RowHeadersWidth = 62;
            dataGridView_Events.RowTemplate.Height = 33;
            dataGridView_Events.Size = new Size(804, 439);
            dataGridView_Events.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Refresh);
            panel1.Controls.Add(button_RegisterEvent);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 314);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 125);
            panel1.TabIndex = 4;
            // 
            // HostLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 439);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Events);
            Name = "HostLanding";
            Text = "HostLanding";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Events).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_RegisterEvent;
        private Button button_Refresh;
        private DataGridView dataGridView_Events;
        private Panel panel1;
    }
}