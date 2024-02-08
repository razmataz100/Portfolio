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
using Inlämningsuppgift1Databasteknik.Classes;
using Inlämningsuppgift1Databasteknik.Repository;

namespace Inlämningsuppgift1Databasteknik
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            User user = UserRepo.AuthenticateUser(username, password);

            if (user != null)
            {
                LoggedInUser = user;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Du är nu inloggad");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fel användarman eller lösenord. Försök igen");
            }
        }
    }
}
