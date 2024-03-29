﻿namespace Event_Manager.HostItems
{
    partial class AddEvent
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
            comboBox_Locations = new ComboBox();
            locationBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_Name = new TextBox();
            textBox_Website = new TextBox();
            richTextBox_Description = new RichTextBox();
            dateTimePicker_Start = new DateTimePicker();
            dateTimePicker_End = new DateTimePicker();
            button_AddEvent = new Button();
            button_Cancel = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_Locations
            // 
            comboBox_Locations.DataSource = locationBindingSource;
            comboBox_Locations.DisplayMember = "Name";
            comboBox_Locations.FormattingEnabled = true;
            comboBox_Locations.Location = new Point(90, 303);
            comboBox_Locations.Margin = new Padding(2, 2, 2, 2);
            comboBox_Locations.Name = "comboBox_Locations";
            comboBox_Locations.Size = new Size(146, 28);
            comboBox_Locations.TabIndex = 0;
            // 
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 2;
            label2.Text = "Event Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 182);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 231);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Website";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 281);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 6;
            label6.Text = "Location";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(103, 38);
            textBox_Name.Margin = new Padding(2, 2, 2, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 27);
            textBox_Name.TabIndex = 7;
            // 
            // textBox_Website
            // 
            textBox_Website.Location = new Point(103, 254);
            textBox_Website.Margin = new Padding(2, 2, 2, 2);
            textBox_Website.Name = "textBox_Website";
            textBox_Website.Size = new Size(121, 27);
            textBox_Website.TabIndex = 8;
            // 
            // richTextBox_Description
            // 
            richTextBox_Description.Location = new Point(62, 88);
            richTextBox_Description.Margin = new Padding(2, 2, 2, 2);
            richTextBox_Description.Name = "richTextBox_Description";
            richTextBox_Description.Size = new Size(202, 42);
            richTextBox_Description.TabIndex = 9;
            richTextBox_Description.Text = "";
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.Location = new Point(43, 154);
            dateTimePicker_Start.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker_Start.Name = "dateTimePicker_Start";
            dateTimePicker_Start.Size = new Size(241, 27);
            dateTimePicker_Start.TabIndex = 10;
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.Location = new Point(43, 204);
            dateTimePicker_End.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker_End.Name = "dateTimePicker_End";
            dateTimePicker_End.Size = new Size(241, 27);
            dateTimePicker_End.TabIndex = 11;
            // 
            // button_AddEvent
            // 
            button_AddEvent.Location = new Point(70, 3);
            button_AddEvent.Margin = new Padding(2, 2, 2, 2);
            button_AddEvent.Name = "button_AddEvent";
            button_AddEvent.Size = new Size(90, 37);
            button_AddEvent.TabIndex = 12;
            button_AddEvent.Text = "Add Event";
            button_AddEvent.UseVisualStyleBackColor = true;
            button_AddEvent.Click += button_AddEvent_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(164, 3);
            button_Cancel.Margin = new Padding(2, 2, 2, 2);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(90, 37);
            button_Cancel.TabIndex = 13;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_Cancel);
            panel1.Controls.Add(button_AddEvent);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 334);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 47);
            panel1.TabIndex = 14;
            // 
            // AddEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 381);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker_End);
            Controls.Add(dateTimePicker_Start);
            Controls.Add(richTextBox_Description);
            Controls.Add(textBox_Website);
            Controls.Add(textBox_Name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Locations);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "AddEvent";
            Text = "AddEvent";
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Locations;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private BindingSource locationBindingSource;
        private TextBox textBox_Name;
        private TextBox textBox_Website;
        private RichTextBox richTextBox_Description;
        private DateTimePicker dateTimePicker_Start;
        private DateTimePicker dateTimePicker_End;
        private Button button_AddEvent;
        private Button button_Cancel;
        private Panel panel1;
    }
}