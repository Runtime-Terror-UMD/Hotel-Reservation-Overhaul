using System;
class LoggedActivity
{
    private int activityLogID { get; set; }
    private int customerID { get; set; }
    private int activityTypeID { get; set; }
    private DateTime creationDate { get; set; }
    LoggedActivity (int customer, int type, DateTime date)
    {
        //this.activityLogID = ?? from database
        this.customerID = customer;
        this.activityTypeID = type;
        this.creationDate = date;
    }
}