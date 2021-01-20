using System.Collections.Generic;

namespace Ex03.FacebookAppLogic.Interfaces
{
    internal interface ISelectable<T>
    {
        List<T> SelectableObjectsList { get; set; }
        List<List<T>> SelectedObjectLists { get; set; }
    }
}