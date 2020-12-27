using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Ex02.FacebookAppLogic.Classes;

namespace Ex02.FacebookAppUI.Loaders
{
    public sealed class PieChartLoader<T> : Loader<T>
    {
        // ATTRIBUTES
        private readonly List<PropertyCounter> r_PropertyCounterList;
        private Chart m_PieChart;
        private string m_PieChartTitle;
        private string m_PieChartId;

        // CTOR
        public PieChartLoader(List<object> i_ParamsList) : base(i_ParamsList[0])
        {
            this.r_PropertyCounterList = i_ParamsList[1] as List<PropertyCounter>;
            this.m_PieChart = i_ParamsList[2] as Chart;
            this.m_PieChartTitle = i_ParamsList[3] as string;
            this.m_PieChartId = i_ParamsList[4] as string;
        }

        // PROTECTED METHODS
        protected internal override void LoadProperties(params string[] i_PropertiesArray)
        {
            int i = 0;
            string propertyNameAndCounterStringFormat = string.Empty;

            this.m_PieChart.Invoke(new Action(() => this.m_PieChart.Titles.Add(this.m_PieChartTitle)));
            foreach (PropertyCounter locationCounter in this.r_PropertyCounterList)
            {
                if (locationCounter.Counter != 0)
                {
                    this.m_PieChart.Invoke(new Action(() =>
                        {
                            propertyNameAndCounterStringFormat = string.Format("{0} - {1}", locationCounter.PropertyName, locationCounter.Counter);
                            this.m_PieChart.Series[this.m_PieChartId].Points.AddXY(propertyNameAndCounterStringFormat, locationCounter.Counter);
                            this.m_PieChart.Series[this.m_PieChartId].Points[i].LegendText = locationCounter.PropertyName;
                            i++;
                        }));
                }
            }
        }
    }
}