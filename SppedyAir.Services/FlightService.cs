using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppedyAir.Services;

public class FlightService
{

    public List<FlightInfo>? GetFlights()
    {


        List<FlightInfo> flights = new List<FlightInfo>();

        flights.Add(new FlightInfo() { Day = "Day1", FlightNumber = "Flight1", FromAirport = Montreal, DestAirport = Toronto });
        flights.Add(new FlightInfo() { Day = "Day1", FlightNumber = "Flight2", FromAirport = Montreal, DestAirport = Calgary });
        flights.Add(new FlightInfo() { Day = "Day1", FlightNumber = "Flight3", FromAirport = Montreal, DestAirport = Vancouver });


        flights.Add(new FlightInfo() { Day = "Day2", FlightNumber = "Flight4", FromAirport = Montreal, DestAirport = Toronto });
        flights.Add(new FlightInfo() { Day = "Day2",  FlightNumber = "Flight5", FromAirport = Montreal, DestAirport = Calgary });
        flights.Add(new FlightInfo() { Day = "Day2", FlightNumber = "Flight6", FromAirport = Montreal, DestAirport = Vancouver });

        return flights;

    }


    #region [ Airports ]


    /// <summary>
    /// Montreal
    /// </summary>
    private AirportInfo Montreal
    {
        get
        {

            AirportInfo airportInfo = new AirportInfo();
            airportInfo.Name = "Montreal airport";
            airportInfo.Code = "YUL";

            return airportInfo;
        }

    }

    /// <summary>
    /// Toronto
    /// </summary>
    private AirportInfo Toronto
    {
        get
        {

            AirportInfo airportInfo = new AirportInfo();
            airportInfo.Name = "Toronto airport";
            airportInfo.Code = "YYZ";

            return airportInfo;
        }

    }

    /// <summary>
    /// Calgary
    /// </summary>
    private AirportInfo Calgary
    {
        get
        {

            AirportInfo airportInfo = new AirportInfo();
            airportInfo.Name = "Calgary";
            airportInfo.Code = "YYC";
            return airportInfo;
        }

    }

    /// <summary>
    /// Vancouver
    /// </summary>
    private AirportInfo Vancouver
    {
        get
        {

            AirportInfo airportInfo = new AirportInfo();
            airportInfo.Name = "Vancouver airport";
            airportInfo.Code = "YVR";
            return airportInfo;
        }

    }

    #endregion


}
