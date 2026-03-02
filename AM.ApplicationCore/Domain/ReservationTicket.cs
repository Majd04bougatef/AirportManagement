using System;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {

       public DateTime DateReservation { get; set; }
       public float Prix { get; set; }   

       public Passenger Passenger { get; set; }
       public Ticket Ticket { get; set; }    

    }
}
