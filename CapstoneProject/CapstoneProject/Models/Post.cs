using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public DateTime date { get; set; }


        [ForeignKey("Band")]
        public int? bandId { get; set; }
        public Band Band { get; set; }

        public bool toFacebook {get; set;}

        public bool toTwitter { get; set; }

        public bool toSocial { get; set; }


    }
}