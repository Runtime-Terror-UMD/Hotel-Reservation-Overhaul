class PaymentRecord
{

    private int paymentID { get; set; }
    private int confirmationID { get; set; }
    private double amount { get; set; }
    PaymentRecord(int confirm, double amt)
    {
        //this.paymentID = ?? from database
        this.confirmationID = confirm;
        this.amount = amt;
    }
}
