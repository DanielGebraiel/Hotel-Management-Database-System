using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North_DiamondHotel
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        //public DataTable getAvailableRooms(DateTime inDate, DateTime outDate, int capacity, string type)
        //{
        //    string query = "SELECT Room_No, Cost , Capacity, Sea_View, Pool_View, Garden_View FROM Rooms WHERE Capacity >= '" + capacity + "' AND Type='" + type + "' EXCEPT SELECT R.Room_No, R.Cost , R.Capacity, R.Sea_View, R.Pool_View, R.Garden_View FROM Rooms R,Room_Reservations RR WHERE (R.Room_No = RR.Room_No) AND (('" + inDate + "' BETWEEN RR.Check_In AND RR.Check_Out) OR ( '" + outDate + "'  BETWEEN RR.Check_In AND RR.Check_Out) OR ('" + inDate + "' < RR.Check_In AND '" + outDate + "' > RR.Check_Out))";
        //    return dbMan.ExecuteReader(query);
        //}

        public DataTable getAvailableRooms(DateTime indate, DateTime outdate, int capacity, string type)
        {
            string StoredProcedureName = StoredProcedures.GetAvailableRooms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@indate", indate);
            Parameters.Add("@outdate", outdate);
            Parameters.Add("@capacity", capacity);
            Parameters.Add("type", type);
            return dbMan.StoredProcExecuteReader(StoredProcedureName, Parameters);
        }

        public int addGuest(int id, string phone_no, string email, string fname, string lname, decimal age)
        {
            string query = "insert into guests values ('" + id + "','" + phone_no + "','" + email + "','" + fname + "','" + lname + "','" + age + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        //public int addGuest(int id, string phone_no, string email, string fname, string lname, decimal age)
        //{
        //    string StoredProcedureName = StoredProcedures.AddGuest;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@id", id);
        //    Parameters.Add("@phone_no", phone_no);
        //    Parameters.Add("@email", email);
        //    Parameters.Add("@Fname", fname);
        //    Parameters.Add("@Lname", lname);
        //    Parameters.Add("@age", age);
        //    return dbMan.StoredProcExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public int bookRoom(int id,int room,int discount,DateTime inDate,DateTime outDate)
        //{
        //    string query = "INSERT INTO Room_Reservations VALUES ('"+id+"','"+room+"','"+discount+"','"+inDate+"','"+outDate+"')";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int bookRoom(int id, int room, int discount, DateTime inDate, DateTime outDate)
        {
            string StoredProcedureName = StoredProcedures.BookRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@id", id);
            Parameters.Add("@room", room);
            Parameters.Add("@discount", discount);
            Parameters.Add("@inDate", inDate);
            Parameters.Add("@outDate", outDate);
            return dbMan.StoredProcExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //public DataTable getStaffNameFromID(int id)
        //{
        //    string query = " SELECT First_Name FROM Staff WHERE ID ='" + id + "'";
        //    return dbMan.ExecuteReader(query);
        //}

        public DataTable getStaffNameFromID(int id)
        {
            string StoredProcedureName = StoredProcedures.GetStaffNameFromID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.StoredProcExecuteReader(StoredProcedureName, Parameters);
        }

        //public DataTable getHallCapacities()
        //{
        //    string query = "SELECT Capacity FROM Halls";
        //    return dbMan.ExecuteReader(query);

        //}

        public DataTable getHallCapacities()
        {
            string storedprocedurename = StoredProcedures.GetHallCapacities;
            return dbMan.StoredProcExecuteReader(storedprocedurename, null);
        }

        public DataTable getavailableHalls(DateTime date, int capacity)
        {
            string query = "SELECT Name,Cost,Capacity FROM Halls WHERE Capacity>='" + capacity + "' EXCEPT SELECT H.Name,Cost,Capacity FROM  Halls H,Hall_reservation HR WHERE  H.Name=HR.Name AND HR.Date='" + date + "'";
            return dbMan.ExecuteReader(query);
        }

        //public int bookHall(string name,DateTime date,string Eventtype,int ID)
        //{
        //    string query = "INSERT INTO Hall_reservation VALUES('"+name+"','"+date+"','"+Eventtype+"','"+ID+"')";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int bookHall(string name, DateTime date, string EventType, int ID)
        {
            string StoredProcedureName = StoredProcedures.BookHall;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@date", date);
            Parameters.Add("@EventType", EventType);
            Parameters.Add("@id", ID);
            return dbMan.StoredProcExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable searchGuest(int id)
        {
            string query = "SELECT * FROM Guests WHERE ID='" + id + "'";
            return dbMan.ExecuteReader(query);
        }


        //public DataTable getRooomsToClean(int id)
        //{

        //    string query = "SELECT Room_No FROM Housekeeping WHERE Staff_ID ='" + id + "' AND Room_No IN(SELECT Room_No FROM Rooms Where Is_Clean=0);";
        //    DataTable dt = dbMan.ExecuteReader(query);
        //    return dt;
        //}
        public DataTable getRooomsToClean(int id)
        {
            string StoredProcedureName = StoredProcedures.GetRoomsToClean;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.StoredProcExecuteReader(StoredProcedureName, Parameters);
        }

        //public int markRoomAsCleaned(int Rno)
        //{
        //    string query = "UPDATE Rooms SET Is_Clean = 1 WHERE Room_No='" + Rno + "' ";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int markRoomAsCleaned(int Rno)
        {
            string StoredProcedureName = StoredProcedures.MarkRoomAsCleaned;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Rno", Rno);
            return dbMan.StoredProcExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //public DataTable GetPasswordandJobTypeFromID(string ID)
        //{
        //    string query = "Select Password, Job_Type from Staff where ID = " + ID;
        //    return dbMan.ExecuteReader(query);
        //}

        public DataTable GetPasswordandJobTypeFromID(string id)
        {
            string StoredProcedureName = StoredProcedures.GetPasswordandJobTypeFromID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.StoredProcExecuteReader(StoredProcedureName, Parameters);
        }

        //public int UpdatePasswordFromID(string ID, string newPassword)
        //{
        //    string query = "update staff set Password = '" + newPassword + "' where ID = " + ID;
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int UpdatePasswordFromID(string ID, string newPassword)
        {
            string StoredProcedureName = StoredProcedures.UpdatePasswordFromID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@newPassword", newPassword);
            return dbMan.StoredProcExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getFoodTypes()
        {
            string query = " SELECT Type FROM Food_and_Beverages";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getRestaurantNameFromChefId(int id)
        {
            string query = "SELECT Restaurant_Name FROM Chefs WHERE Staff_Id ='" + id + "';";
            return dbMan.ExecuteReader(query);
        }
        public int insertRestaurantOrder(string RestaurantName, int Quantity, string FoodType)
        {
            string query = "INSERT INTO Restaurant_Orders VALUES ('" + RestaurantName + "','" + Quantity + "','" + FoodType + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int getNoOfRestaurantReservations(string name, DateTime date)
        {
            string query = "SELECT Count(*) FROM Restaurant_Reservations WHERE Restaurant_Name='" + name + "' AND Date ='" + date + "'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable getRoomTypes()
        {
            string query = "SELECT DISTINCT Type FROM Rooms";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetShowTypeFromID(int id)
        {
            string query = "Select Show_Type From Animation where Staff_ID= " + id + ";";
            return dbMan.ExecuteReader(query);
        }

        public int Insertshow(string type, DateTime date, string loc)
        {
            string query = "insert into Show_Time values('" + type + "','" + date + "','" + loc + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectanimationByID(int id)
        {
            string query = "SELECT a.Type,a.Time,a.location from Show_Time a, Animation s where  S.Show_Type = a.Type  AND s.Staff_ID=" + id + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getClubnames()
        {
            string query = "SELECT Name FROM Clubs ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getGuestAgeFromID(int id)
        {
            string query = "SELECT Age FROM Guests WHERE ID = '" + id + "' ";
            return dbMan.ExecuteReader(query);
        }
        public int bookClub(int ID, string name, DateTime date)
        {
            string query = "INSERT INTO Club_Reservations VALUES('" + name + "','" + ID + "','" + date + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getAgeRestrictionForClub(string name)
        {
            string query = "SELECT Age_Restriction FROM Clubs WHERE Name='" + name + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getDatesFromGuestID(int id)
        {
            string query = "SELECT Check_In, Check_Out From Room_Reservations WHERE Guest_ID ='" + id + "'";
            return dbMan.ExecuteReader(query);
        }
        public int getNoOfReservationsFromGuestID(int id)
        {
            string query = "SELECT COUNT(*) From Room_Reservations WHERE Guest_ID ='" + id + "'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable getRestaurantNames()
        {
            string query = "SELECT Name FROM Restaurant";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getRestaurantCapacity(string name)
        {
            string query = "SELECT Capacity FROM Restaurant WHERE Name='" + name + "'";
            return dbMan.ExecuteReader(query);
        }

        public int bookRestaurant(int id, string name, DateTime date)
        {
            string query = " INSERT INTO Restaurant_Reservations VALUES ('" + name + "','" + id + "',  '" + date + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getActivities(DateTime date)
        {
            string query = "SELECT A.Type,A.Cost,AT.Date FROM Activities A,Time_Of_Activity AT WHERE AT.Date>='" + date + "' AND A.Type=AT.Type";
            return dbMan.ExecuteReader(query);
        }

        public int bookActivity(int id, DateTime date, string type)
        {
            string query = "INSERT INTO Activity_Reservations VALUES('" + type + "','" + id + "','" + date + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllJobtypes()
        {
            string query = "select distinct Job_Type from staff";
            return dbMan.ExecuteReader(query);
        }

        public int addEmployee(string id, string address, string gender, string phone, string first, string last, decimal age, string job, string password)
        {
            string query = "INSERT INTO Staff Values ('" + id + "','" + address + "','" + gender + "','" + phone + "','" + first + "','" + last + "','" + age + "','" + job + "','" + password + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getBooked(string table)
        {
            string query = "SELECT Distinct Name FROM " + table + " ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getBookedTable(string table, string obj)
        {
            string query = "SELECT DISTINCT * FROM " + table + " WHERE  Name='" + obj + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getRoomsBooked()
        {
            string query = "SELECT * FROM Room_Reservations";
            return dbMan.ExecuteReader(query);
        }
        public int cancelBooking(string table, string name, int id, DateTime date)
        {
            string query = "DELETE FROM " + table + " WHERE Name='" + name + "'AND Guest_ID= '" + id + "' And Date= '" + date + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        //public int cancelClubReservation(string name, int id, DateTime date)
        //{
        //    string query = "DELETE FROM Club_Reservations WHERE Name='" + name + "'AND Guest_ID= '" + id + "' And Date= '" + date + "'";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int cancelHallReservation(string name, int id, DateTime date)
        //{
        //    string query = "DELETE FROM Hall_Reservation WHERE Name='" + name + "'AND Guest_ID= '" + id + "' And Date= '" + date + "'";
        //    return dbMan.ExecuteNonQuery(query);
        //}
        //public int cancelRestaurantReservation(string name, int id, DateTime date)
        //{
        //    string query = "DELETE FROM Activity_Reservations WHERE Name='" + name + "'AND Guest_ID= '" + id + "' And Date= '" + date + "'";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int cancelRoom(int id, int room, DateTime inDate)
        {
            string query = "DELETE FROM Room_Reservations WHERE Guest_ID='" + id + "' AND Room_No='" + room + "' AND Check_In='" + inDate + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getDiscount(double days)
        {
            string query = "SELECT MAX (Percentage) FROM Discount WHERE Min_Duration<=" + days + "";
            return dbMan.ExecuteReader(query);
        }
    }
}