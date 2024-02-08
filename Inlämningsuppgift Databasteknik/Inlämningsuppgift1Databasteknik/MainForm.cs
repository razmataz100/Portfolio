using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift1Databasteknik.Repository;
using Inlämningsuppgift1Databasteknik.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;

namespace Inlämningsuppgift1Databasteknik
{
    public partial class MainForm : Form
    {
        private User loggedInUser;
        private bool sortByColumnAscending = true;
        private int sortColumnIndex = -1;

        public MainForm()
        {
            InitializeComponent();
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new RegisterUserForm();
            registerUserForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loggedInUser != null)
            {
                LogOut();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loggedInUser = loginForm.LoggedInUser;
                    UpdateUI();
                }
            }
        }

        private void LogOut()
        {
            loggedInUser = null;
            UpdateUI();
            MessageBox.Show("Du är nu utloggad");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (loggedInUser != null)
            {
                AddForm addform = new AddForm(loggedInUser);
                addform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Du måste vara inloggad för att lägga in en ny annons");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewAds.Items.Clear();
            string searchString = textBoxSearch.Text;
            int selectedCategoryID;

            if (cbCategories.SelectedIndex != -1)
            {
                selectedCategoryID = (int)cbCategories.SelectedValue;
            }
            else
            {
                selectedCategoryID = -1;
            }

            List<Ad> searchResults = AdsRepo.SearchAds(selectedCategoryID, searchString);

            DisplayAdsInListView(searchResults);
        }

        private void DisplayAdsInListView(List<Ad> ads)
        {
            listViewAds.Items.Clear();
            
            foreach(var ad in ads)
            {
                ListViewItem item = new ListViewItem(ad.Title);
                item.SubItems.Add(ad.Price.ToString("C", CultureInfo.CurrentCulture));
                item.SubItems.Add(ad.Date.ToShortDateString());
                item.Tag = ad.AdID; 
                listViewAds.Items.Add(item);
            }
        }

        private void UpdateUI()
        {
            if (loggedInUser != null)
            {
                btnLogin.Text = "Logga ut";
                btnMyPages.Visible = true;
                btnAdd.Visible = true;
                btnCreateUser.Visible = false;
            }
            else
            {
                btnLogin.Text = "Logga in";
                btnMyPages.Visible = false;
                btnAdd.Visible = false;
                btnCreateUser.Visible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            List<Category> categories = Category.GetCategories();

            Category allCategoriesOption = new Category(-1, "");

            categories.Insert(0, allCategoriesOption);
            cbCategories.DataSource = categories;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";

            InitializeListView();

            UpdateUI();
        }

        private void InitializeListView()
        {
            listViewAds.View = View.Details;
            listViewAds.Columns.Add("Titel", 100);
            listViewAds.Columns.Add("Pris", 100);
            listViewAds.Columns.Add("Datum", 100);
        }

        private void DisplayAdDetails()
        {
            if (listViewAds.SelectedItems.Count > 0)
            {
                ListViewItem selectedListItem = listViewAds.SelectedItems[0];

                if (selectedListItem.Tag is int adID)
                {
                    Ad detailedAd = AdsRepo.GetAdDetails(adID);
                    string username = UserRepo.GetUsernameByUserID(detailedAd.UserID);
                    string categoryName = CategoryRepo.GetCategoryNameByID(detailedAd.CategoryID);

                    MessageBox.Show($"{detailedAd.Title}\nPris: {detailedAd.Price}kr\n\n{detailedAd.Description}\n\nDatum uppladdat: {detailedAd.Date.ToShortDateString()}\nKategori: {categoryName}\nAnvändare: {username}");
                }
            }
            else
            {
                MessageBox.Show("Du måste välja en annons från listan");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            DisplayAdDetails();
        }

        private void listViewAds_DoubleClick(object sender, EventArgs e)
        {
            DisplayAdDetails();
        }

        private void btnMyPages_Click(object sender, EventArgs e)
        {
            MyPagesForm myPagesForm = new MyPagesForm(loggedInUser);
            myPagesForm.ShowDialog();
        }

        private void listViewAds_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            List<Ad> ads = AdsRepo.SearchAds((int)cbCategories.SelectedValue, textBoxSearch.Text);

            if (e.Column == sortColumnIndex)
            {
                sortByColumnAscending = !sortByColumnAscending;
            }
            else
            {
                sortByColumnAscending = true;
                sortColumnIndex = e.Column;
            }

            switch (e.Column)
            {
                case 0:
                    ads = sortByColumnAscending ? ads.OrderBy(ad => ad.Title).ToList() : ads.OrderByDescending(ad => ad.Title).ToList();
                    break;
                case 1:
                    ads = sortByColumnAscending ? ads.OrderBy(ad => ad.Price).ToList() : ads.OrderByDescending(ad => ad.Price).ToList();
                    break;
                case 2: 
                    ads = sortByColumnAscending ? ads.OrderBy(ad => ad.Date).ToList() : ads.OrderByDescending(ad => ad.Date).ToList();
                    break;
            }

            DisplayAdsInListView(ads);
            sortColumnIndex = e.Column;
        }
    }
}
