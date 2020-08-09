class ActivityType
{
    private int activityTypeID { get; set; }
    private string description { get; set; }
    ActivityType(string descrp)
    {
        //this.activityTypeID = ?? from database
        this.description = descrp;
    }
}