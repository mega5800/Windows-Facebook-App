using FacebookWrapper.ObjectModel;
using System.Reflection;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Classes
{
    public sealed class TextLoader<T>
    {
        private readonly FacebookObjectCollection<T> r_FacebookObjectCollection;
        private ListBox m_ListBox;
        private PropertyInfo m_PropertyInfo;
        private object m_PropertyInfoObject;

        public TextLoader(FacebookObjectCollection<T> i_FacebookObjectCollection, ListBox i_ListBox)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.m_ListBox = i_ListBox;
        }

        public void LoadTextProperty(string i_TextProperty)
        {
            foreach (T item in this.r_FacebookObjectCollection)
            {
                setReflectionResultIntoPropertyInfoObject(item, i_TextProperty);
                this.m_ListBox.Items.Add((string)this.m_PropertyInfoObject);
            }
        }

        private void setReflectionResultIntoPropertyInfoObject(T i_Item, string i_PropertyName)
        {
            this.m_PropertyInfo = i_Item.GetType().GetProperty(i_PropertyName);
            this.m_PropertyInfoObject = this.m_PropertyInfo.GetValue(i_Item, null);
        }
    }
}