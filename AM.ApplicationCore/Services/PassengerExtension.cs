
using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
       public static void UpperFullName(this Passenger passenger)
        {
            passenger.FirstName = passenger.FirstName[0].ToString().ToUpper() + passenger.FirstName.Substring(1);
            passenger.LastName = passenger.LastName[0].ToString().ToUpper() + passenger.LastName.Substring(1);
        }
    }
}