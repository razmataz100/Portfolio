using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Inlämningsuppgift1Databasteknik.Repository;

namespace Inlämningsuppgift1Databasteknik.Classes
{
    public class Ad
    {
        public int AdID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price  { get; set; }
        public DateTime Date { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

        public string CategoryName { get; set; }

        public Ad(int adID, string title, string description, int price, DateTime date, int categoryID, int userID)
        {
            AdID = adID;
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            CategoryID = categoryID;
            UserID = userID;
        }

        public void Update()
        {
            AdsRepo.Update(this);
        }

        public void Save()
        {
            AdsRepo.Save(this);
        }

        public void Delete()
        {
            AdsRepo.Delete(this.AdID);
        }

        public string DisplayText()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{Title} \n {Price} kr \n {Date.ToShortDateString()}";
        }
    }
}
