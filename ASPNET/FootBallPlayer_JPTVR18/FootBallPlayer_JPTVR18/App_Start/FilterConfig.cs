﻿using System.Web;
using System.Web.Mvc;

namespace FootBallPlayer_JPTVR18
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}