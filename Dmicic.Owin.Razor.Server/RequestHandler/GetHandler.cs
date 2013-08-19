using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dmicic.Owin.Razor.Server;

namespace Dmicic.Owin.RazorServer.RequestHandler
{
    internal class GetHandler : RequestHandlerBase
    {
        public GetHandler(IDictionary<string, object> env, IEnumerable<Route> routes) 
            : base(env, routes) 
        { }

        public async override Task<object> Handle()
        {
            var controllerAndAction =  base.GetControllerAndAction();
            var route = base.GetRoute(controllerAndAction[0]);
            var view = base.InvokeController(route.Controller, controllerAndAction[1]);
            var viewPath = base.GetViewPath(controllerAndAction[0], view.ViewName);
            await base.WriteResponse(viewPath, view.Model);

            return Task.FromResult<object>(null);
        }
    }
}
