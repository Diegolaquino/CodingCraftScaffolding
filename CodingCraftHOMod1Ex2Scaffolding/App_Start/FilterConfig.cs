﻿using System.Web;
using System.Web.Mvc;

namespace CodingCraftHOMod1Ex2Scaffolding
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
