using Inventory.Business.Layer.UserRepository;
using InventoryApp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class LoginForm : Form
    {

        private readonly UserRepository _userRepository = new UserRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            bool isValidUser = _userRepository.IfExists(email, password);
            DataTable dt = _userRepository.GetUserByEmail(email);

            if (isValidUser)
            {
                DataRow row = dt.Rows[0];
                SessionHelper.UserName = row["FirstName"].ToString();
                SessionHelper.UserRole = row["UserRole"].ToString();
                SessionHelper.UserID = Convert.ToInt32(row["UserID"].ToString());


                MasterMDIForm masterForm = new MasterMDIForm();
                masterForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login info", "Invalid Login Error");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btnLogin_Click(sender, e); calling the method below instead
                LoginUser();
            }
        }
    }
}
