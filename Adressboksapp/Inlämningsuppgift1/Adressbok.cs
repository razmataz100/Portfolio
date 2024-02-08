using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Inlämningsuppgift1.Classes;

namespace Inlämningsuppgift1
{
    public partial class Adressbok : Form
    {
        public List<Contact> addressBookContactList;

        public Adressbok()
        {
            InitializeComponent();
            addressBookContactList = new List<Contact>();
            listBox.DisplayMember = "ShowingString";
        }
        public static string FilePath()
        {
            return @"C:\Nackademin\Adressbok.txt";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchedName = SearchNameTextBox.Text;
            string searchedCity = SearchCityTextBox.Text;
            string row;
            bool foundContacts = false;

            listBox.Items.Clear();
            addressBookContactList.Clear();
            using (StreamReader reader = new StreamReader(Adressbok.FilePath()))
            {
                while ((row = reader.ReadLine()) != null)
                {
                    string[] rowToContact = row.Split(',');
                    Contact searchedContact = new Contact(rowToContact[0], rowToContact[1], rowToContact[2], rowToContact[3], rowToContact[4], rowToContact[5]);
                    addressBookContactList.Add(searchedContact);

                    if ((rowToContact[0].ToLower().Contains(searchedName.ToLower())) && (rowToContact[3].ToLower().Contains(searchedCity.ToLower())))
                    {
                        listBox.Items.Add(searchedContact);
                        foundContacts = true;
                    }
                }
            }
            if (!foundContacts)
            {
                MessageBox.Show("Kunde inte hitta kontakten");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            if (listBox.SelectedIndex != -1)
            {
                Contact selectedContact = listBox.SelectedItem as Contact;

                DetailsForm detailsForm = new DetailsForm(selectedContact, addressBookContactList);
                detailsForm.ShowDialog();

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                Contact selectedContact = listBox.SelectedItem as Contact;

                if (addressBookContactList != null)
                {
                    addressBookContactList.Remove(selectedContact);
                }
                //Töm listboxen från vald kontakt.
                listBox.Items.Remove(selectedContact);
             
                using (StreamWriter writer = new StreamWriter(Adressbok.FilePath(), false))
                {
                    foreach (Contact contact in addressBookContactList)
                    {
                        writer.WriteLine($"{contact.Name},{contact.StreetAddress},{contact.PostalCode},{contact.City},{contact.Phone},{contact.Email}");
                    }
                }
                MessageBox.Show("Kontakten har tagits bort.");
            }
        }
    }
}
