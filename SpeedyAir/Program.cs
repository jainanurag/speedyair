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


Console.WriteLine("*********************E N D*****************************");
Console.WriteLine("Press ENTER to EXIT");
Console.ReadLine();


