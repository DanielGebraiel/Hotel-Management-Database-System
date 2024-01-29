
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_DiamondHotel
{
    public partial class managerWindow : System.Windows.Forms.Form
    {
        int ID;


        DataTable dt;
        Controller controllerobj = new Controller();
        public managerWindow(int num, int iD)
        {
            InitializeComponent();
            if (num == 0)//manager
            {
                CancelButton.Visible = true;
            }
            else if (num == 1)//receptionist
            {
                CancelButton.Visible = false;
                statisticsButton.Visible = false;
                addEmployeeButton.Visible = false;
            }
            ID = iD;
            dt = controllerobj.getStaffNameFromID(ID);
            welcomeLabel.Text = "Welcome " + dt.Rows[0][0].ToString();
            checkInDate.MinDate = checkInDate.Value;
            checkOutDate.MinDate = checkInDate.Value.AddDays(1);
            dt = controllerobj.getRoomTypes();
            roomType.DataSource = dt;
            roomType.DisplayMember = "Type";
            donehall.Visible = false;
            invalidNumberLabel.Visible = false;
            IncompleteInfoLabel.Visible = false;
            FailedToAddGuestLabel.Visible = false;
            doneclub.Visible = false;
            bookRoomErrorlabel.Visible = false;
            Guest1BookLabel.Visible = false;
            Guest2Booklabel.Visible = false;
            Guest3Booklabel.Visible = false;
            Guest4Booklabel.Visible = false;
            FailedToBookClubLabel.Visible = false;
            MissingClubInfoLabel.Visible = false;
            BookedClubLabel.Visible = false;
            NonGuestsClubsLabel.Visible = false;
            AgeResrtictionLabel.Visible = false;
            errorClubsLabel.Visible = false;
            clubNameCombobox.DataSource = controllerobj.getClubnames();
            clubNameCombobox.DisplayMember = "Name";
            doneactivity.Visible = false;
            doneemployee.Visible = false;

            hallBookedLabel.Visible = false;
            missingIdForHalls.Visible = false;
            errorHallLabel.Visible = false;
            missingInfoHalls.Visible = false;
            dt = controllerobj.getHallCapacities();
            hallCapacity.DataSource = dt;
            hallCapacity.DisplayMember = "Capacity";

            dt = controllerobj.getRestaurantNames();
            restaurantName.DataSource = dt;
            restaurantName.DisplayMember = "Name";
            ErrorRestaurantLabel.Visible = false;
            BookedResaurantLabel.Visible = false;
            donerestraunt.Visible = false;

            dt = controllerobj.getActivities(DateTime.Today);
            activityDatagrid.DataSource = dt;
            activityDatagrid.Refresh();
            ErrorMessageForActivity.Visible = false;
            BookedActivityLabel.Visible = false;

            dt = controllerobj.SelectAllJobtypes();
            jobTypeCombobox.DataSource = dt;
            jobTypeCombobox.DisplayMember = "Job_Type";

        }

        bool flagid1 = true;
        bool flagid2 = true;
        bool flagid3 = true;
        bool flagid4 = true;
        bool flagid5 = true;
        bool flagid6 = true;
        bool flagid7 = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hide_All();
        }
        //BOOK ROOM
        private void bookRoomButton_Click(object sender, EventArgs e)
        {
            hide_All();
            bookRoomCursor.Visible = true;
            bookRoomPanel.Visible = true;


        }
        private void checkInDate_ValueChanged(object sender, EventArgs e)
        {
            checkOutDate.MinDate = checkInDate.Value;
        }

        private void searchRoomButton_Click(object sender, EventArgs e)
        {
            dt = controllerobj.getAvailableRooms(checkInDate.Value, checkOutDate.Value, Convert.ToInt32(roomCapacity.Value), roomType.Text);
            roomGroupbox.Visible = true;
            availableRoomsDatagrid.DataSource = dt;
            availableRoomsDatagrid.Visible = true;
            ID1Guest.Visible = false;
            ID1Label.Visible = false;
            donehall.Visible = false;
            ID1GuestButton.Visible = false;
            ID2Guest.Visible = false;
            ID2Label.Visible = false;
            ID2GuestButton.Visible = false;
            ID3Guest.Visible = false;
            ID3Label.Visible = false;
            ID3GuestButton.Visible = false;
            ID4Guest.Visible = false;
            ID4Label.Visible = false;
            ID4GuestButton.Visible = false;
            Guest1BookLabel.Visible = false;
            Guest2Booklabel.Visible = false;
            Guest3Booklabel.Visible = false;
            Guest4Booklabel.Visible = false;
            if (dt != null)
            {
                availableRoomsDatagrid.Refresh();
                roomGroupbox.Visible = true;
                if (roomCapacity.Value >= 1)
                {
                    ID1Label.Visible = true;
                    ID1Guest.Visible = true;
                    ID1GuestButton.Visible = true;
                }
                if (roomCapacity.Value >= 2)
                {
                    ID2Label.Visible = true;
                    ID2Guest.Visible = true;
                    ID2GuestButton.Visible = true;
                }
                if (roomCapacity.Value >= 3)
                {
                    ID3Label.Visible = true;
                    ID3Guest.Visible = true;
                    ID3GuestButton.Visible = true;
                }
                if (roomCapacity.Value == 4)
                {
                    ID4Label.Visible = true;
                    ID4Guest.Visible = true;
                    ID4GuestButton.Visible = true;
                }
            }
        }

        private void ID1GuestButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(ID1Guest.Text, out value);
            if (isNum == false)
            {
                bookRoomErrorlabel.Text = "Please enter a Valid ID";
                bookRoomErrorlabel.Visible = true;
                return;
            }
            dt = controllerobj.searchGuest(Convert.ToInt32(ID1Guest.Text));
            if (dt != null)
            {
                if (roomCapacity.Value > 1)
                {

                    ID2Label.Visible = true;
                    ID2Guest.Visible = true;
                    ID2GuestButton.Visible = true;
                }
                if (roomCapacity.Value == 1)
                {
                    roomNextButton.Visible = true;
                }
            }
            else
            {
                bookNewGuestPanel.Visible = true;
                bookNewGuestPanel.BringToFront();
                idNewGuestTextbox.Text = ID1Guest.Text;

            }
        }

        private void ID2GuestButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(ID2Guest.Text, out value);
            if (isNum == false)
            {
                bookRoomErrorlabel.Text = "Please enter a Valid ID";
                bookRoomErrorlabel.Visible = true;
                return;
            }
            dt = controllerobj.searchGuest(Convert.ToInt32(ID2Guest.Text));
            if (dt != null)
            {
                if (roomCapacity.Value > 2)
                {

                    ID3Label.Visible = true;
                    ID3Guest.Visible = true;
                    ID3GuestButton.Visible = true;
                }
                if (roomCapacity.Value == 2)
                {
                    roomNextButton.Visible = true;
                }
            }
            else
            {

                bookNewGuestPanel.Visible = true;
                bookNewGuestPanel.BringToFront();
                idNewGuestTextbox.Text = ID2Guest.Text;
            }
        }

        private void ID3GuestButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(ID3Guest.Text, out value);
            if (isNum == false)
            {
                bookRoomErrorlabel.Text = "Please enter a Valid ID";
                bookRoomErrorlabel.Visible = true;
                return;
            }
            dt = controllerobj.searchGuest(Convert.ToInt32(ID3Guest.Text));
            if (dt != null)
            {
                if (roomCapacity.Value > 3)
                {

                    ID4Label.Visible = true;
                    ID4Guest.Visible = true;
                    ID4GuestButton.Visible = true;
                }
                if (roomCapacity.Value == 3)
                {
                    roomNextButton.Visible = true;
                }
            }
            else
            {

                bookNewGuestPanel.Visible = true;
                bookNewGuestPanel.BringToFront();
                idNewGuestTextbox.Text = ID3Guest.Text;
            }
        }

        private void ID4GuestButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(ID4Guest.Text, out value);
            if (isNum == false)
            {
                bookRoomErrorlabel.Text = "Please enter a Valid ID";
                bookRoomErrorlabel.Visible = true;
                return;
            }
            dt = controllerobj.searchGuest(Convert.ToInt32(ID4Guest.Text));
            if (dt != null)
            {
                roomNextButton.Visible = true;
            }
            else
            {

                bookNewGuestPanel.Visible = true;
                bookNewGuestPanel.BringToFront();
                idNewGuestTextbox.Text = ID4Guest.Text;

            }
        }
        private void roomNextButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(ID1Guest.Text, out value);
            bool isNum2 = false;
            int value2 = 0;
            isNum2 = int.TryParse(ID2Guest.Text, out value2);
            bool isNum3 = false;
            int value3 = 0;
            isNum3 = int.TryParse(ID3Guest.Text, out value3);
            bool isNum4 = false;
            int value4 = 0;
            isNum4 = int.TryParse(ID4Guest.Text, out value4);
            Guest1BookLabel.Visible = false;
            Guest2Booklabel.Visible = false;
            Guest3Booklabel.Visible = false;
            Guest4Booklabel.Visible = false;
            DiscountLabel.Visible = false;

            double days = (checkOutDate.Value - checkInDate.Value).TotalDays;
            DataTable dt2 = controllerobj.getDiscount(days);
            int discount = Convert.ToInt32(dt2.Rows[0][0].ToString());
            //if (days >=5)
            //{

            //    discount = Convert.ToInt32(dt2.Rows[0][0].ToString());

            //}
            int check = 0;
            if (roomCapacity.Value == 1)
            {

                DataGridViewSelectedRowCollection dt = availableRoomsDatagrid.SelectedRows;
                if (dt.Count == 0)
                {
                    bookRoomErrorlabel.Text = "Please Select a Row";
                    bookRoomErrorlabel.Visible = true;
                }
                else if (isNum == false)
                {
                    bookRoomErrorlabel.Text = "Please enter a valid ID in Guest1";
                    bookRoomErrorlabel.Visible = true;
                    return;
                }
                else
                {
                    bookRoomErrorlabel.Visible = false;
                    check = controllerobj.bookRoom(Convert.ToInt32(ID1Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest1BookLabel.Visible = true;
                        roomNextButton.Visible = false;
                        doneroombutton.Visible = true;
                        DiscountLabel.Text = DiscountLabel.Text + dt2.Rows[0][0].ToString() + "% Discount";
                        DiscountLabel.Visible = true;

                    }
                }
            }
            if (roomCapacity.Value == 2)
            {
                DataGridViewSelectedRowCollection dt = availableRoomsDatagrid.SelectedRows;
                if (dt.Count == 0)
                {
                    bookRoomErrorlabel.Text = "Please Select a Row";
                    bookRoomErrorlabel.Visible = true;
                }
                else if (isNum2 == false)
                {
                    bookRoomErrorlabel.Text = "Please enter a valid ID in Guest2";
                    bookRoomErrorlabel.Visible = true;
                    return;
                }
                else
                {
                    bookRoomErrorlabel.Visible = false;
                    check = controllerobj.bookRoom(Convert.ToInt32(ID1Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest1BookLabel.Visible = true;
                    }

                    check = controllerobj.bookRoom(Convert.ToInt32(ID2Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest2Booklabel.Visible = true;
                        roomNextButton.Visible = false;
                        doneroombutton.Visible = true;
                        DiscountLabel.Text = DiscountLabel.Text + dt2.Rows[0][0].ToString() + "% Discount";
                        DiscountLabel.Visible = true;
                    }
                }
            }
            if (roomCapacity.Value == 3)
            {
                DataGridViewSelectedRowCollection dt = availableRoomsDatagrid.SelectedRows;
                if (dt.Count == 0)
                {
                    bookRoomErrorlabel.Text = "Please Select a Row";
                    bookRoomErrorlabel.Visible = true;
                }
                else if (isNum3 == false)
                {
                    bookRoomErrorlabel.Text = "Please enter a valid ID in Guest3";
                    bookRoomErrorlabel.Visible = true;
                    return;
                }
                else
                {
                    bookRoomErrorlabel.Visible = false;
                    check = controllerobj.bookRoom(Convert.ToInt32(ID1Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest1BookLabel.Visible = true;
                    }

                    check = controllerobj.bookRoom(Convert.ToInt32(ID2Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest2Booklabel.Visible = true;
                    }

                    check = controllerobj.bookRoom(Convert.ToInt32(ID3Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest3Booklabel.Visible = true;
                        roomNextButton.Visible = false;
                        doneroombutton.Visible = true;
                        DiscountLabel.Text = DiscountLabel.Text + dt2.Rows[0][0].ToString() + "% Discount";
                        DiscountLabel.Visible = true;
                    }
                }
            }
            if (roomCapacity.Value == 4)
            {
                DataGridViewSelectedRowCollection dt = availableRoomsDatagrid.SelectedRows;
                if (dt.Count == 0)
                {
                    bookRoomErrorlabel.Text = "Please Select a Row";
                    bookRoomErrorlabel.Visible = true;
                }
                else if (isNum4 == false)
                {
                    bookRoomErrorlabel.Text = "Please enter a valid ID in Guest4";
                    bookRoomErrorlabel.Visible = true;
                    return;
                }
                else
                {
                    bookRoomErrorlabel.Visible = false;
                    check = controllerobj.bookRoom(Convert.ToInt32(ID1Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest1BookLabel.Visible = true;
                    }

                    check = controllerobj.bookRoom(Convert.ToInt32(ID2Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest2Booklabel.Visible = true;
                    }

                    check = controllerobj.bookRoom(Convert.ToInt32(ID3Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest3Booklabel.Visible = true;
                    }

                    check = controllerobj.bookRoom(Convert.ToInt32(ID4Guest.Text), Convert.ToInt32(dt[0].Cells[0].Value), discount, checkInDate.Value, checkOutDate.Value);
                    if (check != 0)
                    {
                        Guest4Booklabel.Visible = true;
                        roomNextButton.Visible = false;
                        doneroombutton.Visible = true;
                        DiscountLabel.Text = DiscountLabel.Text + dt2.Rows[0][0].ToString() + "% Discount";
                        DiscountLabel.Visible = true;
                    }
                }
            }
        }

        //BOOK HALL 
        private void bookHallButton_Click(object sender, EventArgs e)
        {
            hide_All();
            bookHallCursor.Visible = true;
            bookHallPanel.Visible = true;
        }

        private void searchHallButton_Click(object sender, EventArgs e)
        {
            missingInfoHalls.Visible = false;
            noHallsLabel.Visible = false;

            if (eventType.TextLength < 1)
            {
                missingInfoHalls.Visible = true;
            }
            else
            {
                missingInfoHalls.Visible = false;
                DataTable dt = controllerobj.getavailableHalls(hallDate.Value, Convert.ToInt32(hallCapacity.Text));
                if (dt != null)
                {
                    availableHallsDatagrid.DataSource = dt;
                    availableHallsDatagrid.Refresh();
                    hallsGroupBox.Visible = true;
                    IdForHallsLabel.Visible = true;
                    IdTextboxHalls.Visible = true;
                }
                else
                {
                    noHallsLabel.Visible = true;
                }
            }
        }

        private void hallNextButton_Click_1(object sender, EventArgs e)
        {
            missingIdForHalls.Visible = false;
            errorHallLabel.Visible = false;
            int value = 0;
            bool isNumber = false;
            isNumber = int.TryParse(IdTextboxHalls.Text, out value);
            hallBookedLabel.Visible = false;
            if (IdTextboxHalls.TextLength < 1)
            {
                missingIdForHalls.Visible = true;
            }
            else if (isNumber == false)
            {
                errorHallLabel.Text = "Please enter a valid ID";
                errorHallLabel.Visible = true;
                return;
            }
            else
            {
                dt = controllerobj.searchGuest(Convert.ToInt32(IdTextboxHalls.Text));
                if (dt != null)
                {
                    DataGridViewSelectedRowCollection dt2 = availableHallsDatagrid.SelectedRows;
                    if (dt2.Count == 0)
                    {
                        errorHallLabel.Text = "Please Select A Row";
                        errorHallLabel.Visible = true;
                    }
                    else
                    {
                        int check = controllerobj.bookHall(dt2[0].Cells[0].Value.ToString(), hallDate.Value, eventType.Text, Convert.ToInt32(IdTextboxHalls.Text));
                        if (check == 0)
                        {

                            hallBookedLabel.Visible = false;
                        }
                        else
                        {

                            hallBookedLabel.Visible = true;
                            donehall.Visible = true;
                        }
                    }
                }
                else
                {
                    bookNewGuestPanel.Visible = true;
                    bookNewGuestPanel.BringToFront();
                    idNewGuestTextbox.Text = IdTextboxHalls.Text;
                }

            }

        }

        //BOOK CLUB
        private void bookClubButton_Click(object sender, EventArgs e)
        {
            hide_All();
            bookClubCursor.Visible = true;
            bookClubPanel.Visible = true;
        }

        private void clubNextButton_Click_1(object sender, EventArgs e)
        {
            int value = 0;
            bool isNumber = false;
            isNumber = int.TryParse(IdtextboxForClub.Text, out value);
            FailedToBookClubLabel.Visible = false;
            MissingClubInfoLabel.Visible = false;
            AgeResrtictionLabel.Visible = false;
            BookedClubLabel.Visible = false;
            NonGuestsClubsLabel.Visible = false;
            errorClubsLabel.Visible = false;
            int guestID;
            int guestAge;
            int check = 0;
            bool dateValidation = false;
            int ageRestriction = Convert.ToInt32(controllerobj.getAgeRestrictionForClub(clubNameCombobox.Text).Rows[0][0].ToString());
            if (IdtextboxForClub.TextLength < 1)
            {
                BookedClubLabel.Visible = false;
                AgeResrtictionLabel.Visible = false;
                FailedToBookClubLabel.Visible = false;
                AgeResrtictionLabel.Visible = false;
                NonGuestsClubsLabel.Visible = false;
                errorClubsLabel.Visible = false;
                MissingClubInfoLabel.Visible = true;
            }
            else if (isNumber == false)
            {
                errorClubsLabel.Text = "Please enter a valid ID!";
                errorClubsLabel.Visible = true;
                return;
            }
            else
            {
                guestID = Convert.ToInt32(IdtextboxForClub.Text);
                dt = controllerobj.getGuestAgeFromID(guestID);
                if (dt != null)
                {
                    guestAge = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int numberOfChecks = controllerobj.getNoOfReservationsFromGuestID(guestID);
                    dt = controllerobj.getDatesFromGuestID(guestID);
                    for (int i = 0; i < numberOfChecks; i++)
                    {
                        int check1 = DateTime.Compare(ClubDateTimePicker.Value, Convert.ToDateTime(dt.Rows[i][0]));
                        int check2 = DateTime.Compare(ClubDateTimePicker.Value, Convert.ToDateTime(dt.Rows[i][1]));
                        if (check1 >= 0 && check2 < 0)
                        {
                            dateValidation = true;
                        }
                    }
                    if (dateValidation)
                    {

                        if (guestAge >= ageRestriction)
                        {
                            check = controllerobj.bookClub(Convert.ToInt32(IdtextboxForClub.Text), clubNameCombobox.Text, ClubDateTimePicker.Value);
                            if (check == 0)
                            {
                                MissingClubInfoLabel.Visible = false;
                                BookedClubLabel.Visible = false;
                                AgeResrtictionLabel.Visible = false;
                                NonGuestsClubsLabel.Visible = false;
                                errorClubsLabel.Visible = false;
                                FailedToBookClubLabel.Visible = true;
                            }
                            else
                            {
                                MissingClubInfoLabel.Visible = false;
                                FailedToBookClubLabel.Visible = false;
                                AgeResrtictionLabel.Visible = false;
                                NonGuestsClubsLabel.Visible = false;
                                errorClubsLabel.Visible = false;
                                BookedClubLabel.Visible = true;
                                doneclub.Visible = true;
                            }
                        }
                        else
                        {
                            MissingClubInfoLabel.Visible = false;
                            FailedToBookClubLabel.Visible = false;
                            NonGuestsClubsLabel.Visible = false;
                            BookedClubLabel.Visible = false;
                            errorClubsLabel.Visible = false;
                            AgeResrtictionLabel.Visible = true;
                        }
                    }
                    else
                    {
                        MissingClubInfoLabel.Visible = false;
                        FailedToBookClubLabel.Visible = false;
                        BookedClubLabel.Visible = false;
                        AgeResrtictionLabel.Visible = false;
                        NonGuestsClubsLabel.Visible = false;
                        errorClubsLabel.Text = "Reservation day is not between this guest's check in and check out dates";
                        errorClubsLabel.Visible = true;
                    }
                }
                else
                {
                    MissingClubInfoLabel.Visible = false;
                    FailedToBookClubLabel.Visible = false;
                    BookedClubLabel.Visible = false;
                    AgeResrtictionLabel.Visible = false;
                    errorClubsLabel.Visible = false;
                    NonGuestsClubsLabel.Visible = true;
                }

            }
        }

        //BOOK RESTAURANT
        private void bookRestaurant_Click(object sender, EventArgs e)
        {
            hide_All();
            bookRestaurantCursor.Visible = true;
            bookRestaurantPanel.Visible = true;

        }

        private void restaurantAvailabilityButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(IdForResaurantTextbox.Text, out value);
            ErrorRestaurantLabel.Visible = false;
            BookedResaurantLabel.Visible = false;
            bool dateValidation = false;
            int guestID;
            donerestraunt.Visible = false;
            if (IdForResaurantTextbox.TextLength < 1)
            {
                ErrorRestaurantLabel.Text = "Please Enter A Guest ID";
                ErrorRestaurantLabel.Visible = true;
                BookedResaurantLabel.Visible = false;
            }
            else if (isNum == false)
            {
                ErrorRestaurantLabel.Text = "Please Enter A valid ID";
                ErrorRestaurantLabel.Visible = true;
                return;
            }
            else
            {
                guestID = Convert.ToInt32(IdForResaurantTextbox.Text);
                dt = controllerobj.getGuestAgeFromID(guestID);
                if (dt != null)
                {
                    int numberOfChecks = controllerobj.getNoOfReservationsFromGuestID(guestID);
                    dt = controllerobj.getDatesFromGuestID(guestID);
                    for (int i = 0; i < numberOfChecks; i++)
                    {
                        int check1 = DateTime.Compare(restaurantDate.Value, Convert.ToDateTime(dt.Rows[i][0]));
                        int check2 = DateTime.Compare(restaurantDate.Value, Convert.ToDateTime(dt.Rows[i][1]));
                        if (check1 >= 0 && check2 < 0)
                        {
                            dateValidation = true;
                        }
                    }
                    if (dateValidation)
                    {
                        dt = controllerobj.getRestaurantCapacity(restaurantName.Text);
                        if (controllerobj.getNoOfRestaurantReservations(restaurantName.Text, restaurantDate.Value) < Convert.ToInt32(dt.Rows[0][0]))
                        {
                            int check = controllerobj.bookRestaurant(Convert.ToInt32(IdForResaurantTextbox.Text), restaurantName.Text, restaurantDate.Value);
                            if (check == 0)
                            {
                                ErrorRestaurantLabel.Text = "Guest Can Not Book Twice At The Same Day";
                                ErrorRestaurantLabel.Visible = true;
                                BookedResaurantLabel.Visible = false;
                            }
                            else
                            {
                                ErrorRestaurantLabel.Visible = false;
                                BookedResaurantLabel.Visible = true;
                                donerestraunt.Visible = true;
                            }
                        }
                        else
                        {
                            BookedResaurantLabel.Visible = false;
                            ErrorRestaurantLabel.Text = "Sorry. No Empty Tables";
                            ErrorRestaurantLabel.Visible = true;
                        }
                    }
                    else
                    {
                        BookedResaurantLabel.Visible = false;
                        ErrorRestaurantLabel.Text = "Date is not between check in and check out dates for this guest";
                        ErrorRestaurantLabel.Visible = true;
                    }
                }
                else
                {
                    BookedResaurantLabel.Visible = false;
                    ErrorRestaurantLabel.Text = "Sorry. Non Guests Can Not Book Restaurants";
                    ErrorRestaurantLabel.Visible = true;
                }
            }
        }

        //BOOK ACTIVITY
        private void bookActivityButton_Click(object sender, EventArgs e)
        {
            hide_All();
            bookActivityCursor.Visible = true;
            bookActivityPanel.Visible = true;
        }


        private void activityNextButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(idActivityTextbox.Text, out value);
            ErrorMessageForActivity.Visible = false;
            BookedActivityLabel.Visible = false;
            int guestID;
            bool dateValidation = false;
            if (idActivityTextbox.TextLength < 1)
            {
                ErrorMessageForActivity.Text = "Please Enter Guest ID";
                ErrorMessageForActivity.Visible = true;
                BookedActivityLabel.Visible = false;
            }
            else if (isNum == false)
            {
                ErrorMessageForActivity.Text = "Please enter a valid ID";
                ErrorMessageForActivity.Visible = true;
                return;
            }
            else
            {
                guestID = Convert.ToInt32(idActivityTextbox.Text);
                dt = controllerobj.getGuestAgeFromID(guestID);
                if (dt != null)
                {
                    DataGridViewSelectedRowCollection dt2 = activityDatagrid.SelectedRows;
                    if (dt2.Count == 0)
                    {
                        ErrorMessageForActivity.Text = "Please Select A Row";
                        ErrorMessageForActivity.Visible = true;
                        BookedActivityLabel.Visible = false;
                    }
                    else
                    {
                        int numberOfChecks = controllerobj.getNoOfReservationsFromGuestID(guestID);
                        dt = controllerobj.getDatesFromGuestID(guestID);
                        for (int i = 0; i < numberOfChecks; i++)
                        {
                            int check1 = DateTime.Compare(Convert.ToDateTime(dt2[0].Cells[2].Value), Convert.ToDateTime(dt.Rows[i][0]));
                            int check2 = DateTime.Compare(Convert.ToDateTime(dt2[0].Cells[2].Value), Convert.ToDateTime(dt.Rows[i][1]));
                            if (check1 >= 0 && check2 < 0)
                            {
                                dateValidation = true;
                            }
                        }
                        if (dateValidation)
                        {

                            int check = controllerobj.bookActivity(Convert.ToInt32(idActivityTextbox.Text), Convert.ToDateTime(dt2[0].Cells[2].Value), dt2[0].Cells[0].Value.ToString());
                            if (check == 0)
                            {
                                ErrorMessageForActivity.Text = "Reservation Already Exists";
                                ErrorMessageForActivity.Visible = true;
                                BookedActivityLabel.Visible = false;
                            }
                            else
                            {
                                ErrorMessageForActivity.Visible = false;
                                BookedActivityLabel.Visible = true;
                            }
                        }
                        else
                        {
                            ErrorMessageForActivity.Text = "Date is not between check in and check out dates for this guest";
                            ErrorMessageForActivity.Visible = true;
                            BookedActivityLabel.Visible = false;
                        }
                    }
                }
                else
                {
                    ErrorMessageForActivity.Text = "Non Guests Can Not Book Activities";
                    ErrorMessageForActivity.Visible = true;
                    BookedActivityLabel.Visible = false;
                }

            }
        }
        //REVIEWS

        private void reviewButton_Click(object sender, EventArgs e)
        {
            hide_All();
            reviewCursor.Visible = true;
            cancelPanel.Visible = true;
        }

        //VIEW GUESTLIST
        private void viewGuestbutton_Click(object sender, EventArgs e)
        {
            hide_All();
            viewGuestCursor.Visible = true;
            viewGuestlistPanel.Visible = true;
            Guest_History.Visible = true;
            Guest_History.Refresh();
        }

        //ADD EMPLOYEE
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {


        }

        //View Statistics
        private void statisticsButton_Click(object sender, EventArgs e)
        {
            hide_All();
            statisticsCursor.Visible = true;
            statisticsPanel.Visible = true;
            statisticsViewer.Refresh();
            statisticsViewer.Visible = true;
        }

        //ADD GUEST
        private void AddnewGuestButton_Click(object sender, EventArgs e)
        {
            if (phoneNumTextbox.TextLength == 0 || firstNameTextbox.TextLength == 0 || lastNameTextbox.TextLength == 0)
            {
                FailedToAddGuestLabel.Visible = false;
                invalidNumberLabel.Visible = false;
                IncompleteInfoLabel.Visible = true;

            }
            else if (phoneNumTextbox.TextLength != 11)
            {
                FailedToAddGuestLabel.Visible = false;
                IncompleteInfoLabel.Visible = false;
                invalidNumberLabel.Visible = true;
            }
            else
            {
                int check = controllerobj.addGuest(Convert.ToInt32(idNewGuestTextbox.Text), phoneNumTextbox.Text, emailTextbox.Text, firstNameTextbox.Text, lastNameTextbox.Text, Convert.ToInt32(AgeTextBox.Value));
                if (check == 0)
                {
                    IncompleteInfoLabel.Visible = false;
                    invalidNumberLabel.Visible = false;
                    FailedToAddGuestLabel.Visible = true;
                }
                else
                {
                    bookNewGuestPanel.Visible = false;
                    FailedToAddGuestLabel.Visible = false;
                    IncompleteInfoLabel.Visible = false;
                    invalidNumberLabel.Visible = false;

                    firstNameTextbox.Text = default;
                    lastNameTextbox.Text = default;
                    phoneNumTextbox.Text = default;
                    emailTextbox.Text = default;
                    AgeTextBox.Text = default;
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginWindow login = new loginWindow();
            login.Show();
            this.Close();
        }
        private void hide_All()
        {
            bookRoomCursor.Visible = false;
            bookHallCursor.Visible = false;
            bookClubCursor.Visible = false;
            bookRestaurantCursor.Visible = false;
            bookActivityCursor.Visible = false;
            reviewCursor.Visible = false;
            viewGuestCursor.Visible = false;
            addEmployeeCursor.Visible = false;
            statisticsCursor.Visible = false;
            logoutCursor.Visible = false;

            bookRoomPanel.Visible = false;
            bookHallPanel.Visible = false;
            bookClubPanel.Visible = false;
            bookRestaurantPanel.Visible = false;
            bookActivityPanel.Visible = false;
            cancelPanel.Visible = false;
            viewGuestlistPanel.Visible = false;
            addEmplyeePanel.Visible = false;
            statisticsPanel.Visible = false;




            roomGroupbox.Visible = false;
            hallsGroupBox.Visible = false;
            Guest_History.Visible = false;
            bookNewGuestPanel.Visible = false;

        }

        private void failllabel_Click(object sender, EventArgs e)
        {

        }

        private void Guest2Booklabel_Click(object sender, EventArgs e)
        {

        }

        private void donebutton_Click(object sender, EventArgs e)
        {

            roomCapacity.Value = 1;
            Guest1BookLabel.Visible = false;
            Guest2Booklabel.Visible = false;
            Guest3Booklabel.Visible = false;
            Guest4Booklabel.Visible = false;
            ID1Guest.Text = default;
            ID2Guest.Text = default;
            ID3Guest.Text = default;
            ID4Guest.Text = default;
            roomType.SelectedIndex = 0;
            roomGroupbox.Visible = false;
            doneroombutton.Visible = false;
            DiscountLabel.Visible = false;

        }

        private void bookClubPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgeResrtictionLabel_Click(object sender, EventArgs e)
        {

        }

        private void MissingClubInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeForClubTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeLabelForClub_Click(object sender, EventArgs e)
        {

        }

        private void FailedToBookClubLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookedClubLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IdtextboxForClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void clubDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void clubNamelabel_Click(object sender, EventArgs e)
        {

        }



        private void clubNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClubDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdForHallsLabel_Click(object sender, EventArgs e)
        {

        }

        private void hallBookedLabel_Click(object sender, EventArgs e)
        {

        }

        private void donehall_Click(object sender, EventArgs e)
        {
            hallsGroupBox.Visible = false;
            IdTextboxHalls.Text = default;
            hallCapacity.SelectedIndex = 0;
            eventType.Text = default;
        }

        private void doneclub_Click(object sender, EventArgs e)
        {
            clubNameCombobox.SelectedIndex = 0;
            IdtextboxForClub.Text = default;
            errorClubsLabel.Text = default;
            doneclub.Visible = false;
            MissingClubInfoLabel.Visible = false;
            FailedToBookClubLabel.Visible = false;
            BookedClubLabel.Visible = false;
            AgeResrtictionLabel.Visible = false;
            NonGuestsClubsLabel.Visible = false;
            errorClubsLabel.Visible = false;

        }

        private void AgeTextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idNewGuestTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reviewsDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ID1Guest_Enter_1(object sender, EventArgs e)
        {
            if (flagid1)
            {
                this.ID1Guest.Text = "";
                flagid1 = false;
                this.ID1Guest.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ID2Guest_Enter_1(object sender, EventArgs e)
        {
            if (flagid2)
            {
                this.ID2Guest.Text = "";
                flagid2 = false;
                this.ID2Guest.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ID3Guest_Enter(object sender, EventArgs e)
        {
            if (flagid3)
            {
                this.ID3Guest.Text = "";
                flagid3 = false;
                this.ID3Guest.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void ID4Guest_Enter(object sender, EventArgs e)
        {
            if (flagid4)
            {
                this.ID4Guest.Text = "";
                flagid4 = false;
                this.ID4Guest.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (flagid5)
            {
                this.IdForResaurantTextbox.Text = "";
                flagid5 = false;
                this.IdForResaurantTextbox.StateCommon.Content.Color1 = Color.Black;
            }

        }

        private void idActivityTextbox_Enter(object sender, EventArgs e)
        {
            if (flagid6)
            {
                this.idActivityTextbox.Text = "";
                flagid6 = false;
                this.idActivityTextbox.StateCommon.Content.Color1 = Color.Black;
            }

        }

        private void donerestraunt_Click(object sender, EventArgs e)
        {
            donerestraunt.Visible = false;
            restaurantName.SelectedIndex = 0;
            IdForResaurantTextbox.Text = default;
            BookedResaurantLabel.Visible = false;
            ErrorRestaurantLabel.Visible = false;
        }

        private void IdTextboxHalls_Enter(object sender, EventArgs e)
        {
            if (flagid7)
            {
                this.IdTextboxHalls.Text = "";
                flagid6 = false;
                this.IdTextboxHalls.StateCommon.Content.Color1 = Color.Black;
            }


        }

        private void doneactivity_Click(object sender, EventArgs e)
        {
            doneactivity.Visible = false;
            idActivityTextbox.Text = default;
            activityDatagrid.Visible = false;
            BookedActivityLabel.Visible = false;
            ErrorMessageForActivity.Visible = false;



        }

        private void addEmplyeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isNum = false;
            int value = 0;
            isNum = int.TryParse(employeeIDTextbox.Text, out value);
            addEmployeeErrorLabel.ForeColor = Color.Red;
            addEmployeeErrorLabel.Visible = false;
            if (emplyeePhoneTextbox.TextLength < 1 || employeeFirstNameTextbox.TextLength < 1 || employeeLastNameTextbox.TextLength < 1 || employeeIDTextbox.TextLength < 1 || passwordTextbox.TextLength < 1 || genderCombobox.Text == "")
            {
                addEmployeeErrorLabel.Text = "Please fill all required fields.";
                addEmployeeErrorLabel.Visible = true;
            }
            else if (isNum == false)
            {
                addEmployeeErrorLabel.Text = "Please enter a valid ID!";
                addEmployeeErrorLabel.Visible = true;
                return;
            }
            else if (emplyeePhoneTextbox.TextLength != 11)
            {
                addEmployeeErrorLabel.Text = "Phone number is invalid";
                addEmployeeErrorLabel.Visible = true;

            }
            else
            {
                int check = 0;
                check = controllerobj.addEmployee(employeeIDTextbox.Text, addressTextbox.Text, genderCombobox.Text, emplyeePhoneTextbox.Text, employeeFirstNameTextbox.Text, employeeLastNameTextbox.Text, employeeAgeNum.Value, jobTypeCombobox.Text, passwordTextbox.Text);
                if (check == 0)
                {
                    addEmployeeErrorLabel.Text = "Employee with this ID already exists";
                    addEmployeeErrorLabel.Visible = true;

                }
                else
                {
                    addEmployeeErrorLabel.ForeColor = Color.Green;
                    addEmployeeErrorLabel.Text = "Employee added succesfully";
                    addEmployeeErrorLabel.Visible = true;
                    doneemployee.Visible = true;

                }
            }
        }

        private void addEmployeeButton_Click_1(object sender, EventArgs e)
        {
            hide_All();
            addEmployeeCursor.Visible = true;
            addEmplyeePanel.Visible = true;
        }

        private void doneemployee_Click(object sender, EventArgs e)
        {
            employeeFirstNameTextbox.Text = default;
            employeeLastNameTextbox.Text = default;
            employeeIDTextbox.Text = default;
            addressTextbox.Text = default;
            genderCombobox.SelectedIndex = default;
            emplyeePhoneTextbox.Text = default;
            employeeAgeNum.Value = 18;
            jobTypeCombobox.Text = default;
            passwordTextbox.Text = default;
            doneemployee.Visible = false;

        }

        private void cancelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = controllerobj.getBooked(cancelComboBox.Text);
            itemsOfCancelComboBox.DataSource = dt;
            if (cancelComboBox.Text == "Room_Reservations")
            {
                cancelDatagrid.DataSource = controllerobj.getRoomsBooked();
                itemsOfCancelComboBox.Visible = false;
                cancelDatagrid.Visible = true;
                cancelDatagrid.Refresh();
            }
            else
            {
                itemsOfCancelComboBox.DisplayMember = "Name";
                itemsOfCancelComboBox.Visible = true;
            }



        }

        private void itemsOfCancelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = controllerobj.getBookedTable(cancelComboBox.Text, itemsOfCancelComboBox.Text);
            cancelDatagrid.DataSource = dt;
            cancelDatagrid.Visible = true;
            cancelDatagrid.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            cancelBookingLabel.Visible = false;
            cancelBookingLabel.ForeColor = Color.Red;
            int check = 0;
            DataGridViewSelectedRowCollection dt2 = cancelDatagrid.SelectedRows;
            if (dt2.Count == 0)
            {
                cancelBookingLabel.Text = "Please select a row";
                cancelBookingLabel.Visible = true;
            }
            else
            {
                if (cancelComboBox.Text == "Room_Reservations")
                {
                    check = controllerobj.cancelRoom(Convert.ToInt32(dt2[0].Cells[1].Value.ToString()), Convert.ToInt32(dt2[0].Cells[0].Value.ToString()), Convert.ToDateTime(dt2[0].Cells[3].Value.ToString()));
                    dt = controllerobj.getRoomsBooked();
                    cancelDatagrid.DataSource = dt;
                    itemsOfCancelComboBox.Visible = false;
                    cancelDatagrid.Visible = true;
                    cancelDatagrid.Refresh();
                }
                else
                {
                    check = controllerobj.cancelBooking(cancelComboBox.Text, dt2[0].Cells[0].Value.ToString(), Convert.ToInt32(dt2[0].Cells[1].Value.ToString()), Convert.ToDateTime(dt2[0].Cells[2].Value.ToString()));
                    dt = controllerobj.getBookedTable(cancelComboBox.Text, itemsOfCancelComboBox.Text);
                    cancelDatagrid.DataSource = dt;
                    cancelDatagrid.Visible = true;
                    cancelDatagrid.Refresh();
                }

                if (check == 0)
                {
                    cancelBookingLabel.Text = "Failed to cancel booking";
                    cancelBookingLabel.Visible = true;
                }
                else
                {
                    cancelBookingLabel.ForeColor = Color.Green;
                    cancelBookingLabel.Text = "Booking cancelled";
                    cancelBookingLabel.Visible = true;
                    cancelDatagrid.DataSource = dt;
                    cancelDatagrid.Visible = true;
                    cancelDatagrid.Refresh();

                }
            }

        }
    }

}
