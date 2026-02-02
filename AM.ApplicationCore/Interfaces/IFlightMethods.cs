using System.Collections.Generic;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        List<Flight> Flights { get; set; }
    }
}
