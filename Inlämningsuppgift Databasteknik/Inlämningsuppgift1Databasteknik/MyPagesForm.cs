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

namespace Inlämningsuppgift1Databasteknik
{
    public partial class MyPagesForm : Form
    {

        private User loggedInUser;
        public MyPagesForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void MyPagesForm_Load(object sender, EventArgs e)
        {
            List<Ad> userAds = AdsRepo.GetAdsByUserID(loggedInUser.UserID);

            listBoxMyAds.DisplayMember = "Title";
            listBoxMyAds.DataSource = userAds;
        }

        private void ShowMyAdDetails()
        {
            if (listBoxMyAds.SelectedItem != null)
            {
                if (listBoxMyAds.SelectedItem is Ad selectedAd)
                {
                    UpdateAdForm updateAdForm = new UpdateAdForm(selectedAd, loggedInUser);
                    if(updateAdForm.ShowDialog() == DialogResult.OK)
                    {
                        List<Ad> userAds = AdsRepo.GetAdsByUserID(loggedInUser.UserID);
 
                        listBoxMyAds.DataSource = userAds;                    
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowMyAdDetails();
        }

        private void listBoxMyAds_DoubleClick(object sender, EventArgs e)
        {
            ShowMyAdDetails();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxMyAds.SelectedItem != null)
            {

                if (listBoxMyAds.SelectedItem is Ad selectedAd)
                {
                    DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort annonsen?", "Bekräftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        selectedAd.Delete();

                        listBoxMyAds.DataSource = AdsRepo.GetAdsByUserID(loggedInUser.UserID);

                        MessageBox.Show("Din annons är nu borttagen");

                    }
                }
            }
        }
    }
}
