// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SpeedyAir.Models;
using SppedyAir.Services;


Console.WriteLine("User Story # 1");

List<FlightInfo>? flights = new FlightService().GetFlights();

foreach (FlightInfo item in flights)
{

    Console.WriteLine(item.ToString());

}

Console.WriteLine("User Story # 2");


Dictionary<string, Order> orderInfo = new OrderService().GetOrders();

int countYYZ = orderInfo.Where(o => o.Value.Destination == "YYZ").Count();
int countYYC = orderInfo.Where(o => o.Value.Destination == "YYC").Count();
int countYVR = orderInfo.Where(o => o.Value.Destination == "YVR").Count();

// Load 6 Flights

List<ScheduleInfo> scheduleInfos = new SchedulerService().GetSchedule();

foreach (ScheduleInfo scheduleInfo in scheduleInfos)
{
    Console.WriteLine(scheduleInfo.ToString());
}




Console.ReadLine();


