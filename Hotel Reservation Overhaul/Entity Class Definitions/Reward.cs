using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;

public class Reward
{

    public Reward(){}

    public bool applyReward(Reservation resInfo)
    {
        resInfo.totalPrice = resInfo.totalPrice * .9;
        resInfo.amountDue = resInfo.totalPrice - resInfo.amountPaid;
        resInfo.updateReservation(resInfo);
        return true;
    }

    // DESCRIPTION: Gets rewards points based on userid
    public int getRewardsPoints(int userID)
    {
        int rewards;
        DBConnect getPointsBalanceConn = new DBConnect();

        // build query
        MySqlCommand cmd = new MySqlCommand("SELECT pointsBalance from dbo.user where userid = @userID");
        cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

        //assign value to variable
        rewards = getPointsBalanceConn.intScalar(cmd);
        return rewards;
    }
    //DESCRIPTION: Sets rewards points based on userid
    public bool setRewardsPoints(int userID, int points, int createdBy)
    {
        // build query
        MySqlCommand cmd = new MySqlCommand("UPDATE `dbo`.`user` SET `pointsBalance` = pointsBalance + @newPoints WHERE `userID` = @userID");
        cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        cmd.Parameters.Add("@newPoints", MySqlDbType.Int32).Value = points;
        DBConnect updatePoints = new DBConnect();
        if ((updatePoints.NonQuery(cmd)) > 0)
        {
            // add to rewards log
            cmd.CommandText = @"INSERT INTO `dbo`.`reward_log` (`customerID`,`PointsAmount`,`createdBy`,`created`)
                                    VALUES(@userID, @newPoints, @createdBy, @created)";
            cmd.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
            cmd.Parameters.Add("@created", MySqlDbType.Date).Value = DateTime.Today;
            if ((updatePoints.NonQuery(cmd)) > 0)
                return true;
            return false;
        }
        return false;
    }

}
