using System;
using System.IO;
using System.Windows.Forms;
using Inlämningsuppgift1.Classes;

namespace Inlämningsuppgift1
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private void btnSpara_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text.Length > 1)
            {
                string name = NameTextBox.Text;
                string streetAddress = StreetAddressTextBox.Text;
                string postalCode = PostalCodeTextBox.Text;
                string city = CityTextBox.Text;
                string phone = PhoneTextBox.Text;
                string email = EmailTextBox.Text;

                Contact contactToAdd = new Contact(name, streetAddress, postalCode, city, phone, email);

                using (StreamWriter writer = new StreamWriter(Adressbok.FilePath(), true))
                {
                    writer.WriteLine($"{contactToAdd.Name}, {contactToAdd.StreetAddress}, {contactToAdd.PostalCode}, {contactToAdd.City}, {contactToAdd.Email}, {contactToAdd.Phone}");
                    MessageBox.Show("Adressen är sparad");
                }
            }
            else
            {
                MessageBox.Show("Kontakten måste ha ett namn");
            }
        }
    }
}
