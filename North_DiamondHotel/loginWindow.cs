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
using North_DiamondHotel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace North_DiamondHotel
{
    public partial class loginWindow : KryptonForm
    {
        Controller controllerObj;
        public loginWindow()
        {
            InitializeComponent();
            controllerObj = new Controller();
            ChangePasswordPanel.Hide();
        }

        bool firstTimeEditIDflag = true;
        bool firstTimeEditPasswordflag = true;
        bool firstTimeEditChangePasswordIDFlag = true;
        bool firstTimeEditOldPasswordFlag = true;
        bool firstTimeEditNewPasswordFlag = true;

        private void idTextbox_Enter(object sender, EventArgs e)
        {
            if (firstTimeEditIDflag)
            {
                this.idTextbox.Text = "";
                firstTimeEditIDflag = false;
                this.idTextbox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (firstTimeEditPasswordflag)
            {
                this.passwordTextbox.Text = "";
                firstTimeEditPasswordflag = false;
                this.passwordTextbox.UseSystemPasswordChar = true;
                this.passwordTextbox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (idTextbox.Text == "" || idTextbox.Text == "Enter your ID here...")
            {
                errorMessage.Text = "Please enter your ID!";
                errorMessage.Visible = true;
                return;
            }

            if (passwordTextbox.Text == "" || passwordTextbox.Text == "Enter your password here...")
            {
                errorMessage.Text = "Please enter your Password!";
                errorMessage.Visible = true;
                return;
            }

            DataTable dt = controllerObj.GetPasswordandJobTypeFromID(idTextbox.Text);

            if (dt != null)
            {
                if (passwordTextbox.Text == dt.Rows[0][0].ToString())
                {
                    switch (dt.Rows[0][1].ToString())
                    {
                        case "Manager":
                            managerWindow man = new managerWindow(0, Convert.ToInt32(idTextbox.Text));
                            man.Show();
                            break;

                        case "Receptionist":
                            managerWindow rec = new managerWindow(1, Convert.ToInt32(idTextbox.Text));
                            rec.Show();
                            break;

                        case "Chef":
                            Chefs ch = new Chefs(Convert.ToInt32(idTextbox.Text));
                            ch.Show();
                            break;

                        case "Housekeeping":
                            Housekeeping hk = new Housekeeping(Convert.ToInt32(idTextbox.Text));
                            hk.Show();
                            break;

                        case "Animation":
                            Animation an = new Animation(Convert.ToInt32(idTextbox.Text));
                            an.Show();
                            break;
                    }
                    this.Hide();
                }
            }
            errorMessage.Text = "Error! Incorrect ID or Password";
            errorMessage.Visible = true;
            return;
        }

        private void idTextbox_Leave(object sender, EventArgs e)
        {
            if (idTextbox.Text == "")
            {
                idTextbox.Text = "Enter your ID here...";
                firstTimeEditIDflag = true;
                idTextbox.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void passwordTextbox_Leave(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "")
            {
                passwordTextbox.Text = "Enter your password here...";
                firstTimeEditPasswordflag = true;
                passwordTextbox.UseSystemPasswordChar = false;
                passwordTextbox.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChangePasswordPanel.Hide();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordPanel.Show();
        }

        private void idChangePasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (firstTimeEditChangePasswordIDFlag)
            {
                idChangePasswordTextBox.Text = "";
                firstTimeEditChangePasswordIDFlag = false;
                idChangePasswordTextBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void oldPasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (firstTimeEditOldPasswordFlag)
            {
                oldPasswordTextbox.Text = "";
                firstTimeEditOldPasswordFlag = false;
                oldPasswordTextbox.UseSystemPasswordChar = true;
                oldPasswordTextbox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void newPasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (firstTimeEditNewPasswordFlag)
            {
                newPasswordTextbox.Text = "";
                firstTimeEditNewPasswordFlag = false;
                newPasswordTextbox.UseSystemPasswordChar = true;
                newPasswordTextbox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void idChangePasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (idChangePasswordTextBox.Text == "")
            {
                idChangePasswordTextBox.Text = "Enter your ID here...";
                firstTimeEditChangePasswordIDFlag = true;
                idChangePasswordTextBox.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void oldPasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (oldPasswordTextbox.Text == "")
            {
                oldPasswordTextbox.Text = "Enter your old password here...";
                firstTimeEditOldPasswordFlag = true;
                oldPasswordTextbox.UseSystemPasswordChar = false;
                oldPasswordTextbox.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void newPasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextbox.Text == "")
            {
                newPasswordTextbox.Text = "Enter your new password here...";
                firstTimeEditNewPasswordFlag = true;
                newPasswordTextbox.UseSystemPasswordChar = false;
                newPasswordTextbox.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void changeToNewPasswordButton_Click(object sender, EventArgs e)
        {
            if (idChangePasswordTextBox.Text == "" || idChangePasswordTextBox.Text == "Enter your ID here...")
            {
                errortextChangePassword.StateCommon.Content.Color1 = Color.Red;
                errortextChangePassword.Text = "Please enter your ID!";
                errortextChangePassword.Visible = true;
                return;
            }

            if (oldPasswordTextbox.Text == "" || oldPasswordTextbox.Text == "Enter your old password here...")
            {
                errortextChangePassword.StateCommon.Content.Color1 = Color.Red;
                errortextChangePassword.Text = "Please enter your old Password!";
                errortextChangePassword.Visible = true;
                return;
            }

            if (oldPasswordTextbox.Text == "" || newPasswordTextbox.Text == "Enter your new password here...")
            {
                errortextChangePassword.StateCommon.Content.Color1 = Color.Red;
                errortextChangePassword.Text = "Please enter your new Password!";
                errortextChangePassword.Visible = true;
                return;
            }

            DataTable dt = controllerObj.GetPasswordandJobTypeFromID(idChangePasswordTextBox.Text);

            if (dt != null)
            {
                if (oldPasswordTextbox.Text == dt.Rows[0][0].ToString())
                {
                    int check = controllerObj.UpdatePasswordFromID(idChangePasswordTextBox.Text, newPasswordTextbox.Text);
                    if (check > 0)
                    {
                        errortextChangePassword.StateCommon.Content.Color1 = Color.Green;
                        errortextChangePassword.Text = "The Password has been updated sucessfully";
                        errortextChangePassword.Visible = true;
                        return;
                    }
                }
                else
                {
                    errortextChangePassword.Text = "Error! Incorrect ID or Password";
                    errortextChangePassword.Visible = true;
                    return;
                }
            }
            else
            {
                errorMessage.Text = "Error! Incorrect ID or Password";
                errorMessage.Visible = true;
                return;
            }

        }

        private void ChangePasswordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginWindow_Load(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.UseSystemPasswordChar == false)
            {
                passwordTextbox.UseSystemPasswordChar = true;

            }
            else
            {
                passwordTextbox.UseSystemPasswordChar = false;
            }
        }
    }
}
