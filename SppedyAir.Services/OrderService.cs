using Newtonsoft.Json;
using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SppedyAir.Services;

public class OrderService
{

    #region [ Properties and Variables]


    #endregion

    #region [ Public Methods]

    public Dictionary<string, Order>? GetOrders()
    {
        Dictionary<string, Order>? orderInfo = JsonConvert.DeserializeObject<Dictionary<string, Order>>(Constants.OrderInfoJSON);
        return orderInfo;
    }


    #endregion

    #region [ Private Methods]

    //private string GetOrders()
    //{

    //    string jsonString = string.Empty;

    //    jsonString = File.ReadAllText("C:\\dev\\learn\\dotnet\\speedyair\\SppedyAir.Services\\assets\\coding-assigment-orders.json");

    //    return jsonString;

    //}

    /// <summary>
    /// 
    /// </summary>
    //public string JSON
    //{
    //    get
    //    { return string.Empty; }


    //}


    #endregion

}
