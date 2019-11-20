using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Event
    {
        // Event id
        [Key]
        public int EventId { get; set; }

        public DateTime date { get; set; }

        public string venueName { get; set; }

        [ForeignKey("Band")]
        public int? bandId { get; set; }
        public Band Band { get; set; }





    }
}