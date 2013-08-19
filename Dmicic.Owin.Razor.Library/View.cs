using System;

namespace Dmicic.Owin.Razor.Library
{
    public class View : IView
    {
        public object Model { get; set; }
        public string ViewName { get; set; }

        public View(string viewName, object model)
        {
            this.ViewName = viewName;
            this.Model = model;
        }
    }
}
