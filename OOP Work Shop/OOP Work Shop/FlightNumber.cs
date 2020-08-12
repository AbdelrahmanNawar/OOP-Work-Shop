using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Work_Shop
{
    class FlightNumber
    {
        public FlightNumber()
        {
            Flights = new List<Flight>();
        }

        public string Departure { get; set; }
        public string Description { get; set; }
        public string Airline { get; set; }
        public List<Flight> Flights { get; set; }
        public Airport StartAirport { get; set; }
        public Airport DestinationAirport { get; set; }

        public override string ToString() => $"Flight Number:\nDeparture: {Departure}\nDescription: {Description}\nAirline: {Airline}";

    }
}
