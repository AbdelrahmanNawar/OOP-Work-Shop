using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Work_Shop
{
    class Coupon
    {
        public Coupon()
        {
            Luggages = new List<Luggage>();
        }

        public int ID { get; set; }
        public Ticket Ticket { get; set; }
        public List<Luggage> Luggages { get; set; }
        public Flight Flight { get; set; }

        public override string ToString() => $"Coupon:\nID: {ID}";
    }
}
