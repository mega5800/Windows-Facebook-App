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
            this.listBoxUserGroups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

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
            this.listBoxUserGroups.Size = new System.Drawing.Size(435, 420);
            this.listBoxUserGroups.TabIndex = 3;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 406);
            this.Controls.Add(this.listBoxUserGroups);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GroupsForm";
            this.Text = "groupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserGroups;
    }
}