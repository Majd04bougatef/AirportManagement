using System;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
       public string Classe { get; set; }
       public string Destination { get; set; }
       public int Id { get; set; }

        public virtual ICollection<ReservationTicket> Reservations { get; set; }


    }
}
