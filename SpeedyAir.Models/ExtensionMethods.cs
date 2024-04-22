using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Models;

public static class ExtensionMethods
{

    public static string ToStringByFlightNum(this ScheduleInfo sInfo, string orderNumber)
    {
        FlightInfo flightInfoTemp = sInfo.FlightInfo;

        if (flightInfoTemp == null)
            return $"Order:{orderNumber}, flightNumber:not scheduled";
        else
            return $"flightNumber: {flightInfoTemp.FlightNumberVal}, departure: {flightInfoTemp.FromAirport.Code}, arrival: {flightInfoTemp.DestAirport.Code}, day: {flightInfoTemp.DayVal} , Order:{orderNumber}";
    }
}
