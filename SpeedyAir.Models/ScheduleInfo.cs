using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Models;

public class ScheduleInfo
{
    public FlightInfo? FlightInfo { get; set; }
    public string OrderNumber { get; set; }


    public override string ToString()
    {
        if (FlightInfo == null)
            return $"Order:{OrderNumber}, flightNumber:not scheduled";
        else
            return $"Order:{OrderNumber}, flightNumber: {FlightInfo.FlightNumberVal}, departure: {FlightInfo.FromAirport.Code}, arrival: {FlightInfo.DestAirport.Code}, day: {FlightInfo.DayVal} ";

    }

    //public string ToStringByFlight()
    //{
    //    if (FlightInfo == null)
    //        return $"Order:{OrderNumber}, flightNumber:not scheduled";
    //    else
    //        return $"flightNumber: {FlightInfo.FlightNumberVal}, departure: {FlightInfo.FromAirport.Code}, arrival: {FlightInfo.DestAirport.Code}, day: {FlightInfo.DayVal} , Order:{OrderNumber}";

    //}


}


