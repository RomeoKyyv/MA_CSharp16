using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpProject.sql
{
    public class AirportDbApp
    {
        public void RunProgram()
        {
            DbConnector Connector = new DbConnector();
            Plane plane = new Plane();
            plane.DestName = "Detroit";
            plane.RaceName = "DTRT01";
            
            Passenger FirstPassenger = new Passenger();
            FirstPassenger.Name = "passenger one";
            FirstPassenger.SecondName = "goes to Detroit";
            FirstPassenger.Plane = plane;
            List<Passenger> Passengers = new List<Passenger>();
            Passengers.Add(FirstPassenger);
            plane.Passengers = Passengers;

            Connector.SaveChanges();
        }
    }
}