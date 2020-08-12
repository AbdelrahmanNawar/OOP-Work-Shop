using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Work_Shop
{
    class Customers
    {
        public Customers()
        {
            Tickets = new List<Ticket>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }

        public override string ToString() => $"Customer:\nID: {ID}\nName: {Name}";
    }
}
