using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        // Navigation Property (1 - *)
        public ICollection<Flight> Flights { get; set; }


        public Plane()
        {
            Flights = new List<Flight>();
        }

        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            Flights = new List<Flight>();
        }

        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Type: {PlaneType}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}";
        }
    }
}
