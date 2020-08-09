class Payment
{
    enum PaymentMethod
    {
        CASH,
        DEBIT,
        CREDIT,
        CHECK
    }
    private int paymentID { get; set; }
    private int confirmationID { get; set; }
    private PaymentMethod paymentMethod { get; set; }
    private decimal amount { get; set; }
    Payment(int confirm, PaymentMethod pay, decimal amt)
    {
        //this.paymentID = ?? from database
        this.confirmationID = confirm;
        this.paymentMethod = pay;
        this.amount = amt;
    }
}
