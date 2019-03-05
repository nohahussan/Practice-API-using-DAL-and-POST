using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ApIPractice.Models
{
    public class DAL
    {
        public static string GetData(string Url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(Url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string data = rd.ReadToEnd();

            return data;
        }
        
        public static Post GetPost(string title,int i)
        {
            
            string apikey = "&apikey=70a772b9&";
            string output = GetData($"http://www.omdbapi.com/?s={title}{apikey}");
            Post rp = new Post(output, i);

            return rp;
        }

    }
}