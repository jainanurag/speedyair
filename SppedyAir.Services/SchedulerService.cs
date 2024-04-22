using Newtonsoft.Json;
using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        //Dictionary<string, Order>? ordersWithPrior = orderService.GetOrdersByPriority();

        scheduleInfoList.AddRange(GetByDestination("YYZ", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YYC", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YVR", flights, orders));
        scheduleInfoList.AddRange(GetByDestination("YYE", flights, orders));


        return scheduleInfoList;
    }

    public List<ScheduleInfo> GetScheduleByPriority()
    {
        List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

        FlightService flightService = new();
        OrderService orderService = new();

        List<FlightInfo>? flights = flightService.GetFlights();
         Dictionary<string, Order>? ordersWithPrior = orderService.GetOrdersByPriority();

        scheduleInfoList.AddRange(GetByDestination("YYZ", flights, ordersWithPrior));
        scheduleInfoList.AddRange(GetByDestination("YYC", flights, ordersWithPrior));
        scheduleInfoList.AddRange(GetByDestination("YVR", flights, ordersWithPrior));
        scheduleInfoList.AddRange(GetByDestination("YYE", flights, ordersWithPrior));


        return scheduleInfoList;
    }

    public List<ScheduleInfo> GetByFlight(int flightNumber)
    {

        List<ScheduleInfo>? scheduleInfoList = GetScheduleByPriority();
        return scheduleInfoList.FindAll(s => s.FlightInfo != null && s.FlightInfo.FlightNumberVal == flightNumber);

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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="destination"></param>
    /// <param name="flights"></param>
    /// <param name="orders"></param>
    /// <returns></returns>
    private List<ScheduleInfo> GetByPriority(string destination, List<FlightInfo>? flights, Dictionary<string, Order>? orders)
    {

        List<ScheduleInfo>? scheduleInfoList = new List<ScheduleInfo>();

        int boxCount = 0;
        int dayCount = 1;

        List<string> servicePriority = new() { "same-day", "next-day", "regular" };

        foreach (string prior in servicePriority)
        {
            foreach (KeyValuePair<string, Order> kvp in orders.Where(o => o.Value.Destination == destination 
                                && !string.IsNullOrWhiteSpace(o.Value.Service) && o.Value.Service == prior))
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

                //boxCount++;

                if (boxCount == Constants.MAX_CAPACITY-1)
                {
                    boxCount = 0;
                    dayCount++;
                }

                boxCount++;

            }
        }


       

        return scheduleInfoList;
    }

    #endregion
}
