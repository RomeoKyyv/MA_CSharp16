using System;
using System.Collections.Generic;

namespace SharpProject.sql
{
    public class Plane
    {
        public int PlaneId;
        public string RaceName;
        public string DestName;

        public List<Passenger> Passengers;
    }
}