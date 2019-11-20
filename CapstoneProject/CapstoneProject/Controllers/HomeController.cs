using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //  await Service.FaceBookAPI.GetPermaUrlFromPost();
            //return RedirectToAction("GenerateTokens");
            return View("Index");

        }


        public async Task<ActionResult> GenerateTokens()
        {

            CredentialsAuth cred = new CredentialsAuth(Private.Private.Spotify_clientId, Private.Private.Spotify_clientSecret );

            Token token = await cred.GetToken();


            string artistId = "5tWbDIXx7HTHSwBZNJrRgQ";

            SpotifyWebAPI api = new SpotifyWebAPI
            {
                AccessToken = token.AccessToken,
                TokenType = token.TokenType

            };

            var result = api.GetArtist(artistId);

            var result2 = api.GetArtistsTopTracks(artistId, "US");

            int popularity = result2.Tracks[1].Popularity;
            
            foreach(var song in result2.Tracks)
            {

            }








            return RedirectToAction("About");

        }








        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}