using Newtonsoft.Json;
using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SppedyAir.Services;

/// <summary>
/// Order Service
/// </summary>
public class OrderService
{

    #region [ Properties and Variables]


    #endregion

    #region [ Public Methods]

    /// <summary>
    /// Provide Order Object
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, Order>? GetOrders()
    {
        Dictionary<string, Order>? orderInfo = JsonConvert.DeserializeObject<Dictionary<string, Order>>(Constants.OrderInfoJSON);
        return orderInfo;
    }

    public Dictionary<string, Order>? GetOrdersByPriority()
    {

        string orderJson = File.ReadAllText(@"C:\dev\learn\dotnet\speedyair\SpeedyAir.Models\coding-assignment-orders-part-two.json");
        Dictionary<string, Order>? orderInfo = JsonConvert.DeserializeObject<Dictionary<string, Order>>(orderJson);
        return orderInfo;
    }


    #endregion

    #region [ Private Methods]



    #endregion

}
