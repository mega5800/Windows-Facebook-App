using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Interfaces;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Classes
{
    public class LoaderAdapter<T> : ILoaderAdapter<T>
    {
        private readonly List<object> r_ParamsList;

        public LoaderAdapter()
        {
            this.r_ParamsList = new List<object>();
        }

        Loader<T> ILoaderAdapter<T>.FormToLoaderAdapt(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, ListView i_ListView)
        {
            this.r_ParamsList.Add(i_FacebookObjectCollection);
            this.r_ParamsList.Add(i_ListView);
            return LoaderFactory<T>.CreateLoader(i_LoaderFactoryContext, this.r_ParamsList);
        }

        Loader<T> ILoaderAdapter<T>.FormToLoaderAdapt(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList, Chart i_PieChart, string i_PieChartTitle, string i_PieChartID)
        {
            this.r_ParamsList.Add(i_FacebookObjectCollection);
            this.r_ParamsList.Add(i_PropertyCounterList);
            this.r_ParamsList.Add(i_PieChart);
            this.r_ParamsList.Add(i_PieChartTitle);
            this.r_ParamsList.Add(i_PieChartID);
            return LoaderFactory<T>.CreateLoader(i_LoaderFactoryContext, this.r_ParamsList);
        }
    }
}