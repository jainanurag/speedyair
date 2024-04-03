// See https://aka.ms/new-console-template for more information
using SpeedyAir.Models;
using SppedyAir.Services;

List<FlightInfo> flights = new FlightService().GetFlights();

foreach (FlightInfo item in flights)
{

    Console.WriteLine(item.ToString());

}

Console.ReadLine();