using System;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }

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
