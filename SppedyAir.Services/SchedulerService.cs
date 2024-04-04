using Newtonsoft.Json;
using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace SppedyAir.Services;


/// <summary>
/// 
/// </summary>
public class SchedulerService
{

    #region [ Variables and Properties]



    #endregion

    #region [ Public Methods]

    /// <summary>
    /// This Method returns Object with Flight Schedule
    /// with the Package inventory
    /// </summary>
    /// <returns></returns>
    public List<ScheduleInfo> GetSchedule()
    {
        List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

        FlightService flightService = new();
        OrderService orderService = new();

        List<FlightInfo>? flights = flightService.GetFlights();
        Dictionary<string, Order>? orders = orderService.GetOrders();

        scheduleInfoList.AddRange(GetByDestination("YYZ", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YYC", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YVR", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YYE", flights, orders));


        return scheduleInfoList;
    }

    #endregion

    #region [ Private Methods]


    /// <summary>
    /// Returns Scheduling as per the Destination
    /// </summary>
    /// <param name="destination">Destination Airport Code</param>
    /// <param name="flights">List of Available Filights</param>
    /// <param name="orders">List of Available Orders</param>
    /// <returns></returns>
    private List<ScheduleInfo> GetByDestination(string destination, List<FlightInfo>? flights, Dictionary<string, Order>? orders)
    {

        List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

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
