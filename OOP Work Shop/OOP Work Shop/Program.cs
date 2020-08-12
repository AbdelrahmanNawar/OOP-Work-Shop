using System;
using System.Linq;

namespace OOP_Work_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFile data = new DataFile();

            char UserInput;
            bool isFinished = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a number from the list below:");
                Console.WriteLine("1) All Customers.");
                Console.WriteLine("2) Tickets of a Customer and its Coupons.");
                Console.WriteLine("3) Random Coupon details, its Flights if exist, Flight number details and Airport information.");
                Console.WriteLine("\nOr Press \"0\" to Exit.");

                char.TryParse(Console.ReadLine(), out UserInput);
                Console.Clear();

                switch (UserInput)
                {
                    case '1':
                        foreach (var item in DataFile.Customers)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.WriteLine("\nPress enter to get back to menu.");
                        Console.Read();
                        break;

                    case '2':
                        bool rightInput = false;
                        int inputCustomerID;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter valid customer ID from the list below.");
                            foreach (var item in DataFile.Customers)
                            {
                                Console.WriteLine($"{item.ID}");
                            }
                            rightInput = int.TryParse(Console.ReadLine(), out inputCustomerID);

                            Console.Clear();
                            Customers customer = DataFile.Customers.SingleOrDefault(cust => cust.ID == inputCustomerID);
                            if (customer != null)
                            {
                                Console.WriteLine(customer.ToString());
                                customer.Tickets.ForEach(t =>
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(t.ToString());
                                    t.Coupons.ForEach(c => Console.WriteLine(c.ToString()));
                                    Console.WriteLine();
                                });
                                Console.WriteLine("\nPress enter to get back to menu.");
                                Console.Read();
                                rightInput = true;
                            }
                            else
                            {
                                rightInput = false;
                            }
                        } while (!rightInput);
                        break;

                    case '3':
                        Coupon randomCoupon   = data.GetCoupons();
                        Console.WriteLine(randomCoupon.ToString());
                        if(randomCoupon.Flight != null)
                        {
                            Console.WriteLine(randomCoupon.Flight.ToString());
                            Console.WriteLine(randomCoupon.Flight.FlightNumber.ToString());
                            Console.WriteLine($"Take Off Airport: {randomCoupon.Flight.FlightNumber.StartAirport}");
                            Console.WriteLine($"Landing Airport: {randomCoupon.Flight.FlightNumber.DestinationAirport}");
                        }
                        else
                        {
                            Console.WriteLine("This coupon does not have a flight");
                        }
                        Console.WriteLine("\nPress enter to get back to menu.");
                        Console.Read();
                        break;

                    case '0':
                        isFinished = true;
                        break;

                    default:
                        Console.WriteLine("Please Enter Valid Input.\n");
                        break;
                }
            } while (!isFinished);
        }
    }
}
