using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigHub3.Models;

namespace GigHub3.ViewModels
{
    public class GigFormViewModel
    {
        [Requierd]
        public string Venue { get; set; }

        [Requierd]
        public string Date { get; set; }

        [Requierd]
        public string Time { get; set; }

        [Requierd]
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }

    public class RequierdAttribute : Attribute
    {
    }
}