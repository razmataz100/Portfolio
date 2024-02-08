using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Inlämningsuppgift1.Classes
{
    public class Contact
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ShowingString { get; set; }


        public Contact(string name, string streetAddress, string postalCode, string city, string phone, string email)
        {
            Name = name;
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
            Email = email;
            FullContact();
        }

        public void FullContact()
        {
            ShowingString = Name + " " + StreetAddress + " " + PostalCode + " " + City + " " + Phone + " " + Email;
        }
    }

}
