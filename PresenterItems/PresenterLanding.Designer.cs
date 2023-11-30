﻿namespace Event_Manager.PresenterItems
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
            dataGridView_Presenters = new DataGridView();
            panel1 = new Panel();
            button_register = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Presenters).BeginInit();
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
            // 
            // panel1
            // 
            panel1.Controls.Add(button_register);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 133);
            panel1.TabIndex = 1;
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Presenters;
        private Panel panel1;
        private Button button_addPresenter;
        private Button button_register;
    }
}