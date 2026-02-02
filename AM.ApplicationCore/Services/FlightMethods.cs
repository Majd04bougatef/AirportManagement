using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; }

        public FlightMethods()
        {
            Flights = new List<Flight>();
        }
    }
}
