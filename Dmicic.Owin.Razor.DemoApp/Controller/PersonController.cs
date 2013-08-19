using System;
using System.Collections.Generic;
using Dmicic.Owin.Razor.DemoApp.Model;
using Dmicic.Owin.Razor.Library;

namespace Dmicic.Owin.DemoApp.Controller
{
    public class PersonController
    {
        public IView Index()
        {
            return new View("Index", new Person() { Firstname = "Max" });
        }

        public IView All()
        {
            var result = new List<Person>();

            for (var x = 0; x < 150; x++)
            {
                result.Add(new Person() { Firstname = "Max " + x });
            }

            return new View("All", result);
        }
    }
}
