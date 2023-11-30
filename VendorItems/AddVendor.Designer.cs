namespace Event_Manager.VendorItems
{
    partial class AddVendor
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
            textBox_Title = new TextBox();
            textBox_description = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_Timeslot = new TextBox();
            comboBox_Room = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(189, 99);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(150, 31);
            textBox_Title.TabIndex = 0;
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(189, 136);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(150, 31);
            textBox_description.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 102);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 2;
            label1.Text = "Presentation Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 139);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 176);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 4;
            label3.Text = "Timeslot";
            // 
            // textBox_Timeslot
            // 
            textBox_Timeslot.Location = new Point(189, 173);
            textBox_Timeslot.Name = "textBox_Timeslot";
            textBox_Timeslot.Size = new Size(150, 31);
            textBox_Timeslot.TabIndex = 5;
            // 
            // comboBox_Room
            // 
            comboBox_Room.FormattingEnabled = true;
            comboBox_Room.Location = new Point(189, 60);
            comboBox_Room.Name = "comboBox_Room";
            comboBox_Room.Size = new Size(150, 33);
            comboBox_Room.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 63);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 7;
            label4.Text = "Room:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 8);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 8;
            label5.Text = "Registering for Event ";
            // 
            // AddPresenter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 231);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox_Room);
            Controls.Add(textBox_Timeslot);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_description);
            Controls.Add(textBox_Title);
            Name = "AddPresenter";
            Text = "AddPresenter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Title;
        private TextBox textBox_description;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Timeslot;
        private ComboBox comboBox_Room;
        private Label label4;
        private Label label5;
    }
}