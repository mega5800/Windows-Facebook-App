namespace Ex02.FacebookAppUI.Forms
{
    partial class PostsForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            this.listBoxUserPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postDataBindingPanel = new System.Windows.Forms.Panel();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.postDataBindingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUserPosts
            // 
            this.listBoxUserPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUserPosts.DataSource = this.postBindingSource;
            this.listBoxUserPosts.DisplayMember = "Message";
            this.listBoxUserPosts.FormattingEnabled = true;
            this.listBoxUserPosts.ItemHeight = 16;
            this.listBoxUserPosts.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserPosts.Name = "listBoxUserPosts";
            this.listBoxUserPosts.Size = new System.Drawing.Size(483, 356);
            this.listBoxUserPosts.TabIndex = 3;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // postDataBindingPanel
            // 
            this.postDataBindingPanel.Controls.Add(createdTimeLabel);
            this.postDataBindingPanel.Controls.Add(this.createdTimeDateTimePicker);
            this.postDataBindingPanel.Controls.Add(messageLabel);
            this.postDataBindingPanel.Controls.Add(this.messageTextBox);
            this.postDataBindingPanel.Location = new System.Drawing.Point(0, 357);
            this.postDataBindingPanel.Name = "postDataBindingPanel";
            this.postDataBindingPanel.Size = new System.Drawing.Size(483, 182);
            this.postDataBindingPanel.TabIndex = 4;
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(100, 51);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(203, 47);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(100, 79);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(69, 17);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(203, 76);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 23);
            this.messageTextBox.TabIndex = 3;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 539);
            this.Controls.Add(this.postDataBindingPanel);
            this.Controls.Add(this.listBoxUserPosts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostsForm";
            this.Text = "postsForm";
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.postDataBindingPanel.ResumeLayout(false);
            this.postDataBindingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserPosts;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel postDataBindingPanel;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}