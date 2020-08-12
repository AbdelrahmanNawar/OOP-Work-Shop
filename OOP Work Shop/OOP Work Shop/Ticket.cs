using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace OOP_Work_Shop
{
    class Ticket
    {
        public Ticket()
        {
            Coupons = new List<Coupon>();
        }

        public int ID { get; set; }
        public Customers Customer { get; set; }
        public List<Coupon> Coupons { get; set; }

        public override string ToString() => $"Ticket:\nID: {ID}";
    }
}
