using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWCFService.InventoryBO
{
    public class OrdersBO
    {
           //declaring variable
            private int _OrderNo;
            private float _PurchAmt;
            private DateTime _OrderDate;
            private int _CustomerId;
            private int _SalesmanId;

            //set getter setter method

            public int OrderNo
            {
                get
                {
                    return _OrderNo;
                }
                set
                {
                    _OrderNo = value;
                }
            }
            public float PurchAmt
            {
                get
                {
                    return _PurchAmt;
                }
                set
                {
                    _PurchAmt = value;
                }
            }
            public DateTime OrderDate
            {
                get
                {
                    return _OrderDate;
                }
                set
                {
                    _OrderDate = value;
                }
            }
            public int CustomerId
            {
                get
                {
                    return _CustomerId;
                }
                set
                {
                    _CustomerId = value;
                }
            }
            public int SalesmanId
            {
                get
                {
                    return _SalesmanId;
                }
                set
                {
                    _SalesmanId = value;
                }
            }
        
    }
}
