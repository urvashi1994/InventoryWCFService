using InventoryWCFService.InventoryBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace InventoryWCFService.InventoryDA
{
    public class SalesmanDA
    {


        SqlConnection _sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConn"].ConnectionString);
        public int InsertSalesman(SalesmanBO salesman)
        {
            try
            {
                string query = $"insert into salesman (salesman_id, name, city, commission)values({salesman.SalesmanId},'{salesman.Name}','{salesman.City}',{salesman.Commission});";
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

        public int UpdateSalesman(SalesmanBO salesman)
        {

            try
            {
                string query = $"Update salesman SET name = '{salesman.Name}', city = '{salesman.City}', commission = {salesman.Commission} where salesman_id = {salesman.SalesmanId};";
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

        public int DeleteSalesman(SalesmanBO salesman)
        {

            try
            {
                string query = $"delete from salesman where salesman_id = {salesman.SalesmanId};";
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
