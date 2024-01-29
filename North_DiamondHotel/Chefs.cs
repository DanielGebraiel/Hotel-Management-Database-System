using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace North_DiamondHotel
{
    public partial class Chefs : KryptonForm
    {
        Controller controllerobj;
        int id;
        string RestaurantName;
        public Chefs(int i)
        {
            InitializeComponent();
            viewGuestSelector.Hide();
            orderFoodSelector.Hide();
            viewGuestsPanel.Hide();
            orderFoodPanel.Hide();
            LogOutSelector.Visible = false;
            InvalidAmountLabel.Visible = false;
            OrderLabel.Visible = false;
            controllerobj = new Controller();
            id = i;
            RestaurantName = controllerobj.getRestaurantNameFromChefId(id).Rows[0][0].ToString();
        }

        private void viewGuestsButton_Click(object sender, EventArgs e)
        {
            viewGuestsPanel.Show();
            viewGuestSelector.Show();
            orderFoodSelector.Hide();
            orderFoodPanel.Hide();
        }

        private void orderFoodButton_Click(object sender, EventArgs e)
        {
            viewGuestsPanel.Hide();
            viewGuestSelector.Hide();
            orderFoodSelector.Show();
            orderFoodPanel.Show();
        }

        private void Chefs_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.getFoodTypes();
            foodTypeComboBox.DataSource = dt;
            foodTypeComboBox.DisplayMember = "Type";
            NoOfReservations.Text = controllerobj.getNoOfRestaurantReservations(RestaurantName,DateTime.Today).ToString();
            nameLabel.Text = controllerobj.getStaffNameFromID(id).Rows[0][0].ToString();
        }

        private void foodTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string FoodType = foodTypeComboBox.Text;
            int amount = (int)QuantityNumericUpDown.Value;
            if (amount < 1)
            {
                InvalidAmountLabel.Visible = true;
                OrderLabel.Visible = false;
            }
            else
            {
                InvalidAmountLabel.Visible = false;
                controllerobj.insertRestaurantOrder(RestaurantName, amount, FoodType);
                OrderLabel.Visible = true;
            }
        }

        private void orderFoodPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            viewGuestsPanel.Visible = false;
            orderFoodPanel.Visible = false;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOutSelector.Visible = true;
            loginWindow LoginW = new loginWindow();
            LoginW.Show();
            this.Close();
        }
    }
}
