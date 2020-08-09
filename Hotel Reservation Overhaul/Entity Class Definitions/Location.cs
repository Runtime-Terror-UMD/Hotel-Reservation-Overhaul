class Location
{
    private int locationID { get; set; }
    private string name { get; set; }
    Location(string name_)
    {
        //this.locationID = ?? from database
        this.name = name_;
    }
}