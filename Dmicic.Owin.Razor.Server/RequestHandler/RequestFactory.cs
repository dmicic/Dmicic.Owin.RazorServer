using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dmicic.Owin.Razor.Server;

namespace Dmicic.Owin.RazorServer.RequestHandler
{
    internal static class RequestFactory
    {
        public static RequestHandlerBase Get(IDictionary<string, object> env, IEnumerable<Route> routes)
        {
            var httpMethod = ((string)env["owin.RequestMethod"]).ToUpper();

            switch (httpMethod)
            { 
                case "GET": return new GetHandler(env, routes);
                case "POST": throw new NotImplementedException("POST handler");
                default: throw new NotImplementedException("No handler found for: " + httpMethod);
            }
        }
    }
}
