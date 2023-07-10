using Inventory.Business.Layer.UserRepository;
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
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            bool isValidUser = _userRepository.IfExists(email, password);

            if (isValidUser)
            {
                MasterMDIForm masterForm = new MasterMDIForm();
                masterForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login info", "Invalid Login Error");
            }
        }
    }
}
