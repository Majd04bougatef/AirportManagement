using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public IEnumerable<DateTime> GetFlightsDate(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();

            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    flightDates.Add(Flights[i].FlightDate);
                }
                
            }
            return flightDates;
        }
    }
}
