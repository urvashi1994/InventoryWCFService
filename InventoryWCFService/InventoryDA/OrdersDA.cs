using InventoryWCFService.InventoryBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWCFService.InventoryDA
{
    class OrdersDA
    {
        SqlConnection _sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConn"].ConnectionString);

        public int InsertOrder(OrdersBO order)
        {
            try
            {
                string query = $"insert into orders (order_no, purch_amt, ord_date, customer_id, salesman_id) values ({order.OrderNo},{order.PurchAmt},'{order.OrderDate}',{order.CustomerId},{order.SalesmanId});";
                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                _sqlconnection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }

        }


        public int UpdateOrder(OrdersBO order)
        {
            try
            {
                string query = $"update orders set purch_amt = {order.PurchAmt}, ord_date = '{order.OrderDate}', customer_id = {order.CustomerId}, salesman_id = {order.SalesmanId} where order_no = {order.OrderNo};";
                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                _sqlconnection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteOrder(OrdersBO order)
        {

            try
            {
                string query = $"delete from orders where order_no = {order.OrderNo};";
                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                _sqlconnection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
