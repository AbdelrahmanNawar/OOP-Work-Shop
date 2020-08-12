using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Work_Shop
{
    class DataFile
    {
        #region Airports
        Airport airport1 = new Airport() { ID = 1, Name = "Cairo" };
        Airport airport2 = new Airport() { ID = 2, Name = "Alexandria" };
        Airport airport3 = new Airport() { ID = 3, Name = "Mosco" };
        Airport airport4 = new Airport() { ID = 4, Name = "Usa" };
        Airport airport5 = new Airport() { ID = 5, Name = "London" };
        #endregion

        #region Flight Numbers
        FlightNumber flightNumber1 = new FlightNumber() { Departure = "12:00", Description = "First Class", Airline = "Turkish" };
        FlightNumber flightNumber2 = new FlightNumber() { Departure = "11:00", Description = "Second Class", Airline = "Egypt" };
        FlightNumber flightNumber3 = new FlightNumber() { Departure = "10:00", Description = "Third Class", Airline = "Emirates" };
        FlightNumber flightNumber4 = new FlightNumber() { Departure = "9:00", Description = "Economy Class", Airline = "France" };
        FlightNumber flightNumber5 = new FlightNumber() { Departure = "8:00", Description = "Shipping", Airline = "California" };
        #endregion

        #region Flights
        Flight flight1 = new Flight() { ID = 1 };
        Flight flight2 = new Flight() { ID = 2 };
        Flight flight3 = new Flight() { ID = 3 };
        Flight flight4 = new Flight() { ID = 4 };
        Flight flight5 = new Flight() { ID = 5 };
        Flight flight6 = new Flight() { ID = 6 };
        Flight flight7 = new Flight() { ID = 7 };
        #endregion

        #region Coupons
        Coupon coupon1 = new Coupon() { ID = 1 };
        Coupon coupon2 = new Coupon() { ID = 2 };
        Coupon coupon3 = new Coupon() { ID = 3 };
        Coupon coupon4 = new Coupon() { ID = 4 };
        Coupon coupon5 = new Coupon() { ID = 5 };
        Coupon coupon6 = new Coupon() { ID = 6 };
        Coupon coupon7 = new Coupon() { ID = 7 };
        Coupon coupon8 = new Coupon() { ID = 8 };
        Coupon coupon9 = new Coupon() { ID = 9 };
        Coupon coupon10 = new Coupon() { ID = 10 };
        Coupon coupon11 = new Coupon() { ID = 11 };
        Coupon coupon12 = new Coupon() { ID = 12 };
        Coupon coupon13 = new Coupon() { ID = 13 };
        Coupon coupon14 = new Coupon() { ID = 14 };
        Coupon coupon15 = new Coupon() { ID = 15 };
        Coupon coupon16 = new Coupon() { ID = 16 };
        Coupon coupon17 = new Coupon() { ID = 17 };
        Coupon coupon18 = new Coupon() { ID = 18 };
        Coupon coupon19 = new Coupon() { ID = 19 };
        Coupon coupon20 = new Coupon() { ID = 20 };
        #endregion

        #region Tickets
        Ticket ticket1 = new Ticket() { ID = 1 };
        Ticket ticket2 = new Ticket() { ID = 2 };
        Ticket ticket3 = new Ticket() { ID = 3 };
        Ticket ticket4 = new Ticket() { ID = 4 };
        Ticket ticket5 = new Ticket() { ID = 5 };
        Ticket ticket6 = new Ticket() { ID = 6 };
        Ticket ticket7 = new Ticket() { ID = 7 };
        Ticket ticket8 = new Ticket() { ID = 8 };
        Ticket ticket9 = new Ticket() { ID = 9 };
        #endregion

        #region Luggages
        Luggage luggage1 = new Luggage() { ID = 1, Weight = 1.5 };
        Luggage luggage2 = new Luggage() { ID = 2, Weight = 10.5 };
        Luggage luggage3 = new Luggage() { ID = 3, Weight = 12.5 };
        Luggage luggage4 = new Luggage() { ID = 4, Weight = 6 };
        Luggage luggage5 = new Luggage() { ID = 5, Weight = 20 };
        #endregion

        #region Customers
        Customers customer1 = new Customers() { ID = 1, Name = "Abdou" };
        Customers customer2 = new Customers() { ID = 2, Name = "Ali" };
        Customers customer3 = new Customers() { ID = 3, Name = "Nawar" };
        Customers customer4 = new Customers() { ID = 4, Name = "Hassan" };
        Customers customer5 = new Customers() { ID = 5, Name = "Omar" }; 
        #endregion

        public static List<Customers> Customers { get; set; }
        public static List<Coupon> Coupons { get; set; }


        public DataFile()
        {
            #region First Task Data
            Customers = new List<Customers>();
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);
            Customers.Add(customer5);
            #endregion

            ////////////////////////////////

            #region Second Task Data
            customer1.Tickets.Add(ticket1);
            ticket1.Customer = customer1;
            ticket1.Coupons.Add(coupon1);
            ticket1.Coupons.Add(coupon2);
            coupon1.Ticket = ticket1;
            coupon2.Ticket = ticket1;

            customer2.Tickets.Add(ticket2);
            ticket2.Customer = customer2;
            ticket2.Coupons.Add(coupon3);
            ticket2.Coupons.Add(coupon4);
            ticket2.Coupons.Add(coupon5);
            coupon3.Ticket = ticket2;
            coupon4.Ticket = ticket2;
            coupon5.Ticket = ticket2;

            customer2.Tickets.Add(ticket3);
            ticket3.Customer = customer2;
            ticket3.Coupons.Add(coupon6);
            coupon6.Ticket = ticket3;

            customer3.Tickets.Add(ticket4);
            ticket4.Customer = customer3;
            ticket4.Coupons.Add(coupon7);
            ticket4.Coupons.Add(coupon8);
            ticket4.Coupons.Add(coupon9);
            ticket4.Coupons.Add(coupon10);
            coupon7.Ticket = ticket4;
            coupon8.Ticket = ticket4;
            coupon9.Ticket = ticket4;
            coupon10.Ticket = ticket4;

            customer3.Tickets.Add(ticket5);
            ticket5.Customer = customer3;
            ticket5.Coupons.Add(coupon11);
            ticket5.Coupons.Add(coupon12);
            coupon11.Ticket = ticket5;
            coupon12.Ticket = ticket5;

            customer3.Tickets.Add(ticket6);
            ticket6.Customer = customer3;
            ticket6.Coupons.Add(coupon13);
            ticket6.Coupons.Add(coupon14);
            ticket6.Coupons.Add(coupon15);
            ticket6.Coupons.Add(coupon16);
            coupon13.Ticket = ticket6;
            coupon14.Ticket = ticket6;
            coupon15.Ticket = ticket6;
            coupon16.Ticket = ticket6;

            customer4.Tickets.Add(ticket7);
            ticket7.Customer = customer4;
            ticket7.Coupons.Add(coupon17);
            coupon17.Ticket = ticket7;

            customer5.Tickets.Add(ticket8);
            ticket8.Customer = customer5;
            ticket8.Coupons.Add(coupon8);
            coupon18.Ticket = ticket8;

            customer5.Tickets.Add(ticket9);
            ticket9.Customer = customer5;
            ticket9.Coupons.Add(coupon20);
            coupon19.Ticket = ticket9;
            #endregion

            ////////////////////////////////

            #region Third Task Data
            Coupons = new List<Coupon>();

            flightNumber1.StartAirport = airport1;
            flightNumber1.DestinationAirport = airport2;
            airport1.TakeOffFlightNumbers.Add(flightNumber1);
            airport2.LandingFlightNumbers.Add(flightNumber1);

            flightNumber2.StartAirport = airport2;
            flightNumber2.DestinationAirport = airport3;
            airport2.TakeOffFlightNumbers.Add(flightNumber2);
            airport3.LandingFlightNumbers.Add(flightNumber2);

            flightNumber3.StartAirport = airport2;
            flightNumber3.DestinationAirport = airport5;
            airport2.TakeOffFlightNumbers.Add(flightNumber3);
            airport5.LandingFlightNumbers.Add(flightNumber3);

            flightNumber4.StartAirport = airport3;
            flightNumber4.DestinationAirport = airport5;
            airport3.TakeOffFlightNumbers.Add(flightNumber4);
            airport5.LandingFlightNumbers.Add(flightNumber4);

            flightNumber5.StartAirport = airport4;
            flightNumber5.DestinationAirport = airport1;
            airport4.TakeOffFlightNumbers.Add(flightNumber5);
            airport1.LandingFlightNumbers.Add(flightNumber5);

            flight1.Coupons.Add(coupon1);
            coupon1.Flight = flight1;

            flight1.Coupons.Add(coupon2);
            coupon2.Flight = flight1;

            flight1.Coupons.Add(coupon3);
            coupon3.Flight = flight1;

            flight2.Coupons.Add(coupon5);
            coupon5.Flight = flight2;

            flight2.Coupons.Add(coupon6);
            coupon6.Flight = flight2;

            flight3.Coupons.Add(coupon9); 
            coupon9.Flight = flight3;

            flight3.Coupons.Add(coupon11);
            coupon11.Flight = flight3;

            flight4.Coupons.Add(coupon12);
            coupon12.Flight = flight4;

            flight4.Coupons.Add(coupon13);
            coupon13.Flight = flight4;

            flight4.Coupons.Add(coupon14);
            coupon14.Flight = flight4;

            flight4.Coupons.Add(coupon15);
            coupon15.Flight = flight4;

            flight5.Coupons.Add(coupon17);
            coupon17.Flight = flight5;

            flight5.Coupons.Add(coupon19);
            coupon19.Flight = flight5;

            flight6.Coupons.Add(coupon4);
            coupon4.Flight = flight6;

            flight7.Coupons.Add(coupon8);
            flight7.Coupons.Add(coupon10);
            coupon8.Flight = flight7;
            coupon10.Flight = flight7;

            flightNumber1.Flights.Add(flight1);
            flight1.FlightNumber = flightNumber1;

            flightNumber2.Flights.Add(flight2);
            flightNumber2.Flights.Add(flight6);
            flight2.FlightNumber = flightNumber2;
            flight6.FlightNumber = flightNumber2;

            flightNumber3.Flights.Add(flight3);
            flight3.FlightNumber = flightNumber3;

            flightNumber4.Flights.Add(flight4);
            flightNumber4.Flights.Add(flight7);
            flight4.FlightNumber = flightNumber4;
            flight7.FlightNumber = flightNumber4;

            flightNumber5.Flights.Add(flight5);
            flight5.FlightNumber = flightNumber5;

            Coupons.Add(coupon1);
            Coupons.Add(coupon2);
            Coupons.Add(coupon3);
            Coupons.Add(coupon4);
            Coupons.Add(coupon5);
            Coupons.Add(coupon6);
            Coupons.Add(coupon7);
            Coupons.Add(coupon8);
            Coupons.Add(coupon9);
            Coupons.Add(coupon9);
            Coupons.Add(coupon11);
            Coupons.Add(coupon12);
            Coupons.Add(coupon13);
            Coupons.Add(coupon14);
            Coupons.Add(coupon15);
            Coupons.Add(coupon16);
            Coupons.Add(coupon17);
            Coupons.Add(coupon18);
            Coupons.Add(coupon19);
            Coupons.Add(coupon20);
            #endregion
        }

        public Coupon GetCoupons()
        {
            return Coupons[new Random().Next(1, 20)];
        }
    }
}
