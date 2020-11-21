using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppLogic.Structs;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class StatisticsForm : Form
    {
        private User m_LoggedInUser;
        private readonly List<LocationCounter> r_LocationCountersList;
        //private 

        public StatisticsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_LocationCountersList = new List<LocationCounter>();
        }

        private void StatisticsForm_Load(object sender, System.EventArgs e)
        {
            foreach (Checkin checkin in this.m_LoggedInUser.Checkins)
            {
                if (checkIfLocationIsNotInLocationCountersList(checkin))
                {
                    this.r_LocationCountersList.Add(new LocationCounter(checkin.Place.Location.Country));
                }
            }

            int i = 0;
            this.statisticsPieChart.Titles.Add("Pie chart");
            foreach (LocationCounter locationCounter in this.r_LocationCountersList)
            {
                this.statisticsPieChart.Series["statisticsPieChartInfo"].Points.AddXY(locationCounter.LocationName+" - "+ locationCounter.Counter, locationCounter.Counter);
                this.statisticsPieChart.Series["statisticsPieChartInfo"].Points[i].LegendText = locationCounter.LocationName;
                i++;
            }
        }

        private bool checkIfLocationIsNotInLocationCountersList(Checkin i_CheckinToCheck)
        {
            bool result = true;

            foreach (LocationCounter locationCounter in this.r_LocationCountersList)
            {
                if (locationCounter.LocationName == i_CheckinToCheck.Place.Location.Country)
                {
                    result = false;
                    locationCounter.Counter++;
                    break;
                }
            }

            return result;
        }
    }
}