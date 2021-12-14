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
    class CustomerDA
    {
        SqlConnection _sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConn"].ConnectionString);

        public int InsertCustomer(CustomerBO customer)
        {
            try
            {
                string query = $"INSERT INTO customer (customer_id, cust_name, city, grade, salesman_id) VALUES ({customer.CustomerId},'{customer.name}','{customer.city}',{customer.grade},{customer.SalesmanId});";
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

        public int UpdateCustomer(CustomerBO customer)
        {
            try
            {
                string query = $"Update customer SET cust_name ='{customer.name}', city = '{customer.city}', grade = {customer.grade}, salesman_id = {customer.SalesmanId} where customer_id = {customer.CustomerId};";
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

        public int DeleteCustomer(CustomerBO customer)
        {
            try
            {
                string query = $"delete from customer where customer_id = {customer.CustomerId};";
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
