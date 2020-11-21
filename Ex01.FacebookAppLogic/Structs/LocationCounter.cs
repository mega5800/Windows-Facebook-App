namespace Ex01.FacebookAppLogic.Structs
{
    //maybe define as struct??
    public class LocationCounter
    {
        public string LocationName { get; }
        public int Counter { get; set; }

        public LocationCounter(string i_LocationName)
        {
            this.LocationName = i_LocationName;
            this.Counter = 1;
        }
    }
}