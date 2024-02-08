using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämningsuppgift1Databasteknik.Classes;

namespace Inlämningsuppgift1Databasteknik.Repository
{
    public static class CategoryRepo
    {

        public static List<Category> GetListOfCategories()
        {
            string sql = "select CategoryID, CategoryName from Categories";

            DataTable data = Datahandler.ExecuteReturnTable(sql, new List<SqlParameter>());

            List<Category> list = new List<Category>();

            foreach (DataRow row in data.Rows)
            {
                list.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }

            return list;
        }

        public static string GetCategoryNameByID(int categoryID)
        {
            string sql = "select CategoryName from categories where CategoryID = @CategoryID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@CategoryID", categoryID)
            };

            DataTable data = Datahandler.ExecuteReturnTable(sql, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return row["CategoryName"].ToString();
            }
            return null;
        }
    }
}
