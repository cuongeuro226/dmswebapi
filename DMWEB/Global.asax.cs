using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DMWEB;
using Newtonsoft.Json.Serialization;

namespace DMWEB
{
    
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.DateFormatHandling =
            //    Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Formatting =
            //    Newtonsoft.Json.Formatting.Indented;

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
            //                new CamelCasePropertyNamesContractResolver();

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling =
            //    Newtonsoft.Json.PreserveReferencesHandling.All;

            


        }
    }
}
