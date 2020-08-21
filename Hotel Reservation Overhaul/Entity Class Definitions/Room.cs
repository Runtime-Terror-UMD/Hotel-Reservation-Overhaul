using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

public class Room
{
    private int roomNumber { get; set; }
    public int occupancy { get; set; }
    public int locationID { get; set; }
    public double price{ get; set; }

    public Room() { }

    public Room(int roomNb, int location)
    {
        DBConnect getRoomConn = new DBConnect();
        MySqlCommand getRoom = new MySqlCommand("SELECT * from dbo.room where roomNum = @roomNum and locationID = @locationID");
        getRoom.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNb;
        getRoom.Parameters.Add("@locationID", MySqlDbType.Int32).Value = location;

        MySqlDataReader dataReader = getRoomConn.ExecuteReader(getRoom);

        //Read the data and store them in the list
        while (dataReader.Read())
        {
            this.roomNumber = Convert.ToInt32(dataReader["roomNum"]);
            this.locationID = Convert.ToInt32(dataReader["locationID"]);
            this.occupancy = Convert.ToInt32(dataReader["occupancy"]);
            this.price = Convert.ToDouble(dataReader["pricePerNight"]);
        }

        //close Data Reader
        dataReader.Close(); ;
    }

    public bool addRoom(int roomNum, int hotelID, int roomOcc, decimal roomCost, List<int> roomPackages)
    {
        DBConnect insertRoomConn = new DBConnect();
        MySqlCommand insertRoom = new MySqlCommand(@"INSERT INTO `dbo`.`room` (`roomNum`,`locationID`,`occupancy`,`pricePerNight`)
                                                                             VALUES(@roomNum,@hotelId,@roomOcc,@roomCost)");
        insertRoom.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
        insertRoom.Parameters.Add("@hotelId", MySqlDbType.Int32).Value = hotelID;
        insertRoom.Parameters.Add("@roomOcc", MySqlDbType.Int32).Value = roomOcc;
        insertRoom.Parameters.Add("@roomCost", MySqlDbType.Decimal).Value = roomCost;
        if (insertRoomConn.NonQuery(insertRoom) < 1)
        {
            return false;
        }
        else
        {   //insert packages-room relationship
            MySqlCommand insertRoomPacks = new MySqlCommand(@"INSERT INTO `dbo`.`relation_room_package`(`roomNum`,`locationID`,`packageID`)
                                                                                VALUES(@roomNum,@hotelId,@packID");
            insertRoomPacks.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
            insertRoom.Parameters.Add("@hotelId", MySqlDbType.Int32).Value = hotelID;

            foreach (var pack in roomPackages)
            {
                insertRoomPacks.Parameters.Add("@packID", MySqlDbType.Int32).Value = pack;
                if (insertRoomConn.NonQuery(insertRoomPacks) < 1)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public bool roomExists(int roomNum, int hotelID)
    {
        DBConnect checkForRoomConn = new DBConnect();
        MySqlCommand checkForRoom = new MySqlCommand("SELECT COUNT(*) FROM dbo.room where roomNum = @roomNum and locationID = @hotelID");
        checkForRoom.Parameters.Add("@hotelID", MySqlDbType.Int32).Value = hotelID;
        checkForRoom.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;

        if (checkForRoomConn.intScalar(checkForRoom) > 0)
        {
            return true;
        }
        return false;
    }

    public List<int> roomPackages(int roomNum, int hotelID)
    {
        List<int> roomPacks = new List<int>();
        DBConnect roomPacksConn = new DBConnect();
        MySqlCommand getRoomPacks = new MySqlCommand(@"select packageID from relation_room_package
                                                        where roomNum = @roomNum
                                                        and locationID = @locationID");
        getRoomPacks.Parameters.Add("@roomNum", MySqlDbType.Int32).Value = roomNum;
        getRoomPacks.Parameters.Add("@locationID", MySqlDbType.Int32).Value = hotelID;
        MySqlDataReader roomPackList = roomPacksConn.ExecuteReader(getRoomPacks);
        if (roomPackList.HasRows)
        {
            while (roomPackList.Read())
            {
                roomPacks.Add(Convert.ToInt32(roomPackList["packageID"]));
            }
            return roomPacks;
        }
        else
        {
            return roomPacks;
        }

    }
}