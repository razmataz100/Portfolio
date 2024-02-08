using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inlämningsuppgift1Databasteknik.Repository;
using Inlämningsuppgift1Databasteknik.Classes;


namespace Inlämningsuppgift1Databasteknik
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Lösenorden matchar inte. Försök igen.");
                return;
            }
            if (!UserRepo.IsUsernameUnique(username))
            {
                MessageBox.Show("Användarnamnet är upptaget. Välj ett annat användarnamn");
                return;
            }

            User user = new User(0, username, password);
            User.SaveNewUser(user);

            MessageBox.Show("Ny användare registrerad!");
            this.Close();
        }
    }
}
