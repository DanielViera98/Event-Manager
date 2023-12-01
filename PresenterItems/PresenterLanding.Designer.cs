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
            eventBindingSource = new BindingSource(components);
            panel1 = new Panel();
            button_ShowPresenters = new Button();
            button_Cancel = new Button();
            button_register = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Presenters
            // 
            dataGridView_Presenters.AllowUserToAddRows = false;
            dataGridView_Presenters.AllowUserToDeleteRows = false;
            dataGridView_Presenters.AllowUserToResizeColumns = false;
            dataGridView_Presenters.AllowUserToResizeRows = false;
            dataGridView_Presenters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Presenters.Dock = DockStyle.Top;
            dataGridView_Presenters.Location = new Point(0, 0);
            dataGridView_Presenters.Name = "dataGridView_Presenters";
            dataGridView_Presenters.ReadOnly = true;
            dataGridView_Presenters.RowHeadersWidth = 62;
            dataGridView_Presenters.RowTemplate.Height = 33;
            dataGridView_Presenters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Presenters.Size = new Size(800, 317);
            dataGridView_Presenters.TabIndex = 0;
            dataGridView_Presenters.DataError += dataGridView_Presenters_DataError;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Event);
            // 
            // panel1
            // 
            panel1.Controls.Add(button_ShowPresenters);
            panel1.Controls.Add(button_Cancel);
            panel1.Controls.Add(button_register);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 133);
            panel1.TabIndex = 1;
            // 
            // button_ShowPresenters
            // 
            button_ShowPresenters.Location = new Point(179, 31);
            button_ShowPresenters.Name = "button_ShowPresenters";
            button_ShowPresenters.Size = new Size(160, 70);
            button_ShowPresenters.TabIndex = 3;
            button_ShowPresenters.Text = "Show Presenters for Event";
            button_ShowPresenters.UseVisualStyleBackColor = true;
            button_ShowPresenters.Click += button_ShowPresenters_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(461, 31);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(110, 70);
            button_Cancel.TabIndex = 2;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(345, 31);
            button_register.Name = "button_register";
            button_register.Size = new Size(110, 70);
            button_register.TabIndex = 1;
            button_register.Text = "Register For Event";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
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
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Presenters;
        private Panel panel1;
        private Button button_addPresenter;
        private Button button_register;
        private BindingSource eventBindingSource;
        private Button button_Cancel;
        private Button button_ShowPresenters;
    }
}