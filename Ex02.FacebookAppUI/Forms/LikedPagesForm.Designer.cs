namespace Ex02.FacebookAppUI.Forms
{
    partial class LikedPagesForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label nameLabel;
            this.listBoxUserLikedPages = new System.Windows.Forms.ListBox();
            this.pageDataBindingPanel = new System.Windows.Forms.Panel();
            this.postsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.pageDataBindingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(109, 77);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(109, 44);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(109, 111);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(86, 17);
            likesCountLabel.TabIndex = 6;
            likesCountLabel.Text = "Likes Count:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(109, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // listBoxUserLikedPages
            // 
            this.listBoxUserLikedPages.DisplayMember = "Name";
            this.listBoxUserLikedPages.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxUserLikedPages.FormattingEnabled = true;
            this.listBoxUserLikedPages.ItemHeight = 16;
            this.listBoxUserLikedPages.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserLikedPages.Name = "listBoxUserLikedPages";
            this.listBoxUserLikedPages.Size = new System.Drawing.Size(539, 228);
            this.listBoxUserLikedPages.TabIndex = 3;
            // 
            // pageDataBindingPanel
            // 
            this.pageDataBindingPanel.Controls.Add(this.postsDataGridView);
            this.pageDataBindingPanel.Controls.Add(categoryLabel);
            this.pageDataBindingPanel.Controls.Add(this.categoryTextBox);
            this.pageDataBindingPanel.Controls.Add(descriptionLabel);
            this.pageDataBindingPanel.Controls.Add(this.descriptionTextBox);
            this.pageDataBindingPanel.Controls.Add(this.imageNormalPictureBox);
            this.pageDataBindingPanel.Controls.Add(likesCountLabel);
            this.pageDataBindingPanel.Controls.Add(this.likesCountTextBox);
            this.pageDataBindingPanel.Controls.Add(nameLabel);
            this.pageDataBindingPanel.Controls.Add(this.nameTextBox);
            this.pageDataBindingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageDataBindingPanel.Location = new System.Drawing.Point(0, 228);
            this.pageDataBindingPanel.Name = "pageDataBindingPanel";
            this.pageDataBindingPanel.Size = new System.Drawing.Size(539, 320);
            this.pageDataBindingPanel.TabIndex = 4;
            // 
            // postsDataGridView
            // 
            this.postsDataGridView.AllowUserToAddRows = false;
            this.postsDataGridView.AllowUserToDeleteRows = false;
            this.postsDataGridView.AutoGenerateColumns = false;
            this.postsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn14});
            this.postsDataGridView.DataSource = this.postsBindingSource;
            this.postsDataGridView.Location = new System.Drawing.Point(3, 143);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.ReadOnly = true;
            this.postsDataGridView.RowHeadersVisible = false;
            this.postsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.postsDataGridView.Size = new System.Drawing.Size(533, 174);
            this.postsDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn1.HeaderText = "Message";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CreatedTime";
            this.dataGridViewTextBoxColumn14.HeaderText = "CreatedTime";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.pageBindingSource;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(214, 74);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(178, 23);
            this.categoryTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(214, 41);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(178, 23);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(214, 108);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.likesCountTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(214, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(178, 23);
            this.nameTextBox.TabIndex = 9;
            // 
            // LikedPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 548);
            this.Controls.Add(this.pageDataBindingPanel);
            this.Controls.Add(this.listBoxUserLikedPages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LikedPagesForm";
            this.Text = "likedPagesForm";
            this.pageDataBindingPanel.ResumeLayout(false);
            this.pageDataBindingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserLikedPages;
        private System.Windows.Forms.Panel pageDataBindingPanel;
        private System.Windows.Forms.DataGridView postsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox likesCountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}