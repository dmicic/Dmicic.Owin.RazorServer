using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dmicic.Owin.Razor.Library;
using Dmicic.Owin.RazorServer.RequestHandler;

namespace Dmicic.Owin.Razor.Server
{
    public class Middleware
    {
        private IEnumerable<Route> Routes { get; set; }

        public Middleware(IEnumerable<Route> routes)
        {
            this.Routes = routes;
        }

        public async Task<object> Invoke(IDictionary<string, object> env)
        {
            var handler = RequestFactory.Get(env, this.Routes);
            await handler.Handle();

            return Task.FromResult<object>(null);
        }
    }
}
