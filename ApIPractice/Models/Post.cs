using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApIPractice.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        //So we wana put parsing code in here to help make the code more portable

        public Post()
        {

        }

        

        public Post(string APIText, int i)
        {
            JObject redditJson = JObject.Parse(APIText);

            List<JToken> posts = redditJson["Search"].ToList();

            JToken post = posts[i];

            Title = post["Title"].ToString();
            Year = post["Year"].ToString();
            Type = post["Type"].ToString();
            Poster = post["Poster"].ToString();

        }

    }
}