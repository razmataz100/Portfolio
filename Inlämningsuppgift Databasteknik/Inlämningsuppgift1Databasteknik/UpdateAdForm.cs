using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift1Databasteknik.Classes;
using Inlämningsuppgift1Databasteknik.Repository;

namespace Inlämningsuppgift1Databasteknik
{
    public partial class UpdateAdForm : Form
    {
        private Ad adToUpdate;
        private User loggedInUSer;
        private List<Ad> userAds;

        public UpdateAdForm(Ad ad, User user)
        {
            InitializeComponent();
            adToUpdate = ad;
            loggedInUSer = user;
            userAds = this.userAds;

            textBoxTitle.Text = adToUpdate.Title;
            textBoxPrice.Text = adToUpdate.Price.ToString();
            textBoxDescription.Text = adToUpdate.Description;
        }

        private void UpdateAdForm_Load(object sender, EventArgs e)
        {
            List<Category> categories = Category.GetCategories();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
        }

        private void btnUpdateAd_Click(object sender, EventArgs e)
        {
            string updatedTitle = textBoxTitle.Text;
            string updatedDescription = textBoxDescription.Text;
            
            if ((!int.TryParse(textBoxPrice.Text.Trim(), out int updatedPrice)))
                {
                MessageBox.Show("Priset måste vara en siffra");
                return;
            }

            if (comboBoxCategory.SelectedItem is Category selectedCategory)
            {
                int updatedCategoryID = selectedCategory.CategoryID;

                adToUpdate.Title = updatedTitle;
                adToUpdate.Description = updatedDescription;
                adToUpdate.Price = updatedPrice;
                adToUpdate.CategoryID = updatedCategoryID;

                adToUpdate.Update();

                if (userAds != null)
                {
                    int index = userAds.FindIndex(ad => ad.AdID == adToUpdate.AdID);
                    if (index != -1)
                    {
                        userAds[index] = adToUpdate;
                    }
                }

                MessageBox.Show("Din annons är nu uppdaterad");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
