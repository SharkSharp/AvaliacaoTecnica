﻿using System.Web;
using System.Web.Mvc;

namespace DB1.AvaliacaoTecnica.API.RH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
