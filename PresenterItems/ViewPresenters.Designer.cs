namespace Event_Manager.PresenterItems
{
    partial class ViewPresenters
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
            dataGridView_Presenters = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            button_close = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Presenters
            // 
            dataGridView_Presenters.AllowUserToAddRows = false;
            dataGridView_Presenters.AllowUserToDeleteRows = false;
            dataGridView_Presenters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Presenters.Dock = DockStyle.Fill;
            dataGridView_Presenters.Location = new Point(0, 0);
            dataGridView_Presenters.Name = "dataGridView_Presenters";
            dataGridView_Presenters.RowHeadersWidth = 62;
            dataGridView_Presenters.Size = new Size(716, 449);
            dataGridView_Presenters.TabIndex = 0;
            dataGridView_Presenters.DataError += dataGridView_Presenters_DataError;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(dataGridView_Presenters);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 449);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button_close);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 349);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 100);
            panel2.TabIndex = 2;
            // 
            // button_close
            // 
            button_close.Anchor = AnchorStyles.None;
            button_close.Location = new Point(303, 13);
            button_close.Name = "button_close";
            button_close.Size = new Size(110, 70);
            button_close.TabIndex = 0;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(171, 13);
            button1.Name = "button1";
            button1.Size = new Size(110, 70);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // ViewPresenters
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 449);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ViewPresenters";
            Text = "ViewPresenters";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Presenters;
        private Panel panel1;
        private Panel panel2;
        private Button button_close;
        private Button button1;
    }
}