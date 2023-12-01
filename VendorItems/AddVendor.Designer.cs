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
            comboBox_Room = new ComboBox();
            label4 = new Label();
            label_Welcome = new Label();
            button_register = new Button();
            label1 = new Label();
            comboBox_Table = new ComboBox();
            SuspendLayout();
            // 
            // comboBox_Room
            // 
            comboBox_Room.FormattingEnabled = true;
            comboBox_Room.Location = new Point(151, 48);
            comboBox_Room.Margin = new Padding(2);
            comboBox_Room.Name = "comboBox_Room";
            comboBox_Room.Size = new Size(121, 28);
            comboBox_Room.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 50);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Room:";
            // 
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.Location = new Point(78, 6);
            label_Welcome.Margin = new Padding(2, 0, 2, 0);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(151, 20);
            label_Welcome.TabIndex = 8;
            label_Welcome.Text = "Registering for Event ";
            // 
            // button_register
            // 
            button_register.Location = new Point(110, 127);
            button_register.Margin = new Padding(2);
            button_register.Name = "button_register";
            button_register.Size = new Size(90, 27);
            button_register.TabIndex = 10;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 12;
            label1.Text = "Table:";
            // 
            // comboBox_Table
            // 
            comboBox_Table.FormattingEnabled = true;
            comboBox_Table.Location = new Point(151, 80);
            comboBox_Table.Margin = new Padding(2);
            comboBox_Table.Name = "comboBox_Table";
            comboBox_Table.Size = new Size(121, 28);
            comboBox_Table.TabIndex = 11;
            // 
            // AddVendor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 165);
            Controls.Add(label1);
            Controls.Add(comboBox_Table);
            Controls.Add(button_register);
            Controls.Add(label_Welcome);
            Controls.Add(label4);
            Controls.Add(comboBox_Room);
            Margin = new Padding(2);
            Name = "AddVendor";
            Text = "AddKiosk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox_Room;
        private Label label4;
        private Label label_Welcome;
        private Button button_register;
        private Label label1;
        private ComboBox comboBox_Table;
    }
}