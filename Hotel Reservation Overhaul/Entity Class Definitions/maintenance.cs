using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_Overhaul.Entity_Class_Definitions
{
    public class maintenance
    {
        public maintenance() { }
        public DataTable UpcomingMaint()
        {
            DBConnect getMaintenanceRoomsConn = new DBConnect();
            MySqlCommand getMaintenanceRooms = new MySqlCommand(@"select r.reservationID, r.confirmationID, r.roomNum from dbo.reservation r
                                                                 join maintenance m
                                                                 on m.maintenanceDate between r.startDate and r.endDate
                                                                 and m.locationID = r.locationID
                                                                 and m.roomNum = r.roomNum
                                                                 where r.reservationStatus = 'upcoming'");
            DataTable maintenanceRooms = getMaintenanceRoomsConn.ExecuteDataTable(getMaintenanceRooms);
            return maintenanceRooms;
        }

        public void  updateUpcoming(DataTable maintenanceRooms, DateTime currentDate)
        {
            foreach (DataRow row in maintenanceRooms.Rows)
            {   // reservation object to upgrade
                Reservation maintenaceRes = new Reservation(Convert.ToInt32(row["confirmationID"]));
                int resID = (Convert.ToInt32(row["reservationID"]));
                // details of room to be upgraded
                Room roomDetails = new Room(maintenaceRes.locationID, (Convert.ToInt32(row["roomNum"])));
                // list of current packages
                List<int> roomPackages = roomDetails.roomPackages((Convert.ToInt32(row["roomNum"])), maintenaceRes.locationID);
                string combinedString = string.Join(",", roomPackages);
                // find pacakages not on room
                List<int> newRoom = maintenaceRes.getAvailability(maintenaceRes.numGuests, maintenaceRes.locationID, 1, combinedString, currentDate, maintenaceRes.startDate, maintenaceRes.endDate);
                if (newRoom.Count > 0)
                {
                    // updates room number on reservation ID
                    DBConnect changeRoomConn = new DBConnect();
                    MySqlCommand changeRoom = new MySqlCommand("UPDATE reservation SET roomNum = @roomNum where reservationID = @reservationID");
                    changeRoom.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = newRoom[0];
                    changeRoom.Parameters.Add("@reservationID", MySqlDbType.Int32).Value = resID;
                    changeRoomConn.NonQuery(changeRoom);
                }
            }
        }

        public bool createMaintRec(int hotelID, DateTime maintainDate, int roomNum)
        {
            DBConnect insertMaintenanceConn = new DBConnect();
            MySqlCommand insertMaintenance = new MySqlCommand(@"INSERT INTO `dbo`.`maintenance`(`locationID`,`maintenanceDate`,`roomNum`)
                                                                                    VALUES(@hotelID, @maintainDate, @roomNum)");
            insertMaintenance.Parameters.Add("@hotelID", MySqlDbType.Int32).Value = hotelID;
            insertMaintenance.Parameters.Add("@maintainDate", MySqlDbType.Date).Value = maintainDate;
            insertMaintenance.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
            if (insertMaintenanceConn.NonQuery(insertMaintenance) > 0)
                return true;
            return false;
        }
    }
}
