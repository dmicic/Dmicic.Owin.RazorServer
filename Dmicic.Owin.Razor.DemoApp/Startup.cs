using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Owin;
using Dmicic.Owin.DemoApp.Controller;
using Dmicic.Owin.Razor.Server;

namespace Dmicic.Owin.DemoApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(new Func<object, object>(
                x => new Middleware(new List<Route> 
                {
                    // Your routes
                    new Route("Person", typeof(PersonController))
                })
            ));
        }
    }
}
