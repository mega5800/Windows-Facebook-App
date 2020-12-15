namespace Ex02.FacebookAppUI.Forms
{
    partial class EventsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label attendingCountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label nameLabel2;
            this.listBoxUserEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsDataBindingPanel = new System.Windows.Forms.Panel();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.attendingCountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            attendingCountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.eventsDataBindingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attendingCountLabel
            // 
            attendingCountLabel.AutoSize = true;
            attendingCountLabel.Location = new System.Drawing.Point(124, 260);
            attendingCountLabel.Name = "attendingCountLabel";
            attendingCountLabel.Size = new System.Drawing.Size(113, 17);
            attendingCountLabel.TabIndex = 0;
            attendingCountLabel.Text = "Attending Count:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(124, 177);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(124, 93);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(72, 17);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "End Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(124, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(87, 17);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Event name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(124, 55);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(77, 17);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(124, 218);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(92, 17);
            nameLabel1.TabIndex = 14;
            nameLabel1.Text = "Owner name:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(124, 134);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(66, 17);
            nameLabel2.TabIndex = 16;
            nameLabel2.Text = "Location:";
            // 
            // listBoxUserEvents
            // 
            this.listBoxUserEvents.DataSource = this.eventBindingSource;
            this.listBoxUserEvents.DisplayMember = "Name";
            this.listBoxUserEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxUserEvents.FormattingEnabled = true;
            this.listBoxUserEvents.ItemHeight = 16;
            this.listBoxUserEvents.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserEvents.Name = "listBoxUserEvents";
            this.listBoxUserEvents.Size = new System.Drawing.Size(539, 244);
            this.listBoxUserEvents.TabIndex = 3;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // eventsDataBindingPanel
            // 
            this.eventsDataBindingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.eventsDataBindingPanel.Controls.Add(nameLabel2);
            this.eventsDataBindingPanel.Controls.Add(this.nameTextBox2);
            this.eventsDataBindingPanel.Controls.Add(this.imageNormalPictureBox);
            this.eventsDataBindingPanel.Controls.Add(nameLabel1);
            this.eventsDataBindingPanel.Controls.Add(this.nameTextBox1);
            this.eventsDataBindingPanel.Controls.Add(attendingCountLabel);
            this.eventsDataBindingPanel.Controls.Add(this.attendingCountTextBox);
            this.eventsDataBindingPanel.Controls.Add(descriptionLabel);
            this.eventsDataBindingPanel.Controls.Add(this.descriptionTextBox);
            this.eventsDataBindingPanel.Controls.Add(endTimeLabel);
            this.eventsDataBindingPanel.Controls.Add(this.endTimeDateTimePicker);
            this.eventsDataBindingPanel.Controls.Add(nameLabel);
            this.eventsDataBindingPanel.Controls.Add(this.nameTextBox);
            this.eventsDataBindingPanel.Controls.Add(startTimeLabel);
            this.eventsDataBindingPanel.Controls.Add(this.startTimeDateTimePicker);
            this.eventsDataBindingPanel.Location = new System.Drawing.Point(13, 244);
            this.eventsDataBindingPanel.Name = "eventsDataBindingPanel";
            this.eventsDataBindingPanel.Size = new System.Drawing.Size(515, 282);
            this.eventsDataBindingPanel.TabIndex = 4;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Place.Name", true));
            this.nameTextBox2.Location = new System.Drawing.Point(243, 128);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox2.TabIndex = 17;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(15, 10);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.TabIndex = 16;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner.Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(243, 212);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox1.TabIndex = 15;
            // 
            // attendingCountTextBox
            // 
            this.attendingCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
            this.attendingCountTextBox.Location = new System.Drawing.Point(243, 254);
            this.attendingCountTextBox.Name = "attendingCountTextBox";
            this.attendingCountTextBox.Size = new System.Drawing.Size(41, 23);
            this.attendingCountTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(243, 171);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 23);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Enabled = false;
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(243, 87);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.endTimeDateTimePicker.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(243, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox.TabIndex = 11;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.startTimeDateTimePicker.Enabled = false;
            this.startTimeDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(243, 49);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.startTimeDateTimePicker.TabIndex = 13;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 548);
            this.Controls.Add(this.eventsDataBindingPanel);
            this.Controls.Add(this.listBoxUserEvents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventsForm";
            this.Text = "eventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.eventsDataBindingPanel.ResumeLayout(false);
            this.eventsDataBindingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserEvents;
        private System.Windows.Forms.Panel eventsDataBindingPanel;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox attendingCountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox nameTextBox2;
    }
}