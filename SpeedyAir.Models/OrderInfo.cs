using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Models;


public class Order
{
    public required string Destination { get; set; }
    public required string Service { get; set; }

}


//public class OrderInfo<T>
//{
//    public Dictionary<string, T>? Data { get; set; }
//}



//public class DestinationInfo
//{
//    public required string Destination { get; set; }
//}
