namespace Event_Manager.PresenterItems
{
    partial class AddPresenter
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
            comboBox_Room = new ComboBox();
            label4 = new Label();
            label_Welcome = new Label();
            button_register = new Button();
            comboBox_Timeslot = new ComboBox();
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
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.Location = new Point(97, 8);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(181, 25);
            label_Welcome.TabIndex = 8;
            label_Welcome.Text = "Registering for Event ";
            // 
            // button_register
            // 
            button_register.Location = new Point(131, 233);
            button_register.Name = "button_register";
            button_register.Size = new Size(112, 34);
            button_register.TabIndex = 9;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // comboBox_Timeslot
            // 
            comboBox_Timeslot.FormattingEnabled = true;
            comboBox_Timeslot.Location = new Point(189, 168);
            comboBox_Timeslot.Name = "comboBox_Timeslot";
            comboBox_Timeslot.Size = new Size(150, 33);
            comboBox_Timeslot.TabIndex = 10;
            // 
            // AddPresenter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 279);
            Controls.Add(comboBox_Timeslot);
            Controls.Add(button_register);
            Controls.Add(label_Welcome);
            Controls.Add(label4);
            Controls.Add(comboBox_Room);
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
        private ComboBox comboBox_Room;
        private Label label4;
        private Label label_Welcome;
        private Button button_register;
        private ComboBox comboBox_Timeslot;
    }
}