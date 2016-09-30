using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Events;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Core.Publishing;

namespace UmbracoTest
{
    public class LogWhenPublished : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            Umbraco.Core.Services.ContentService.Published += ContentService_Published;
        }

        private void ContentService_Published(IPublishingStrategy sender, PublishEventArgs<IContent> e)
        {
            // LogHelper will write to tracelog.txt
            LogHelper.Info(typeof(LogWhenPublished), "Something has been published");
        }
    }
}