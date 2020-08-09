using System;
class Reservation
{
    enum Status
    {
        WAITLISTED,
        UPCOMING,
        CHECKED_IN,
        CHECKED_OUT,
        CANCELLED
    }
    private int reservationID { get; set; }
    private int confirmatonID { get; set; }
    private int packageID { get; set; }
    private DateTime startDate { get; set; }
    private DateTime endDate { get; set; }
    private double duration { get; set; }
    private decimal totalPrice { get; set; }
    private Status status { get; set; }

    Reservation (int package, DateTime start, DateTime end)
    {
        //reservationID ?? from database
        //confirmationID ?? from database
        this.packageID = package; // more than one package?
        this.startDate = start;
        this.endDate = end;
        this.duration = (end - start).TotalDays;
        //this.totalPrice = ?? the cost of the package?
        //status is set later
    }
}