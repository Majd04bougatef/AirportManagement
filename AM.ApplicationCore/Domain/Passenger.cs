using System;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassengerId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Key, StringLength(7, ErrorMessage = "Passport number must be 7 characters")]
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        [MinLength(5, ErrorMessage = "First name cannot exceed 50 characters"), MaxLength(25, ErrorMessage = "First name cannot exceed 50 characters")  ]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual ICollection<ReservationTicket> Reservations { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Passport: {PassportNumber}";

        }
        public bool CheckProfile (string nom , string prenom)
        {
            return (FirstName == prenom && LastName == nom);
        }
        public bool CheckProfile (string nom , string prenom , string email)
        {
            return (FirstName == prenom && LastName == nom && EmailAddress == email);
        }

        public bool login (string nom , string prenom , string email=null)
        {
            if (email == null)
                return (FirstName == prenom && LastName == nom);
            else
                return (FirstName == prenom && LastName == nom && EmailAddress == email);
        }   
    }
}
