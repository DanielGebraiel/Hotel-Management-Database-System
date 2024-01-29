using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North_DiamondHotel
{
    class StoredProcedures
    {
        public static string GetHallCapacities = "getHallCapacities";
        public static string GetStaffNameFromID = "getStaffNameFromID";
        public static string GetAvailableRooms = "getAvailableRooms";
        public static string AddGuest = "addGuest";
        public static string BookRoom = "bookRoom";
        public static string BookHall = "bookHall";
        public static string GetRoomsToClean = "getRoomsToClean";
        public static string MarkRoomAsCleaned = "markRoomAsCleaned";
        public static string GetPasswordandJobTypeFromID = "GetPasswordandJobTypeFromID";
        public static string UpdatePasswordFromID = "UpdatePasswordFromID";
    }
}
