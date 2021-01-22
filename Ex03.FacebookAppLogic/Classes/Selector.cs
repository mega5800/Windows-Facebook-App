using System;
using Ex03.FacebookAppLogic.Interfaces;

namespace Ex03.FacebookAppLogic.Classes
{
    internal sealed class Selector<T> where T : class
    {
        // ATTRIBUTES
        public Func<T, bool> SelectedItemsAreTheSameStrategyMethod { get; set; }

        public Func<T, bool> TwoItemsAreConnectedStrategyMethod { get; set; }

        public T ChosenObjectFirstDegree { get; private set; }

        public T ChosenObjectSecondDegree { get; private set; }

        // PUBLIC METHODS
        public void PickFirstDegreeAndSecondDegreeObjects(ISelectable<T> i_ISelectableObject, ref T io_FirstChosenObject, ref T io_SecondChosenObject)
        {
            bool isSecondDegreeRandomObjectSelected = false;
            io_SecondChosenObject = null;

            for (int i = 0; i < i_ISelectableObject.SelectableObjectsList.Count; i++)
            {
                io_FirstChosenObject = i_ISelectableObject.SelectableObjectsList[i];
                for (int n = 0; n < i_ISelectableObject.SelectedObjectLists[i].Count; n++)
                {
                    if (!this.SelectedItemsAreTheSameStrategyMethod(i_ISelectableObject.SelectedObjectLists[i][n]))
                    {
                        if (!this.TwoItemsAreConnectedStrategyMethod(i_ISelectableObject.SelectedObjectLists[i][n]))
                        {
                            io_SecondChosenObject = i_ISelectableObject.SelectedObjectLists[i][n];
                            isSecondDegreeRandomObjectSelected = true;
                            break;
                        }
                    }
                }

                if (isSecondDegreeRandomObjectSelected)
                {
                    break;
                }
            }
        }
    }
}