namespace Ex02.FacebookAppUI.Forms
{
    partial class GroupsForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label nameLabel2;
            this.listBoxUserGroups = new System.Windows.Forms.ListBox();
            this.pagesDataBindingPanel = new System.Windows.Forms.Panel();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            this.pagesDataBindingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(131, 168);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(131, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(131, 241);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(70, 17);
            nameLabel1.TabIndex = 5;
            nameLabel1.Text = "Members:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(131, 95);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(53, 17);
            nameLabel2.TabIndex = 7;
            nameLabel2.Text = "Owner:";
            // 
            // listBoxUserGroups
            // 
            this.listBoxUserGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUserGroups.FormattingEnabled = true;
            this.listBoxUserGroups.ItemHeight = 16;
            this.listBoxUserGroups.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserGroups.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserGroups.Name = "listBoxUserGroups";
            this.listBoxUserGroups.Size = new System.Drawing.Size(547, 244);
            this.listBoxUserGroups.TabIndex = 3;
            // 
            // pagesDataBindingPanel
            // 
            this.pagesDataBindingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.pagesDataBindingPanel.Controls.Add(nameLabel2);
            this.pagesDataBindingPanel.Controls.Add(this.nameTextBox2);
            this.pagesDataBindingPanel.Controls.Add(nameLabel1);
            this.pagesDataBindingPanel.Controls.Add(this.nameTextBox1);
            this.pagesDataBindingPanel.Controls.Add(descriptionLabel);
            this.pagesDataBindingPanel.Controls.Add(this.descriptionTextBox);
            this.pagesDataBindingPanel.Controls.Add(this.imageNormalPictureBox);
            this.pagesDataBindingPanel.Controls.Add(nameLabel);
            this.pagesDataBindingPanel.Controls.Add(this.nameTextBox);
            this.pagesDataBindingPanel.Location = new System.Drawing.Point(12, 242);
            this.pagesDataBindingPanel.Name = "pagesDataBindingPanel";
            this.pagesDataBindingPanel.Size = new System.Drawing.Size(535, 308);
            this.pagesDataBindingPanel.TabIndex = 4;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Name", true));
            this.nameTextBox2.Location = new System.Drawing.Point(220, 92);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox2.TabIndex = 8;
            this.nameTextBox2.TextChanged += new System.EventHandler(this.nameTextBox2_TextChanged);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(220, 238);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox1.TabIndex = 6;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.groupBindingSource;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(220, 165);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 23);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(12, 9);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(220, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 5;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 550);
            this.Controls.Add(this.pagesDataBindingPanel);
            this.Controls.Add(this.listBoxUserGroups);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GroupsForm";
            this.Text = "groupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            this.pagesDataBindingPanel.ResumeLayout(false);
            this.pagesDataBindingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserGroups;
        private System.Windows.Forms.Panel pagesDataBindingPanel;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox nameTextBox2;
    }
}