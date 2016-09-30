using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace UmbracoTest.Events
{
    public class EventHandler : Umbraco.Core.ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            //Umbraco.Core.Services.ContentService.Published += ContentService_Published;
        }
    }
}