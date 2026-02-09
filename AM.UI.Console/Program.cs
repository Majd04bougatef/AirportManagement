// See https://aka.ms/new-console-template for more information
using System.Net.Quic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
Plane p = new Plane
{
    PlaneId = 1,
    Capacity = 250,
    ManufactureDate = new DateTime(2015, 03, 15),
    PlaneType = PlaneType.Boeing
};
Plane p2 = new Plane
{
    PlaneId = 2,
    Capacity = 300,
    ManufactureDate = new DateTime(2018, 07, 22),
    PlaneType = PlaneType.Airbus
};
p2.Capacity = 300;
p2.ManufactureDate = new DateTime(2018, 07, 22);
p2.PlaneType = PlaneType.Airbus;

Plane p3 = new Plane()
{
    PlaneId = 3,
    Capacity = 200,
    ManufactureDate = new DateTime(2012, 11, 05),
    PlaneType = PlaneType.Boeing
};
Console.WriteLine(p);
Passenger pas = new Passenger
{
    FirstName = "John",
    LastName = "Doe",
    PassportNumber = "A1234567",
    EmailAddress = "johndoe@example.com",
    TelNumber = "123-456-7890",
    BirthDate = new DateTime(1990, 01, 01)
};
Console.WriteLine(pas);
Console.WriteLine(pas.CheckProfile("Doe", "John"));
Console.WriteLine(pas.CheckProfile("Doe", "John", "johndoe@example.com"));

Console.WriteLine(pas.login("Doe", "John"));
Console.WriteLine(pas.login("Doe", "John", "johndoe@example.com"));


//instance de service
FlightMethods flightMethods = new FlightMethods();

//alimenter listeflights
flightMethods.Flights = TestData.listFlights;

/*foreach (var item in flightMethods.GetFlightsDate("Paris"))
{
    Console.WriteLine(item);
}*/

flightMethods.GetFlights("destination", "Madrid");
Console.WriteLine("**********************");
flightMethods.showFlightDetails(TestData.Airbusplane);

Console.WriteLine("********************** Nmber flights start date 2022-03-01");
Console.WriteLine(flightMethods.ProgrammedFlightNumber(new DateTime(2022, 03, 01)));



Console.WriteLine("**********************");
Console.WriteLine("Senior travellers of flight1");
foreach (var item in flightMethods.seniorTravellers(TestData.flight1))
{
    Console.WriteLine(item);
}
