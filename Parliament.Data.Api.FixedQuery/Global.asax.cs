﻿namespace Parliament.Data.Api.FixedQuery
{
    using Microsoft.ApplicationInsights.Extensibility;
    using System;
    using System.Configuration;
    using System.Web;
    using System.Web.Http;

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            TelemetryConfiguration.Active.InstrumentationKey = ConfigurationManager.AppSettings["ApplicationInsightsInstrumentationKey"];

            var config = GlobalConfiguration.Configuration;

            config.Formatters.Add(new GraphFormatter());

            config.MapHttpAttributeRoutes();

            config.EnsureInitialized();
        }
    }
}