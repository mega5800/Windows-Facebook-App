namespace Ex01.FacebookAppLogic.Classes
{
    public class PropertyCounter
    {
        // ATTRIBUTES
        public string PropertyName { get; }

        public int Counter { get; set; }

        // CTOR
        public PropertyCounter(string i_LocationName)
        {
            this.PropertyName = i_LocationName;
            this.Counter = 1;
        }

        public PropertyCounter(string i_LocationName, int i_Counter)
        {
            this.PropertyName = i_LocationName;
            this.Counter = i_Counter;
        }
    }
}