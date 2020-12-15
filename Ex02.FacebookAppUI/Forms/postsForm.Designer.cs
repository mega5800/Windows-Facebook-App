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
            this.commentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.postDataBindingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(23, 36);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(23, 6);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(69, 17);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // listBoxUserPosts
            // 
            this.listBoxUserPosts.DataSource = this.postBindingSource;
            this.listBoxUserPosts.DisplayMember = "Message";
            this.listBoxUserPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxUserPosts.FormattingEnabled = true;
            this.listBoxUserPosts.ItemHeight = 16;
            this.listBoxUserPosts.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserPosts.Name = "listBoxUserPosts";
            this.listBoxUserPosts.Size = new System.Drawing.Size(539, 244);
            this.listBoxUserPosts.TabIndex = 3;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // postDataBindingPanel
            // 
            this.postDataBindingPanel.Controls.Add(this.commentsDataGridView);
            this.postDataBindingPanel.Controls.Add(createdTimeLabel);
            this.postDataBindingPanel.Controls.Add(this.createdTimeDateTimePicker);
            this.postDataBindingPanel.Controls.Add(messageLabel);
            this.postDataBindingPanel.Controls.Add(this.messageTextBox);
            this.postDataBindingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postDataBindingPanel.Location = new System.Drawing.Point(0, 258);
            this.postDataBindingPanel.Name = "postDataBindingPanel";
            this.postDataBindingPanel.Size = new System.Drawing.Size(539, 290);
            this.postDataBindingPanel.TabIndex = 4;
            // 
            // commentsDataGridView
            // 
            this.commentsDataGridView.AllowUserToAddRows = false;
            this.commentsDataGridView.AllowUserToDeleteRows = false;
            this.commentsDataGridView.AllowUserToResizeRows = false;
            this.commentsDataGridView.AutoGenerateColumns = false;
            this.commentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.commentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.commentsDataGridView.DataSource = this.commentsBindingSource;
            this.commentsDataGridView.Location = new System.Drawing.Point(26, 61);
            this.commentsDataGridView.Name = "commentsDataGridView";
            this.commentsDataGridView.ReadOnly = true;
            this.commentsDataGridView.RowHeadersVisible = false;
            this.commentsDataGridView.Size = new System.Drawing.Size(494, 220);
            this.commentsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn1.FillWeight = 133.2271F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Message";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LikesCount";
            this.dataGridViewTextBoxColumn2.FillWeight = 90.63071F;
            this.dataGridViewTextBoxColumn2.HeaderText = "LikesCount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreatedTime";
            this.dataGridViewTextBoxColumn4.FillWeight = 76.14214F;
            this.dataGridViewTextBoxColumn4.HeaderText = "CreatedTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postBindingSource;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Enabled = false;
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(126, 32);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(394, 23);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(126, 3);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(394, 23);
            this.messageTextBox.TabIndex = 3;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(539, 548);
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
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserPosts;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel postDataBindingPanel;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.DataGridView commentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}