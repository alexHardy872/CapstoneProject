using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Access
    {

        [Key]
        public int AccessId { get; set; }


        

        public string facebookTempToken { get; set; }

        

        public string spotifyTempToken { get; set; }

        

        public string youtubeTempToken { get; set; }





        // client secrets ect?



    }
}