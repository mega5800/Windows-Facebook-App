using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ex01.FacebookAppLogic.Classes
{
    public delegate R Func<T, T1, R>(T i_ItemToCheck, ref T1 io_UniqueItem);

    public sealed class PieChartDataLoadingComponent<T>
    {
        private Chart m_PieChart;
        private string m_PieChartTitle;
        private string m_PieChartId;
        private readonly FacebookObjectCollection<T> r_FacebookObjectCollection;
        private readonly List<PropertyCounter> r_PropertyCounterList;
        public event Func<T, string, bool> DuplicatePropertyCheckingMethodIsNeeded;

        public PieChartDataLoadingComponent(Chart i_PieChartToLoad, FacebookObjectCollection<T> i_FacebookObjectCollection,
            string i_PieChartTitle, List<PropertyCounter> i_PropertyCounterList, string i_PieChartId)
        {
            this.m_PieChart = i_PieChartToLoad;
            this.m_PieChartId = i_PieChartId;
            this.m_PieChartTitle = i_PieChartTitle;
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.r_PropertyCounterList = i_PropertyCounterList;
        }

        public bool LoadDataIntoPieChart()
        {
            int i = 0;
            bool checkingMethodResult, isLoadingDataSucceeded = true;
            string propertyNameAndCounterStringFormat = string.Empty, uniquePropertyString = string.Empty;
            if (this.r_FacebookObjectCollection.Count > 0)
            {
                foreach (T item in this.r_FacebookObjectCollection)
                {
                    checkingMethodResult = this.DuplicatePropertyCheckingMethodIsNeeded(item, ref uniquePropertyString);
                    if (checkingMethodResult)
                    {
                        this.r_PropertyCounterList.Add(new PropertyCounter(uniquePropertyString));
                    }
                }

                this.m_PieChart.Titles.Add(this.m_PieChartTitle);
                foreach (PropertyCounter locationCounter in this.r_PropertyCounterList)
                {
                    propertyNameAndCounterStringFormat = string.Format("{0} - {1}", locationCounter.PropertyName, locationCounter.Counter);
                    this.m_PieChart.Series[this.m_PieChartId].Points.AddXY(propertyNameAndCounterStringFormat, locationCounter.Counter);
                    this.m_PieChart.Series[this.m_PieChartId].Points[i].LegendText = locationCounter.PropertyName;
                    i++;
                }
            }
            else
            {
                isLoadingDataSucceeded = false;
            }

            return isLoadingDataSucceeded;
        }
    }
}