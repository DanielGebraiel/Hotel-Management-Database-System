using System;
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
    public partial class Housekeeping : Form
    {
        int id;
        Controller controllerobj;
        public Housekeeping(int i)
        {
            InitializeComponent();
            id = i;
            controllerobj = new Controller();
            staffNameLabel.Text = controllerobj.getStaffNameFromID(id).Rows[0][0].ToString();
            staffNameLabel.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            viewRoomsPanel.Visible = false;
            viewRoomsCursor.Visible = false;
        }

        private void staffNameLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomsToBeCleanedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewRooms_Load(object sender, EventArgs e)
        {

        }

        private void Housekeeping_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.getRooomsToClean(id);
            if (dt == null)
            {
                congratsLabel.Visible = true;
            }
            else
            {
                roomsToBeCleanedGrid.DataSource = dt;
                roomsToBeCleanedGrid.Visible = true;
            }
            //dt = controllerobj.getStaffnameFromId(id);
            //staffNameLabel.Text = dt.Rows[0][0].ToString();
        }

        

        private void homePagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewRoomsbutton_Click(object sender, EventArgs e)
        {
            logOutCursor.Visible = false;
            viewRoomsCursor.Visible = true;
            viewRoomsPanel.Visible = true;

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginWindow login=new loginWindow();
            login.Show();
        }

        private void markCleanButton_Click(object sender, EventArgs e)
        {
            controllerobj.markRoomAsCleaned(Convert.ToInt32(roomsToBeCleanedGrid.SelectedCells[0].Value));
            DataTable dt = controllerobj.getRooomsToClean(id);
            if (dt == null)
            {
                congratsLabel.Visible = true;
                roomsToBeCleanedGrid.Visible = false;
            }
            else
            {
                congratsLabel.Visible = false;
                roomsToBeCleanedGrid.DataSource = dt;
                roomsToBeCleanedGrid.Refresh();
                roomsToBeCleanedGrid.Visible = true;
            }
        }
    }
}
