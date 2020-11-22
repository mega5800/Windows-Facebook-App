namespace Ex01.FacebookAppUI.Forms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.locationPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.checkinTab = new System.Windows.Forms.TabPage();
            this.friendsTab = new System.Windows.Forms.TabPage();
            this.friendsTaggedInPostsPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.locationPieChart)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.checkinTab.SuspendLayout();
            this.friendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsTaggedInPostsPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // locationPieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.locationPieChart.ChartAreas.Add(chartArea1);
            this.locationPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.locationPieChart.Legends.Add(legend1);
            this.locationPieChart.Location = new System.Drawing.Point(0, 0);
            this.locationPieChart.Name = "locationPieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "locationPieChartInfo";
            this.locationPieChart.Series.Add(series1);
            this.locationPieChart.Size = new System.Drawing.Size(792, 424);
            this.locationPieChart.TabIndex = 0;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.checkinTab);
            this.tabPanel.Controls.Add(this.friendsTab);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(800, 450);
            this.tabPanel.TabIndex = 0;
            // 
            // checkinTab
            // 
            this.checkinTab.Controls.Add(this.locationPieChart);
            this.checkinTab.Location = new System.Drawing.Point(4, 22);
            this.checkinTab.Name = "checkinTab";
            this.checkinTab.Size = new System.Drawing.Size(792, 424);
            this.checkinTab.TabIndex = 0;
            this.checkinTab.Text = "Checkins";
            this.checkinTab.UseVisualStyleBackColor = true;
            // 
            // friendsTab
            // 
            this.friendsTab.Controls.Add(this.friendsTaggedInPostsPieChart);
            this.friendsTab.Location = new System.Drawing.Point(4, 22);
            this.friendsTab.Name = "friendsTab";
            this.friendsTab.Size = new System.Drawing.Size(792, 424);
            this.friendsTab.TabIndex = 0;
            this.friendsTab.Text = "Friends";
            this.friendsTab.UseVisualStyleBackColor = true;
            // 
            // friendsTaggedInPostsPieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.friendsTaggedInPostsPieChart.ChartAreas.Add(chartArea2);
            this.friendsTaggedInPostsPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.friendsTaggedInPostsPieChart.Legends.Add(legend2);
            this.friendsTaggedInPostsPieChart.Location = new System.Drawing.Point(0, 0);
            this.friendsTaggedInPostsPieChart.Name = "friendsTaggedInPostsPieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "friendsTaggedInPostsPieChartInfo";
            this.friendsTaggedInPostsPieChart.Series.Add(series2);
            this.friendsTaggedInPostsPieChart.Size = new System.Drawing.Size(792, 424);
            this.friendsTaggedInPostsPieChart.TabIndex = 0;
            this.friendsTaggedInPostsPieChart.Text = "chart1";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPanel);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationPieChart)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.checkinTab.ResumeLayout(false);
            this.friendsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendsTaggedInPostsPieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart locationPieChart;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage checkinTab;
        private System.Windows.Forms.TabPage friendsTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart friendsTaggedInPostsPieChart;
    }
}