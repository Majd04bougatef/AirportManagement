using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public void GetFlights(string filterType, string filtervvalue)
        {
            switch (filterType) {
                case "destination":
                    foreach (var item in Flights){
                        if (item.Destination==filtervvalue){
                            Console.WriteLine(item);
                        } 
                    } 
                    break;
                 case "flightDate":
                    foreach (var item in Flights){
                        if (item.FlightDate==DateTime.Parse(filtervvalue)){
                            Console.WriteLine(item);
                        } 
                    } 
                    break; 
                
                case "flightId":
                    foreach (var item in Flights){
                        if (item.FlightId.ToString() == filtervvalue){
                            Console.WriteLine(item);
                        } 
                    } 
                    break; 
                case "effectiveArrival":
                    foreach (var item in Flights){
                        if (item.EffectiveArrival==DateTime.Parse(filtervvalue)){
                            Console.WriteLine(item);
                        } 
                    } 
                    break;
                case "estimatedDuration":
                    foreach (var item in Flights){
                        if (item.EstimatedDuration.ToString() == filtervvalue){
                            Console.WriteLine(item);
                        } 
                    } 
                    break;
                default:
                    Console.WriteLine("no match found");
                    break;
                    
            }
        }

        public IEnumerable<DateTime> GetFlightsDate(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();

            /*var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query;
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    flightDates.Add(Flights[i].FlightDate);
                }

            }

            foreach(Flight item in Flights)
            {
                if (item.Destination==destination)
                    flightDates.Add(item.FlightDate);
            }*/
            return Flights
            .Where(flights => flights.Destination == destination)
            .Select(flights => flights.FlightDate )
            .ToList();
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /*var query = from f in Flights
                        where f.FlightDate > startDate
                        && f.FlightDate < startDate.AddDays(7)
                        select f;*/
            return Flights
            .Count(f => f.FlightDate > startDate && f.FlightDate < startDate.AddDays(7));
        }

        public IEnumerable<Traveller> seniorTravellers(Flight flight)
        {
            /*var query = from p in flight.Passengers.OfType<Traveller>()
                        orderby p.BirthDate
                        select p;
            return query.Take(3);*/
            return flight
            .Passengers.OfType<Traveller>()
            .OrderBy(t => t.BirthDate)
            .Take(3).ToList();
        }
        public void showFlightDetails(Plane plane)
        {
            /*var query = from f in Flights
                        where f.Plane == plane
                        select new { f.FlightDate, f.Destination };
            foreach (var item in query)
            {                
                Console.WriteLine(item.FlightDate + " / Destination: : " + item.Destination);
            }*/

            Console.WriteLine(Flights.Where(f => f.Plane == plane).Select(f => new { f.FlightDate, f.Destination }));
        }
    }
}
