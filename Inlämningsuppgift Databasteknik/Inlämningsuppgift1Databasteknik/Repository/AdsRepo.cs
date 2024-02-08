using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Inlämningsuppgift1Databasteknik.Classes;
using System.Data;
using System.Security.Cryptography;

namespace Inlämningsuppgift1Databasteknik.Repository
{
    public class AdsRepo
    {
        public static void Save(Ad ad)
        {
            string sql = "Insert into ads" +
                "(Title, Description, Price, Date, CategoryID, UserID) " +
                "values(@Title, @Description, @Price, @Date, @CategoryID, @UserID)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Title", ad.Title));
            parameters.Add(new SqlParameter("@Description", ad.Description));
            parameters.Add(new SqlParameter("@Price", ad.Price));
            parameters.Add(new SqlParameter("@Date", ad.Date));
            parameters.Add(new SqlParameter("@CategoryID", ad.CategoryID));
            parameters.Add(new SqlParameter("@UserID", ad.UserID));

            Datahandler.ExecuteNonQuery(sql, parameters);
        }

        public static void Update(Ad ad)
        {
            string sql = "UPDATE Ads " + "SET Title = @Title, Description = @Description, " + "Price = @Price, CategoryID = @CategoryID " + "WHERE AdID = @AdID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@AdID", ad.AdID));
            parameters.Add(new SqlParameter("@Title", ad.Title));
            parameters.Add(new SqlParameter("@Description", ad.Description));
            parameters.Add(new SqlParameter("@Price", ad.Price));
            parameters.Add(new SqlParameter("@CategoryID", ad.CategoryID));

            Datahandler.ExecuteNonQuery(sql, parameters);
        }

        public static void Delete(int adID)
        {
            string sql = "DELETE FROM ads WHERE AdID = @AdID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@AdID", adID));

            Datahandler.ExecuteNonQuery(sql, parameters);
        }

        public static List<Ad> SearchAds(int categoryID, string searchString)
        {
            string sql;

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@SearchString", "%" + searchString + "%")
            };

            if(categoryID == -1)
            {
                sql = "select * from ads where title like @searchstring or description like @searchstring";
            }
            else
            {
                sql = "select * from ads where categoryID =@CategoryID and (title like @searchstring or description like @searchstring)";
                parameters.Add(new SqlParameter("@CategoryID", categoryID));
            }

            DataTable data = Datahandler.ExecuteReturnTable(sql, parameters);

            List<Ad> searchResults = new List<Ad>();

            foreach (DataRow row in data.Rows)
            {
                int adID = (int)row["AdID"];
                string title = row["Title"].ToString();
                string description = row["Description"].ToString();
                int price = (int)row["Price"];
                DateTime date = (DateTime)row["Date"];
                int userID = (int)row["UserID"];

                searchResults.Add(new Ad(adID, title, description, price, date, categoryID, userID));
            }

            return searchResults;
        }

        public static Ad GetAdDetails(int adID)
        {
            string sql = "select * from ads where adID = @AdID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@AdID", adID)
            };

            DataTable data = Datahandler.ExecuteReturnTable (sql, parameters);
           
            if(data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                int adIDFromDB = (int)row["AdID"];
                string title = row["Title"].ToString();
                string description = row["Description"].ToString();
                int price = (int)row["Price"];
                DateTime date = (DateTime)row["Date"];
                int categoryID = (int)row["CategoryID"];
                int userID = (int)row["UserID"];

                return new Ad(adIDFromDB, title, description, price, date, categoryID, userID);
            }
            return null;
        }


        public static List<Ad> GetAdsByUserID(int userID)
        {
            string sql = "select * from ads where UserID = @UserID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };

            DataTable data = Datahandler.ExecuteReturnTable(sql, parameters);

            List<Ad> userAds = new List<Ad>();

            foreach (DataRow row in data.Rows)
            {
                Ad ad = new Ad(
                    adID: (int)row["AdID"],
                    title: (string)row["Title"],
                    description: (string)row["Description"],
                    price: (int)row["Price"],
                    date: (DateTime)row["Date"],
                    categoryID: (int)row["CategoryID"],
                    userID: (int)row["UserID"]
                );


                ad.CategoryName = CategoryRepo.GetCategoryNameByID(ad.CategoryID);

                userAds.Add(ad);
            }
            return userAds;

        }      
    }
}
