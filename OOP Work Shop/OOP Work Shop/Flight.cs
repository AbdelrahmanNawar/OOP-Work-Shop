using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Work_Shop
{
    class Flight
    {
        public Flight()
        {
            Coupons = new List<Coupon>();
        }

        public int ID { get; set; }
        public List<Coupon> Coupons { get; set; }
        public FlightNumber FlightNumber { get; set; }

        public override string ToString() => $"Fligh:\nID: {ID}";

    }
}
