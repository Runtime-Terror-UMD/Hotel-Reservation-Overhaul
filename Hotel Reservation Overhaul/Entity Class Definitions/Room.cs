using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

class Room
{
    private int roomNumber { get; set; }
    //private package ??
    private int locationID { get; set; }
    private bool availability { get; set; }
    private int floor { get; set; }
    private int building { get; set; }
    private string description { get; set; }
    Room(int roomNb, int location, bool available, int flr, int bldng, string descrp)
    {
        this.roomNumber = roomNb;
        this.locationID = location;
        this.availability = available;
        this.floor = flr;
        this.building = bldng;
        this.description = descrp;
    }
    public Room() { }

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