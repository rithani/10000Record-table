using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thousand.Models;

namespace thousand.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        
         public ActionResult Table()
        {
            DataTable dataTable = Details();



            List<Sale> purchaseList = new List<Sale>();
            foreach (DataRow row in dataTable.Rows)
            {
                Sale purchase1 = new Sale()
                {
                    Region = Convert.ToString(row["Region"]),
                    Country = Convert.ToString(row["Country"]),
                    ItemType = Convert.ToString(row["Item Type"]),
                    SalesChannel = Convert.ToString(row["Sales Channel"]),
                    OrderPriority = Convert.ToString(row["Order Priority"]),
                    OrderDate = Convert.ToDateTime(row["Order Date"]),
                    OrderId = Convert.ToInt32(row["Order Id"]),
                    UnitsSold = Convert.ToInt32(row["Units Sold"]),
                    Shipdate = Convert.ToDateTime(row["Ship date"]),
                    UnitPrice = Convert.ToInt32(row["Unit Price"]),
                    UnitCost = Convert.ToInt32(row["Unit Cost"]),
                    TotalRevenue = Convert.ToInt32(row["Total Revenue"]),
                    TotalCost = Convert.ToInt32(row["Total Cost"]),
                    TotalProfit = Convert.ToInt32(row["Total Profit"])

                };
                purchaseList.Add(purchase1);
            }


            return View(purchaseList);



        }
        DataTable Details()
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-2UL7R6Q;Initial Catalog=GridView;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("select * from SaleRecord", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // Massive data reads
            //while (sqlDataReader.Read())
            //{
            //    int categoryId = Convert.ToInt32(sqlDataReader.GetValue(0)); // CategoryId
            //}

            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            return dt;
        }

    }
}
