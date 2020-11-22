namespace Ex01.FacebookAppLogic.Classes
{
    public class PropertyCounter
    {
        public string PropertyName { get; }
        public int Counter { get; set; }

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