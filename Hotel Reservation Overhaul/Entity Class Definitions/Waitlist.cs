using System;
class Waitlist
{
    private int waitlistID { get; set; }
    private int reservationID { get; set; }
    private int customerID { get; set; }
    private DateTime date { get; set; }
    Waitlist(int reservation, int customer, DateTime date_)
    {
        //this.waitlistID = ?? from database
        this.reservationID = reservation;
        this.customerID = customer;
        this.date = date_;
    }
}