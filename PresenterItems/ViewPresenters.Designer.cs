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
            panel2 = new Panel();
            button_refresh = new Button();
            checkBox_ViewUserPresents = new CheckBox();
            button_DeletePresentation = new Button();
            button_close = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            dataGridView_Presenters.Size = new Size(716, 349);
            dataGridView_Presenters.TabIndex = 0;
            dataGridView_Presenters.DataError += dataGridView_Presenters_DataError;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(button_refresh);
            panel2.Controls.Add(checkBox_ViewUserPresents);
            panel2.Controls.Add(button_DeletePresentation);
            panel2.Controls.Add(button_close);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 349);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 100);
            panel2.TabIndex = 2;
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.None;
            button_refresh.Location = new Point(435, 13);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(110, 70);
            button_refresh.TabIndex = 5;
            button_refresh.Text = "Refresh View";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // checkBox_ViewUserPresents
            // 
            checkBox_ViewUserPresents.AutoSize = true;
            checkBox_ViewUserPresents.Location = new Point(12, 3);
            checkBox_ViewUserPresents.Name = "checkBox_ViewUserPresents";
            checkBox_ViewUserPresents.Size = new Size(144, 54);
            checkBox_ViewUserPresents.TabIndex = 4;
            checkBox_ViewUserPresents.Text = "View User's \r\nPresentations";
            checkBox_ViewUserPresents.UseVisualStyleBackColor = true;
            checkBox_ViewUserPresents.CheckedChanged += checkBox_ViewUserPresents_CheckedChanged;
            // 
            // button_DeletePresentation
            // 
            button_DeletePresentation.Anchor = AnchorStyles.None;
            button_DeletePresentation.Location = new Point(171, 13);
            button_DeletePresentation.Name = "button_DeletePresentation";
            button_DeletePresentation.Size = new Size(126, 70);
            button_DeletePresentation.TabIndex = 1;
            button_DeletePresentation.Text = "Delete Presentation";
            button_DeletePresentation.UseVisualStyleBackColor = true;
            button_DeletePresentation.Click += button_DeletePresentation_Click;
            // 
            // button_close
            // 
            button_close.Anchor = AnchorStyles.None;
            button_close.Location = new Point(311, 13);
            button_close.Name = "button_close";
            button_close.Size = new Size(110, 70);
            button_close.TabIndex = 0;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_Presenters);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 349);
            panel1.TabIndex = 3;
            // 
            // ViewPresenters
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 449);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ViewPresenters";
            Text = "ViewPresenters";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Presenters;
        private Panel panel2;
        private Button button_close;
        private Button button_DeletePresentation;
        private CheckBox checkBox_ViewUserPresents;
        private Button button_refresh;
        private Panel panel1;
    }
}