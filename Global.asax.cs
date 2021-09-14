using CaptchaMvc.Infrastructure;
using CaptchaMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CapthaInMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var CaptchaManager = (DefaultCaptchaManager)CaptchaUtils.CaptchaManager;
            CaptchaManager.CharactersFactory = () => "my characters";
            CaptchaManager.PlainCaptchaPairFactory = length =>
             {
                 string randomText = RandomText.Generate(CaptchaManager.CharactersFactory(), length);
                 bool IgnoreCase = false;
                 return new KeyValuePair<string, CaptchaMvc.Interface.ICaptchaValue>(Guid.NewGuid().ToString("N"),
                     new StringCaptchaValue(randomText, randomText, IgnoreCase));
             };

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
