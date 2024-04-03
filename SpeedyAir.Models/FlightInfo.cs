using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Models;

/// <summary>
/// This class reperesnts Flight Information
/// </summary>
public class FlightInfo
{
    public required string Day { get; set; }
    public required string FlightNumber { get; set; }
    public required AirportInfo FromAirport { get; set; }
    public required AirportInfo DestAirport { get; set; }

    public override string ToString()
    {
        return $"{FlightNumber}, departure: {FromAirport.Code}, arrival: {DestAirport.Code}, day: {Day} ";
       
    }

}
