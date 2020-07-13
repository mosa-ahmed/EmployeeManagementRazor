﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementRazor
{
    public class EvenConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey,
                            
                          RouteValueDictionary values, RouteDirection routeDirection)
        {
            int id;
            if(int.TryParse(values["id"].ToString(),out id))
            {
                if(id % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
