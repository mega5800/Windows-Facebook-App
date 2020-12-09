using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Loaders
{
    public sealed class TextLoader<T> : Loader<T>
    {
        // ATTRIBUTES
        private readonly string r_StringFormat;
        private ListBox m_ListBox;
        private PropertyInfo[] m_PropertyInfoArray;
        private object[] m_PropertyInfoObjectArray;
        
        // CTOR
        public TextLoader(List<object> i_ParamsList) : base(i_ParamsList[0])
        {
            this.m_ListBox = i_ParamsList[1] as ListBox;
            this.r_StringFormat = i_ParamsList[2] as string;
        }

        // PROTECTED METHODS
        protected internal override void LoadProperties(params string[] i_TextPropertiesArray)
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
        private void definePropertyInfoAndObjectArrays(string[] i_TextPropertiesArray)
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