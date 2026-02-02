using System.Collections.Generic;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        public IEnumerable<DateTime> GetFlightsDate (string destination);
    }
}
