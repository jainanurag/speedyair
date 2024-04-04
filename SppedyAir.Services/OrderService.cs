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


    #endregion

    #region [ Private Methods]

    

    #endregion

}
