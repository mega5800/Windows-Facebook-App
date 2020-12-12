using System.Collections.Generic;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppLogic.Classes
{
    public delegate R Func<T, T1, R>(T i_ItemToCheck, ref T1 io_UniqueItem);

    public sealed class PieChartDataProcessor<T>
    {
        // ATTRIBUTES
        private readonly FacebookObjectCollection<T> r_FacebookObjectCollection;
        private readonly List<PropertyCounter> r_PropertyCounterList;
        private Loader<T> m_PieChartLoader;

        public event Func<T, string, bool> DuplicatePropertyCheckingMethodIsNeeded;

        // CTOR
        public PieChartDataProcessor(List<object> i_ParamsList)
        {
            this.r_FacebookObjectCollection = i_ParamsList[0] as FacebookObjectCollection<T>;
            this.r_PropertyCounterList = i_ParamsList[1] as List<PropertyCounter>;
            this.m_PieChartLoader = LoaderFactory<T>.CreateLoader(eLoaderFactoryContext.CreatePieChartLoader, i_ParamsList);
        }

        // PUBLIC METHODS
        public bool LoadDataIntoPieChart()
        {
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

                // since we're using PropertyCounter list we dont have to retrieve data using reflection on given property name
                // that's why we'll send null as property name
                this.m_PieChartLoader.LoadProperties(null);
            }
            else
            {
                isLoadingDataSucceeded = false;
            }

            return isLoadingDataSucceeded;
        }
    }
}