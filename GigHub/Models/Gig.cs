using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class Gig
    {
        public int ID { get; set; }

        public ApplicationUser Artist { get; set; }
        public DateTime dateTime { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }

    }
}