using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Band
    {

        [Key]
        public int BandId { get; set; }

        public string bandName { get; set; }

        public string facebookPageId { get; set; }

        public string spotifyBandId { get; set; }

        public string youtubeChannelId { get; set; }

        public string twitterPageId { get; set; }

        public int customSocialId { get; set; }


        [ForeignKey("Access")]
        public int? accessId { get; set; }
        public Access access { get; set; }


        [ForeignKey("ApplicationUser")]//fk attr
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }//the class the fk attr is referencing




    }
}