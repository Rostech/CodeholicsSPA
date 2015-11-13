using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(CodeholicsSPA.Api.Startup))]

namespace CodeholicsSPA.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            ConfigureAuth(app);
            app.UseWebApi(config);
        }
    }
}
