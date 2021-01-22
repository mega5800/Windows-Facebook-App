namespace Ex03.FacebookAppLogic.Classes
{
    public sealed class PropertyCounter
    {
        // ATTRIBUTES
        public string PropertyName { get; }

        public int Counter { get; set; }

        // CTOR
        public PropertyCounter(string i_LocationName)
        {
            this.PropertyName = i_LocationName;
            this.Counter = 0;
        }
    }
}