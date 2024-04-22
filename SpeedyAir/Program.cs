// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SpeedyAir.Models;
using SppedyAir.Services;


Console.WriteLine("User Story # 1");
Console.WriteLine("******************************************************");


// Get the List of Flights
List<FlightInfo>? flights = new FlightService().GetFlights();

if (flights != null)
{
    foreach (FlightInfo item in flights)
    {

        Console.WriteLine(item.ToString());

    }
}
else
{
    Console.WriteLine("********No Flight Data found***************");
}

Console.WriteLine("******************************************************");


// Get the List of Orders
Dictionary<string, Order>? orderInfo = new OrderService().GetOrders();

if (orderInfo != null)
{
    int? countYYZ = orderInfo.Where(o => o.Value.Destination == "YYZ").Count();
    int? countYYC = orderInfo.Where(o => o.Value.Destination == "YYC").Count();
    int? countYVR = orderInfo.Where(o => o.Value.Destination == "YVR").Count();
    int? countYYE = orderInfo.Where(o => o.Value.Destination == "YYE").Count();

    Console.WriteLine("******************************************************");
    Console.WriteLine("Package to Schedule Per Destination:" + countYYZ);
    Console.WriteLine("Package to Schedule YYZ:" + countYYZ);
    Console.WriteLine("Package to Schedule YYC:" + countYYC);
    Console.WriteLine("Package to Schedule YVR:" + countYVR);
    Console.WriteLine("Package to Schedule YER:" + countYYE);
    Console.WriteLine("******************************************************");


    Console.WriteLine("User Story # 2");

    List<ScheduleInfo> scheduleInfos = new SchedulerService().GetSchedule();

    Console.WriteLine("***************Package Schedule***********************");

    foreach (ScheduleInfo scheduleInfo in scheduleInfos)
    {
        Console.WriteLine(scheduleInfo.ToString());
    }

}
else
{
    Console.WriteLine("********No Scheduling Data found***************");
}

Console.WriteLine("User Story # 3");
Console.WriteLine("******************************************************");

List<ScheduleInfo> scheduleInfoByFlight = new SchedulerService().GetByFlight(3);


//foreach (ScheduleInfo scheduleInfo in scheduleInfoByFlight)
//{
//    Console.WriteLine(scheduleInfo.ToStringByFlightNum(scheduleInfo.OrderNumber));
//}

for (int i = 0; i < scheduleInfoByFlight.Count; i++)
{
    FlightInfo flightInfoTemp = scheduleInfoByFlight[i].FlightInfo;

    if (i == 0)
        Console.WriteLine($"flightNumber: {flightInfoTemp.FlightNumberVal}, departure: {flightInfoTemp.FromAirport.Code}, arrival: {flightInfoTemp.DestAirport.Code}, day: {flightInfoTemp.DayVal}");

    Console.WriteLine($"Order:{ scheduleInfoByFlight[i].OrderNumber}");

}

Console.WriteLine("User Story # 4");

List<ScheduleInfo>  scheduleInfoByPrior = new SchedulerService().GetScheduleByPriority();

Console.WriteLine("***************Package Schedule By Priority***********************");

foreach (ScheduleInfo scheduleInfo in scheduleInfoByPrior)
{
    Console.WriteLine(scheduleInfo.ToString());
}

Console.WriteLine("*********************E N D*****************************");
Console.WriteLine("Press ENTER to EXIT");
Console.ReadLine();


