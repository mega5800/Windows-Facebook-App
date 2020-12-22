using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ex02.FacebookAppUI.Interfaces
{
    public interface ILoaderAdapter<T>
    {
        Loader<T> FormToLoaderAdapt(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, ListView i_ListView);

        Loader<T> FormToLoaderAdapt(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList, Chart i_PieChart ,string i_PieChartTitle, string i_PieChartID);
    }
}