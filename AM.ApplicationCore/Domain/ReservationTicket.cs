using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {
       public DateTime DateReservation { get; set; }
       public float Prix { get; set; }  
       
        [ForeignKey("Passenger")]
       public string FkPassenger { get; set; }

        [ForeignKey("Ticket")]
       public int FkTicket { get; set; }

       
       public virtual Passenger Passenger { get; set; }
       public virtual Ticket Ticket { get; set; }    

    }
}
