using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace North_DiamondHotel
{

    public partial class Animation : Form
    {

        int id;
        Controller controllerObj;

        public Animation(int x)
        {
            InitializeComponent();
            controllerObj = new Controller();
            id = x;

            viewshowsbox.Visible = false;
            mainlogo.Visible = true;
            addpanel.Visible = false;
            sidepanel2.Visible = false;
            sidepanel1.Visible = false;
            successLabel.Visible = false;
            faillabel.Visible = false;
            Doneshows.Visible = false;

        }

        private void viewshowsbutton_Click(object sender, EventArgs e)
        {
            viewshowsbox.Visible = true;
            addpanel.Visible = false;
            mainlogo.Visible = false;
            sidepanel2.Visible = false;
            sidepanel1.Visible = true;

            DataTable dt = controllerObj.SelectanimationByID(id);
            dataGridView1.DataSource = dt;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            viewshowsbox.Visible = false;
            addpanel.Visible = true;
            mainlogo.Visible = false;
            sidepanel1.Visible = false;
            sidepanel2.Visible = true;


        }

        private void Typecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)

        {
            string type = controllerObj.GetShowTypeFromID(id).Rows[0][0].ToString();
            int result = controllerObj.Insertshow(type, showDate.Value, Locationcombobox.Text);
            if (result == 0)
            {
                faillabel.Visible = true;

            }
            else
            {
                successLabel.Visible = true;
                Doneshows.Visible = true;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            loginWindow n = new loginWindow();
            n.Show();
            this.Close();
        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void showDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void successLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addpanel.Visible = false;
            viewshowsbox.Visible = false;


        }

        private void Doneshows_Click(object sender, EventArgs e)
        {
            faillabel.Visible = false;
            successLabel.Visible = false;
            Locationcombobox.SelectedIndex = 0;
            showDate.Value = DateTime.Today;
            Doneshows.Visible = false;

        }
    }
}
