using Ex03.FacebookAppLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.FacebookAppLogic.Classes
{
    internal class Selector<T> where T : class
    {
        public Func<T, bool> SelectedItemsAreTheSameStrategyMethod { get; set; }

        public Func<T, bool> TwoItemsAreConnectedStrategyMethod { get; set; }

        public T ChosenObjectFirstDegree { get; private set; }

        public T ChosenObjectSecondDegree { get; private set; }

        public void PickFirstDegreeAndSecondDegreeObjects(ISelectable<T> i_ISelectableObject, ref T io_FirstChosenObject, ref T io_SecondChosenObject)
        {
            bool isSecondDegreeRandomObjectSelected = false;

            io_SecondChosenObject = null;
            foreach (T selectableObject in i_ISelectableObject.SelectableObjectsList)
            {
                io_FirstChosenObject = selectableObject;
                foreach (List<T> selectedObjectList in i_ISelectableObject.SelectedObjectLists)
                {
                    foreach (T selectedObject in selectedObjectList)
                    {
                        if (!this.SelectedItemsAreTheSameStrategyMethod(selectedObject))
                        {
                            //if (!this.TwoItemsAreConnectedStrategyMethod(selectedObject))
                            //{
                                io_SecondChosenObject = selectedObject;
                                isSecondDegreeRandomObjectSelected = true;
                                break;
                            //}
                        }
                    }

                    if (isSecondDegreeRandomObjectSelected)
                    {
                        break;
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