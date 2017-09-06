using System.Collections.Generic;

namespace SharpProject.Airport
{
    public class FlightProcessor
    {
        public List<Flight> getFlightsByDeparture(List<Flight> flights, FlightStatus type)
        {
            LinkedList<Flight>  result = new LinkedList<Flight>();
            foreach (var f in flights)
            {
                if (f.getStatus().Equals(type))
                {
                    result.AddLast(f);
                }
            }
            return null;
        }
    }
}