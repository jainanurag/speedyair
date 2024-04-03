using Newtonsoft.Json;
using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace SppedyAir.Services;

public class SchedulerService
{


    //public List<ScheduleInfo> GetSchedule()
    //{
    //    List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

    //    FlightService flightService = new();
    //    OrderService orderService = new();

    //    List<FlightInfo>? flights = flightService.GetFlights();
    //    Dictionary<string, Order>? orders = orderService.GetOrders();

    //    // Toronto Orders
    //    int boxCount = 0;
    //    int dayCount = 1;
    //    foreach (KeyValuePair<string, Order> kvp in orders.Where(o=> o.Value.Destination == "YYZ"))
    //    {


    //        ScheduleInfo scheduleInfo = new ScheduleInfo();

    //        FlightInfo flightYYZ = flights.Find(f => f.DestAirport.Code == kvp.Value.Destination && f.DayVal == dayCount);

    //        scheduleInfo.FlightInfo = flightYYZ;
    //        scheduleInfo.OrderNumber = kvp.Key;

    //        scheduleInfoList.Add(scheduleInfo);

    //        //Console.WriteLine($"Order ID: {kvp.Key}, Destination: {kvp.Value.Destination}");

    //        boxCount++;

    //        if (boxCount == Constants.MAX_CAPACITY - 1)
    //        {
    //            boxCount = 0;
    //            dayCount++;
    //        }


    //    }


    //    // Calgary Orders


    //    // Vancouver Orders


    //    //foreach (KeyValuePair<string, Order> kvp in orders)
    //    //{
    //    //    ScheduleInfo scheduleInfo = new();



    //    //    Console.WriteLine($"Order ID: {kvp.Key}, Destination: {kvp.Value.Destination}");
    //    //}





    //    return scheduleInfoList;
    //}


    public List<ScheduleInfo> GetSchedule()
    {
        List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

        FlightService flightService = new();
        OrderService orderService = new();

        List<FlightInfo>? flights = flightService.GetFlights();
        Dictionary<string, Order>? orders = orderService.GetOrders();

        scheduleInfoList.AddRange(GetByDestination("YYZ",flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YYC", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YVR", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YYE", flights, orders));


        return scheduleInfoList;
    }

    #region [ Private Methods]

    private List<ScheduleInfo> GetByDestination(string destination, List<FlightInfo>? flights, Dictionary<string, Order>? orders)
    {

        List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

        // Toronto Orders
        int boxCount = 0;
        int dayCount = 1;
        foreach (KeyValuePair<string, Order> kvp in orders.Where(o => o.Value.Destination == destination))
        {


            ScheduleInfo scheduleInfo = new ScheduleInfo();

            FlightInfo flight = flights.Find(f => f.DestAirport.Code == kvp.Value.Destination && f.DayVal == dayCount);


            
            if (flight != null)
            {
                scheduleInfo.FlightInfo = flight;
            }


            scheduleInfo.OrderNumber = kvp.Key;
            scheduleInfoList.Add(scheduleInfo);

            //Console.WriteLine($"Order ID: {kvp.Key}, Destination: {kvp.Value.Destination}");

            boxCount++;

            if (boxCount == Constants.MAX_CAPACITY - 1)
            {
                boxCount = 0;
                dayCount++;
            }


        }

        return scheduleInfoList; 
    }

    #endregion
}
