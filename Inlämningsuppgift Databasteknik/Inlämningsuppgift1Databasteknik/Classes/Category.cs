using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämningsuppgift1Databasteknik.Repository;
using Inlämningsuppgift1Databasteknik.Classes;

namespace Inlämningsuppgift1Databasteknik.Classes
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

        public static List<Category> GetCategories()
        {
            return CategoryRepo.GetListOfCategories();
        }
    }
}
