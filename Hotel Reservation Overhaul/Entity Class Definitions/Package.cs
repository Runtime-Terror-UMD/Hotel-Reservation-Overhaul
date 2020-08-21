using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;

class Package
{
    public Package() { }

    public bool packageExists(int packID)
    {
        DBConnect verifyPackageConn = new DBConnect();
        MySqlCommand verifyPackage = new MySqlCommand("SELECT COUNT(*) from dbo.package where packageID = @pack");
        verifyPackage.Parameters.Add("@pack", MySqlDbType.Int32).Value = packID;
        if (verifyPackageConn.intScalar(verifyPackage) > 0)
        {
            return true;
        }
        return false;
    }

    public bool addPackage(int packID, string packName, decimal packCost)
    {
        DBConnect insertPackageConn = new DBConnect();
        MySqlCommand insertPackage = new MySqlCommand(@"INSERT INTO `dbo`.`package`(`packageID`,`packageName`,`pricePerNight`) VALUES(@packID, @packName, @packCost)");
        insertPackage.Parameters.Add("@packID", MySqlDbType.Int32).Value = packID;
        insertPackage.Parameters.Add("@packName", MySqlDbType.VarChar, 45).Value = packName;
        insertPackage.Parameters.Add("@packCost", MySqlDbType.Decimal).Value = packCost;
        if (insertPackageConn.NonQuery(insertPackage) > 0)
            return true;
        else
            return false;
    }
}