using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift1Databasteknik.Classes;
using Inlämningsuppgift1Databasteknik.Repository;
using static System.Collections.Specialized.BitVector32;

namespace Inlämningsuppgift1Databasteknik
{
    public partial class AddForm : Form
    {
        public User LoggedInUser { get; set; }

        public AddForm(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string title = textBoxTitle.Text;
            string description = TextBoxDescription.Text;
            DateTime date = DateTime.Today;
            int price = int.Parse(textBoxPrice.Text);

            Category selectedCategory = (Category)comboBoxCategory.SelectedItem;
            int categoryId = selectedCategory.CategoryID;
  
            Ad ad = new Ad(0,title, description, price, date, categoryId, LoggedInUser.UserID);
            ad.Save();

            MessageBox.Show("Din annons är nu uppladdad");
            this.Close();

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            List<Category> categories = Category.GetCategories();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
        }
    }
}



