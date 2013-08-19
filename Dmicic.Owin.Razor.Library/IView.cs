using System;

namespace Dmicic.Owin.Razor.Library
{
    public interface IView
    {
        object Model { get; set; }
        string ViewName { get; set; }
    }
}
