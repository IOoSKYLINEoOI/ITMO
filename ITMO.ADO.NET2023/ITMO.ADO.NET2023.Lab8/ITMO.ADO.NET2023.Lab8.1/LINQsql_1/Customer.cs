using System.Data.Linq.Mapping;
using System.Collections;

namespace LINQsql_1
{
    [Table(Name = "Customers")]
    public class Customer
    {
        private string _CustomerID;
        [Column(IsPrimaryKey = true, Storage = "_CustomerID")]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
            }
        }

        private string _City;
        [Column(Storage = "_City")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this._City = value;
            }
        }

        public override string ToString()
        {
            return CustomerID + "\t" + City;
        }
    }
}
