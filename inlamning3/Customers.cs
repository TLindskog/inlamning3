using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace inlamning3
{
    public class Customers
    {
        public int  customer_id { get; set; }
        public string first_name { get; set }
        public string last_name { get; set }
        public string email { get; set }

    }
}
