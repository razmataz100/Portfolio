using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Diagnostics.Contracts;

namespace Inlämningsuppgift1
{
    public partial class DetailsForm : Form
    {
        public Contact ChosenContact { get; set; }
        public List<Contact> ContactList{ get; set; }

        public DetailsForm(Contact contact, List<Contact> contactList)
        {
            InitializeComponent();
            ContactList = contactList;
            ChosenContact = contact;
         
            NameTextBox.Text = ChosenContact.Name.Trim();
            StreetAddressTextBox.Text = ChosenContact.StreetAddress.Trim();
            PostalCodeTextBox.Text = ChosenContact.PostalCode.Trim();
            CityTextBox.Text = ChosenContact.City.Trim();
            PhoneTextBox.Text = ChosenContact.Phone.Trim();
            EmailTextBox.Text = ChosenContact.Email.Trim();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim() != "")
            {
                foreach (Contact contact in ContactList)
                {
                    if (contact.Name.Trim() == ChosenContact.Name.Trim() && contact.Email.Trim() == ChosenContact.Email.Trim())
                    {
                        ContactList.Remove(contact);
                        break;
                    }
                }

                string name = NameTextBox.Text;
                string streetAddress = StreetAddressTextBox.Text;
                string postalCode = PostalCodeTextBox.Text;
                string city = CityTextBox.Text;
                string phone = PhoneTextBox.Text;
                string email = EmailTextBox.Text;

                Contact updatedContact = new Contact(name, streetAddress, postalCode, city, phone, email);
                
                ContactList.Add(updatedContact);
                using (StreamWriter writer = new StreamWriter(Adressbok.FilePath(), false))
                {
                    foreach (Contact contact in ContactList)
                    {

                        writer.WriteLine(contact.Name + "," + contact.StreetAddress + "," + contact.PostalCode + "," + contact.City + "," + contact.Phone + "," + contact.Email);
                    }
                }
                MessageBox.Show("Kontakten är uppdaterad");
                this.Close();
            }
            else
            {
                MessageBox.Show("Du måste fylla i ett namn");
            }
        }
    }
}
