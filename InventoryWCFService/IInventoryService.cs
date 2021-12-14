using InventoryWCFService.InventoryBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalesman" in both code and config file together.
    [ServiceContract]
    public interface ISalesman
    {
        [OperationContract]
         int InsertNewSalesman(SalesmanBO newSalesman);

        [OperationContract]
        int UpdateSalesmanInfo(SalesmanBO newSalesman);

        [OperationContract]
        int DeleteSalesmanInfo(SalesmanBO newSalesman);
    }

    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        int InsertNewCustomer(CustomerBO NewCustomer);

       [OperationContract]
        int UpdateCustomerInfo(CustomerBO NewCustomer);

        [OperationContract]
        int DeleteCustomerInfo(CustomerBO NewCustomer);
    }

    [ServiceContract]
    public interface IOrders
    {
        [OperationContract]
        int InsertNewOrder(OrdersBO NewOrders);

         [OperationContract]
        int UpdateOrdersInfo(OrdersBO NewOrders);

        [OperationContract]
        int DeleteOrdersInfo(OrdersBO NewOrders);
    }
}
