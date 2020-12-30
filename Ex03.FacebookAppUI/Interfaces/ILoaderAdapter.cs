using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Enums;
using Ex03.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Interfaces
{
    public interface ILoaderAdapter<T>
    {
        Loader<T> FormToLoaderAdapt(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, ListView i_ListView);

        Loader<T> FormToLoaderAdapt(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList, Chart i_PieChart, string i_PieChartTitle, string i_PieChartID);
    }
}