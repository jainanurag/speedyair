﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppedyAir.Services;

/// <summary>
/// Static Class
/// </summary>
public static class Constants
{

    public static readonly int MAX_CAPACITY = 20;

    public static readonly string OrderInfoJSON = @"{
  ""order-001"": {
    ""destination"": ""YYZ""
  },
  ""order-002"": {
    ""destination"": ""YYZ""
  },
  ""order-003"": {
    ""destination"": ""YYZ""
  },
  ""order-004"": {
    ""destination"": ""YYZ""
  },
  ""order-005"": {
    ""destination"": ""YYZ""
  },
  ""order-006"": {
    ""destination"": ""YYZ""
  },
  ""order-007"": {
    ""destination"": ""YYZ""
  },
  ""order-008"": {
    ""destination"": ""YYZ""
  },
  ""order-009"": {
    ""destination"": ""YYZ""
  },
  ""order-010"": {
    ""destination"": ""YYZ""
  },
  ""order-011"": {
    ""destination"": ""YYZ""
  },
  ""order-012"": {
    ""destination"": ""YYZ""
  },
  ""order-013"": {
    ""destination"": ""YYZ""
  },
  ""order-014"": {
    ""destination"": ""YYZ""
  },
  ""order-015"": {
    ""destination"": ""YYZ""
  },
  ""order-016"": {
    ""destination"": ""YYZ""
  },
  ""order-017"": {
    ""destination"": ""YYZ""
  },
  ""order-018"": {
    ""destination"": ""YYZ""
  },
  ""order-019"": {
    ""destination"": ""YYZ""
  },
  ""order-020"": {
    ""destination"": ""YYZ""
  },
  ""order-021"": {
    ""destination"": ""YYZ""
  },
  ""order-022"": {
    ""destination"": ""YYZ""
  },
  ""order-023"": {
    ""destination"": ""YYZ""
  },
  ""order-024"": {
    ""destination"": ""YYZ""
  },
  ""order-025"": {
    ""destination"": ""YYZ""
  },
  ""order-026"": {
    ""destination"": ""YYZ""
  },
  ""order-027"": {
    ""destination"": ""YYZ""
  },
  ""order-028"": {
    ""destination"": ""YYZ""
  },
  ""order-029"": {
    ""destination"": ""YYZ""
  },
  ""order-030"": {
    ""destination"": ""YYZ""
  },
  ""order-031"": {
    ""destination"": ""YYZ""
  },
  ""order-032"": {
    ""destination"": ""YYZ""
  },
  ""order-033"": {
    ""destination"": ""YYZ""
  },
  ""order-034"": {
    ""destination"": ""YYZ""
  },
  ""order-035"": {
    ""destination"": ""YYC""
  },
  ""order-036"": {
    ""destination"": ""YYC""
  },
  ""order-037"": {
    ""destination"": ""YYC""
  },
  ""order-038"": {
    ""destination"": ""YYC""
  },
  ""order-039"": {
    ""destination"": ""YYC""
  },
  ""order-040"": {
    ""destination"": ""YYC""
  },
  ""order-041"": {
    ""destination"": ""YYC""
  },
  ""order-042"": {
    ""destination"": ""YYC""
  },
  ""order-043"": {
    ""destination"": ""YYC""
  },
  ""order-044"": {
    ""destination"": ""YYC""
  },
  ""order-045"": {
    ""destination"": ""YYC""
  },
  ""order-046"": {
    ""destination"": ""YYC""
  },
  ""order-047"": {
    ""destination"": ""YYC""
  },
  ""order-048"": {
    ""destination"": ""YYC""
  },
  ""order-049"": {
    ""destination"": ""YYE""
  },
  ""order-050"": {
    ""destination"": ""YYC""
  },
  ""order-051"": {
    ""destination"": ""YYE""
  },
  ""order-052"": {
    ""destination"": ""YYC""
  },
  ""order-053"": {
    ""destination"": ""YYE""
  },
  ""order-054"": {
    ""destination"": ""YYC""
  },
  ""order-055"": {
    ""destination"": ""YYC""
  },
  ""order-056"": {
    ""destination"": ""YYC""
  },
  ""order-057"": {
    ""destination"": ""YYC""
  },
  ""order-060"": {
    ""destination"": ""YYC""
  },
  ""order-061"": {
    ""destination"": ""YYC""
  },
  ""order-062"": {
    ""destination"": ""YVR""
  },
  ""order-063"": {
    ""destination"": ""YVR""
  },
  ""order-064"": {
    ""destination"": ""YVR""
  },
  ""order-065"": {
    ""destination"": ""YVR""
  },
  ""order-066"": {
    ""destination"": ""YVR""
  },
  ""order-067"": {
    ""destination"": ""YVR""
  },
  ""order-068"": {
    ""destination"": ""YVR""
  },
  ""order-069"": {
    ""destination"": ""YVR""
  },
  ""order-070"": {
    ""destination"": ""YVR""
  },
  ""order-071"": {
    ""destination"": ""YVR""
  },
  ""order-072"": {
    ""destination"": ""YVR""
  },
  ""order-073"": {
    ""destination"": ""YVR""
  },
  ""order-074"": {
    ""destination"": ""YVR""
  },
  ""order-075"": {
    ""destination"": ""YVR""
  },
  ""order-076"": {
    ""destination"": ""YVR""
  },
  ""order-077"": {
    ""destination"": ""YVR""
  },
  ""order-078"": {
    ""destination"": ""YVR""
  },
  ""order-080"": {
    ""destination"": ""YVR""
  },
  ""order-081"": {
    ""destination"": ""YVR""
  },
  ""order-082"": {
    ""destination"": ""YVR""
  },
  ""order-083"": {
    ""destination"": ""YVR""
  },
  ""order-084"": {
    ""destination"": ""YVR""
  },
  ""order-085"": {
    ""destination"": ""YVR""
  },
  ""order-086"": {
    ""destination"": ""YVR""
  },
  ""order-087"": {
    ""destination"": ""YVR""
  },
  ""order-088"": {
    ""destination"": ""YVR""
  },
  ""order-089"": {
    ""destination"": ""YVR""
  },
  ""order-090"": {
    ""destination"": ""YVR""
  },
  ""order-091"": {
    ""destination"": ""YVR""
  },
  ""order-092"": {
    ""destination"": ""YVR""
  },
  ""order-093"": {
    ""destination"": ""YVR""
  },
  ""order-094"": {
    ""destination"": ""YVR""
  },
  ""order-095"": {
    ""destination"": ""YVR""
  },
  ""order-096"": {
    ""destination"": ""YVR""
  },
  ""order-097"": {
    ""destination"": ""YVR""
  },
  ""order-098"": {
    ""destination"": ""YVR""
  },
  ""order-099"": {
    ""destination"": ""YVR""
  }
}";
}
