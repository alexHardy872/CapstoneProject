using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CapstoneProject.Service
{
    public class FaceBookAPI
    {




        // grab perma-Link Id for rendering embedded withing call for posts?

        public static async Task<string> GetPermaUrlFromPost()
        {
            string PostId = "1308735289192501_2556755371057147";
            // Make input parameter? hmmmm.

            string requestUri = string.Format("https://graph.facebook.com/{0}/posts?fields=permalink_url&access_token={1}", Private.Private.facebookPageId, Private.Private.facebookAccessToken);

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestUri);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            dynamic stuff = await Task.Run(() => JObject.Parse(content));
            var data = stuff["data"];

            var permalink_url = "";

            foreach(var post in data)
            {
                if (post.id == PostId)
                {
                    permalink_url = post.permalink_url;
                    break;
                }
            }

            return permalink_url;
        }






    }
}