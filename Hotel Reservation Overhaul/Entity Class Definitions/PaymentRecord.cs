using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;

class PaymentRecord
{

    private int paymentID { get; set; }
    private int confirmationID { get; set; }
    private double amount { get; set; }

    public PaymentRecord() { }

    // DESCRIPTION: Creates a payment record and updates the balance of the reservation 
    public bool makePayment(int userID, int confirmationID, double amountPaid, string paymentMethod, bool usedRewards)
    {
        // create payment record
        DBConnect makePaymentConn = new DBConnect();
        MySqlCommand makePayment = new MySqlCommand(@"INSERT INTO dbo.payment(customerID, confirmationID, amountPaid, paymentMethod, usedRewards)
                                                    VALUES(@userID, @confID, @amountPaid, @paymentMethod, @usedRewards)");
        makePayment.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        makePayment.Parameters.Add("@confID", MySqlDbType.Int32).Value = confirmationID;
        makePayment.Parameters.Add("@amountPaid", MySqlDbType.Decimal).Value = amountPaid;
        makePayment.Parameters.Add("@paymentMethod", MySqlDbType.VarChar, 45).Value = paymentMethod;
        makePayment.Parameters.Add("@usedRewards", MySqlDbType.Bit).Value = usedRewards;

        if (makePaymentConn.NonQuery(makePayment) > 0)
        {// update balance and amount paid on reservation
            Reservation payReservation = new Reservation(confirmationID);
            payReservation.amountDue = payReservation.amountDue - amountPaid;
            payReservation.amountPaid = payReservation.amountPaid + amountPaid;
            if (payReservation.updateReservation(payReservation))
                return true;
            else
                return false;
        }
        return false;

    }
}
