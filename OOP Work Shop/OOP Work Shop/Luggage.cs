using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Work_Shop
{
    class Luggage
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public Coupon Coupon { get; set; }

        public override string ToString() => $"Luggage:\nID: {ID}\nWeight: {Weight}";

    }
}
