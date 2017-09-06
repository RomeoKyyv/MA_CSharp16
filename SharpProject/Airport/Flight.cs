using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace SharpProject.Airport
{
    public class Flight
    {
        private string Name, Destiation, City, Terminal;
        private FlightStatus FlightStatus;
        private DateTime ArrivalDateTime, DepartureDateTime;

        private double PriceEconomy, PriceBusiness;
        private HashSet<Passenger> passengers;

        public Flight(string name, string destiation, string city, string terminal, FlightStatus flightStatus,
            DateTime arrivalDateTime, DateTime departureDateTime)
        {
            Name = name;
            Destiation = destiation;
            City = city;
            Terminal = terminal;
            FlightStatus = flightStatus;
            ArrivalDateTime = arrivalDateTime;
            DepartureDateTime = departureDateTime;
            passengers = new HashSet<Passenger>();
        }

        public void addPasseger(Passenger passenger)
        {
            passengers.Add(passenger);
        }
        
        public string getFlightInfo()
        {
            StringBuilder builder = new StringBuilder("|Flight |");
            builder.Append(Name);
            builder.Append("|");
            builder.Append(Destiation);
            builder.Append("|");
            builder.Append(City);
            builder.Append("|");
            builder.Append(FlightStatus.ToString());
            builder.Append("|");
            builder.Append(ArrivalDateTime);
            builder.Append("|");
            builder.Append(DepartureDateTime);
            builder.Append("|");
            builder.Append(Terminal);
            builder.Append("|");
            return builder.ToString();
        }

        public FlightStatus getStatus()
        {
            return FlightStatus;
        }
    }
}