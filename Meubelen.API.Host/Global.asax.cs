using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Meubelen.API;
using Meubelen.API.Config;
using Meubelen.API.Host.App_Start;

namespace Meubelen.API.Host
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           
            var config = GlobalConfiguration.Configuration;

            RouteConfig.RegisterRoutes(config);
            WepApiConfig.Configure(config);
            AutofacWebAPI.Initialize(config);
            EFConfig.Initialize();
        }
    }
}
