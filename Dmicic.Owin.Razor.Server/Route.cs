using System;

namespace Dmicic.Owin.Razor.Server
{
    public class Route
    {
        public Type Controller { get; private set; }
        public string Name { get; private set; }

        public Route(string name, Type controller)
        {
            this.Name = name;
            this.Controller = controller;
        }
    }
}
