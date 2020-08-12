using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Work_Shop
{
    class Airport
    {
        public Airport()
        {
            TakeOffFlightNumbers = new List<FlightNumber>();
            LandingFlightNumbers = new List<FlightNumber>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public List<FlightNumber> TakeOffFlightNumbers { get; set; }
        public List<FlightNumber> LandingFlightNumbers { get; set; }

        public override string ToString() => $"\nID: {ID}\nName: {Name}";

    }
}
