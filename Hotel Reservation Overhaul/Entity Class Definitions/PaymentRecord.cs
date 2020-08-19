using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;

class PaymentRecord
{

    private int paymentID { get; set; }
    private int confirmationID { get; set; }
    private double amount { get; set; }

    public PaymentRecord() { }

    // DESCRIPTION: Creates a payment record and updates the balance of the reservation 
    public bool makePayment(int userID, int confirmationID, double amountPaid, string paymentMethod, bool usedRewards, DateTime currentDate, string ccNumber)
    {
        // create payment record
        DBConnect makePaymentConn = new DBConnect();
        MySqlCommand makePayment = new MySqlCommand(@"INSERT INTO dbo.payment(customerID, confirmationID, amountPaid, paymentMethod, usedRewards,created, ccNum)
                                                    VALUES(@userID, @confID, @amountPaid, @paymentMethod, @usedRewards, @created, @ccNum)");
        makePayment.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        makePayment.Parameters.Add("@confID", MySqlDbType.Int32).Value = confirmationID;
        makePayment.Parameters.Add("@amountPaid", MySqlDbType.Decimal).Value = amountPaid;
        makePayment.Parameters.Add("@paymentMethod", MySqlDbType.VarChar, 45).Value = paymentMethod;
        makePayment.Parameters.Add("@usedRewards", MySqlDbType.Bit).Value = usedRewards;
        makePayment.Parameters.Add("@created", MySqlDbType.Date).Value = currentDate;
        makePayment.Parameters.Add("@ccNum", MySqlDbType.VarChar, 45).Value = ccNumber;

        if (makePaymentConn.NonQuery(makePayment) > 0)
        {// update balance and amount paid on reservation
            if(usedRewards)
            {
                Reward updateRewards = new Reward();
                updateRewards.setRewardsPoints(userID, -50, userID);
            }

            // get payment ID
            makePayment.CommandText = "SELECT paymentID from dbo.payment where customerID = @userID and confirmationID = @confID and amountPaid = @amountPAid and paymentMethod = @paymentMethod and usedRewards = @usedRewards and created = @created and ccNum = @ccNum";

            int payID = makePaymentConn.intScalar(makePayment);
            
            // log payment
            LoggedActivity logPayment = new LoggedActivity();
            logPayment.logActivity(userID, 8, payID, currentDate, userID);
            
            // update reservation amount
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
