using System.Collections.Generic;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        public IEnumerable<DateTime> GetFlightsDate (string destination);
        public void GetFlights(string filterType , string filtervvalue);
        void showFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        IEnumerable<Traveller> seniorTravellers(Flight flight);
    }
}
