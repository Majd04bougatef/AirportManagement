using System;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public double EstimatedDuration { get; set; }

        // Navigation Properties
        public Plane Plane { get; set; }
        public Passenger Passenger { get; set; }

        public override string ToString()
        {
            return $"FlightId: {FlightId}, From: {Departure}, To: {Destination}, Date: {FlightDate}";
        }
    }
}
