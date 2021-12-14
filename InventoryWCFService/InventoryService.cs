using InventoryWCFService.InventoryBO;
using InventoryWCFService.InventoryDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Salesman" in both code and config file together.
    public class InventoryService : ISalesman, ICustomer, IOrders
    {
        public int InsertNewSalesman(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA salesman = new SalesmanDA();
                return salesman.InsertSalesman(newSalesman);
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateSalesmanInfo(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA salesman = new SalesmanDA();
                return salesman.UpdateSalesman(newSalesman);
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteSalesmanInfo(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA salesman = new SalesmanDA();
                return salesman.DeleteSalesman(newSalesman);
            }
            catch
            {
                return 0;
            }
        }

        public int InsertNewCustomer(CustomerBO NewCustomer)
        {
            try
            {
                CustomerDA customer = new CustomerDA();
                return customer.InsertCustomer(NewCustomer);

            }
            catch
            {
                return 0;
            }
        }

        public int UpdateCustomerInfo(CustomerBO newCustomer)
        {
            try
            {
                CustomerDA customer = new CustomerDA();
                return customer.UpdateCustomer(newCustomer);
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteCustomerInfo(CustomerBO newCustomer)
        {
            try
            {
                CustomerDA customer = new CustomerDA();
                return customer.DeleteCustomer(newCustomer);
            }
            catch
            {
                return 0;
            }
        }

        public int InsertNewOrder(OrdersBO NewOrders)
        {
            try
            {
                OrdersDA order = new OrdersDA();
                return order.InsertOrder(NewOrders);
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateOrdersInfo(OrdersBO newOrder)
        {
            try
            {
                OrdersDA order = new OrdersDA();
                return order.UpdateOrder(newOrder);
            }

            catch
            {
                return 0;
            }
        }

        public int DeleteOrdersInfo(OrdersBO newOrder)
        {
            try
            {
                OrdersDA order = new OrdersDA();
                return order.DeleteOrder(newOrder);
            }

            catch
            {
                return 0;
            }
        }
    }
}
