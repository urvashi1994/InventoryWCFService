using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWCFService.InventoryBO
{
    public class CustomerBO
    {
        //Declaring Customer Registration variables
        private int _CustomerId;
        private string _name;
        private string _city;
        private int _grade;
        private int _SalesmanId;

        //Get & Set values
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
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public int grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
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
