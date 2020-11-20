using FacebookWrapper.ObjectModel;
using System.Reflection;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Classes
{
    public sealed class TextLoader<T>
    {
        // ATTRIBUTES
        private readonly FacebookObjectCollection<T> r_FacebookObjectCollection;
        private ListBox m_ListBox;
        private PropertyInfo[] m_PropertyInfoArray;
        private object[] m_PropertyInfoObjectArray;
        private readonly string r_StringFormat;

        // CTOR
        public TextLoader(FacebookObjectCollection<T> i_FacebookObjectCollection, ListBox i_ListBox, string i_StringFormat)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.m_ListBox = i_ListBox;
            this.r_StringFormat = i_StringFormat;
        }

        // PUBLIC METHODS
        public void LoadTextProperty(params string[] i_TextPropertiesArray)
        {
            definePropertyInfoAndObjectArrays(i_TextPropertiesArray);
            foreach (T item in this.r_FacebookObjectCollection)
            {
                for (int i = 0; i < i_TextPropertiesArray.Length; i++)
                {
                    setReflectionResultIntoPropertyInfoObject(item, i_TextPropertiesArray[i], i);
                }

                this.m_ListBox.Items.Add(string.Format(this.r_StringFormat, this.m_PropertyInfoObjectArray));
            }
        }

        // PRIVATE METHODS
        private void definePropertyInfoAndObjectArrays(string [] i_TextPropertiesArray)
        {
            this.m_PropertyInfoArray = new PropertyInfo[i_TextPropertiesArray.Length];
            this.m_PropertyInfoObjectArray = new object[i_TextPropertiesArray.Length];
        }

        private void setReflectionResultIntoPropertyInfoObject(T i_Item, string i_PropertyName, int i_Index)
        {
            this.m_PropertyInfoArray[i_Index] = i_Item.GetType().GetProperty(i_PropertyName);
            this.m_PropertyInfoObjectArray[i_Index] = this.m_PropertyInfoArray[i_Index].GetValue(i_Item, null);
        }
    }
}