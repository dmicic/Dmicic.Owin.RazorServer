using System;
using Microsoft.Owin.Hosting;
using Dmicic.Owin.DemoApp;
using Dmicic.Owin.Razor.Server;

namespace Dmicic.Owin.Razor.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(5003))
            {
                Console.WriteLine("Razor server is running. Press enter to shut down...");
                Console.ReadLine();
            }
        }
    }
}
