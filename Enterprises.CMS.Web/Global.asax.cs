﻿using System;
using System.Web.Mvc;
using Abp.Dependency;
using Abp.Web;
using Castle.Facilities.Logging;
using StackExchange.Profiling;
using StackExchange.Profiling.EntityFramework6;

namespace Enterprises.CMS.Web
{
    public class MvcApplication : AbpWebApplication
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config"));
            // Ef 监控 debug模式调试开启
            //MiniProfilerEF6.Initialize();

            base.Application_Start(sender, e);
        }

        protected override void Application_BeginRequest(object sender, EventArgs e)
        {
            //MiniProfiler.Start();
            base.Application_BeginRequest(sender, e);
        }

        protected override void Application_EndRequest(object sender, EventArgs e)
        {
            //MiniProfiler.Stop();
            base.Application_EndRequest(sender, e);
        }
    }
}
