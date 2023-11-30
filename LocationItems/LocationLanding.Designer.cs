namespace Event_Manager.LocationItems
{
    partial class LocationLanding
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
            dataGridView_Locations = new DataGridView();
            button_addLocation = new Button();
            button_Refresh = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Locations).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Locations
            // 
            dataGridView_Locations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Locations.Dock = DockStyle.Top;
            dataGridView_Locations.Location = new Point(0, 0);
            dataGridView_Locations.Name = "dataGridView_Locations";
            dataGridView_Locations.RowHeadersWidth = 62;
            dataGridView_Locations.RowTemplate.Height = 33;
            dataGridView_Locations.Size = new Size(800, 344);
            dataGridView_Locations.TabIndex = 0;
            // 
            // button_addLocation
            // 
            button_addLocation.Location = new Point(403, 18);
            button_addLocation.Name = "button_addLocation";
            button_addLocation.Size = new Size(110, 70);
            button_addLocation.TabIndex = 1;
            button_addLocation.Text = "Add Location";
            button_addLocation.UseVisualStyleBackColor = true;
            button_addLocation.Click += button_addLocation_Click;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(287, 18);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(110, 70);
            button_Refresh.TabIndex = 2;
            button_Refresh.Text = "Refresh View";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Refresh);
            panel1.Controls.Add(button_addLocation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 106);
            panel1.TabIndex = 3;
            // 
            // LocationLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Locations);
            Name = "LocationLanding";
            Text = "LocationLanding";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Locations).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Locations;
        private Button button_addLocation;
        private Button button_Refresh;
        private Panel panel1;
    }
}