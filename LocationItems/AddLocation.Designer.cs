namespace Event_Manager.LocationItems
{
    partial class AddLocation
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
            panel1 = new Panel();
            button_Cancel = new Button();
            button_AddEvent = new Button();
            textBox_fee = new TextBox();
            textBox_address = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_name = new TextBox();
            textBox_website = new TextBox();
            textBox_email = new TextBox();
            label7 = new Label();
            textBox_vendorCapacity = new TextBox();
            label5 = new Label();
            textBox_AttendeeCapacity = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button_Cancel);
            panel1.Controls.Add(button_AddEvent);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 69);
            panel1.TabIndex = 27;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(205, 4);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(112, 58);
            button_Cancel.TabIndex = 13;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_AddEvent
            // 
            button_AddEvent.Location = new Point(87, 4);
            button_AddEvent.Name = "button_AddEvent";
            button_AddEvent.Size = new Size(112, 58);
            button_AddEvent.TabIndex = 12;
            button_AddEvent.Text = "Add Location";
            button_AddEvent.UseVisualStyleBackColor = true;
            button_AddEvent.Click += button_AddEvent_Click;
            // 
            // textBox_fee
            // 
            textBox_fee.Location = new Point(129, 286);
            textBox_fee.Name = "textBox_fee";
            textBox_fee.Size = new Size(150, 31);
            textBox_fee.TabIndex = 23;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(129, 38);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(150, 31);
            textBox_address.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 320);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 21;
            label6.Text = "Vendor Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 196);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 19;
            label4.Text = "Contact Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 134);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 18;
            label3.Text = "Location Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 72);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 17;
            label2.Text = "Location Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 10);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 16;
            label1.Text = "Location Address";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(129, 100);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(150, 31);
            textBox_name.TabIndex = 29;
            // 
            // textBox_website
            // 
            textBox_website.Location = new Point(129, 162);
            textBox_website.Name = "textBox_website";
            textBox_website.Size = new Size(150, 31);
            textBox_website.TabIndex = 30;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(129, 224);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(150, 31);
            textBox_email.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(113, 258);
            label7.Name = "label7";
            label7.Size = new Size(182, 25);
            label7.TabIndex = 32;
            label7.Text = "Rental Fee ($ Per Day)";
            // 
            // textBox_vendorCapacity
            // 
            textBox_vendorCapacity.Location = new Point(129, 348);
            textBox_vendorCapacity.Name = "textBox_vendorCapacity";
            textBox_vendorCapacity.Size = new Size(150, 31);
            textBox_vendorCapacity.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 382);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 34;
            label5.Text = "Attendee Capacity";
            // 
            // textBox_AttendeeCapacity
            // 
            textBox_AttendeeCapacity.Location = new Point(129, 410);
            textBox_AttendeeCapacity.Name = "textBox_AttendeeCapacity";
            textBox_AttendeeCapacity.Size = new Size(150, 31);
            textBox_AttendeeCapacity.TabIndex = 35;
            // 
            // AddLocation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 516);
            Controls.Add(textBox_AttendeeCapacity);
            Controls.Add(label5);
            Controls.Add(textBox_vendorCapacity);
            Controls.Add(label7);
            Controls.Add(textBox_email);
            Controls.Add(textBox_website);
            Controls.Add(textBox_name);
            Controls.Add(panel1);
            Controls.Add(textBox_fee);
            Controls.Add(textBox_address);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddLocation";
            Text = "AddLocation";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_Cancel;
        private Button button_AddEvent;
        private TextBox textBox_fee;
        private TextBox textBox_address;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_name;
        private TextBox textBox_website;
        private TextBox textBox_email;
        private Label label7;
        private TextBox textBox_vendorCapacity;
        private Label label5;
        private TextBox textBox_AttendeeCapacity;
    }
}