class Room
{
    private int roomNumber { get; set; }
    //private package ??
    private int locationID { get; set; }
    private bool availability { get; set; }
    private int floor { get; set; }
    private int building { get; set; }
    private string description { get; set; }
    Room(int roomNb, int location, bool available, int flr, int bldng, string descrp)
    {
        this.roomNumber = roomNb;
        this.locationID = location;
        this.availability = available;
        this.floor = flr;
        this.building = bldng;
        this.description = descrp;
    }

}